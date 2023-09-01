using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.CandidateException;

namespace TraineeProgram.API.Controllers
{

    //[EnableCors("_myAllowSpecificOrigins")]
    [Authorize]
    [Route("api/candidates")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICandidateService _candidateService;
        private readonly IJobOpeningService _jobOpeningService;
        private readonly IInterviewService _InterviewService;
        public CandidateController(ICandidateService candidateService, IJobOpeningService jobOpeningService, IInterviewService interviewService, IMapper mapper)
        {
            _candidateService= candidateService;
            _jobOpeningService= jobOpeningService;
            _InterviewService= interviewService;
            _mapper =mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidateReadDto>>> GetAllAsync()
        {
            var result = await _candidateService.GetAllAsync();
            List<CandidateReadDto> resultReadDto = result.Where(c => c != null)
                .Select(x => _mapper.Map<CandidateReadDto>(x)).ToList();
            return Ok(resultReadDto);
        }

        [HttpPost]
        public async Task<ActionResult<CandidateReadDto>> CreateCandidate(CandidateDto newCandidate)
        {
            try
            {
                newCandidate.IsActive = true;
                var result = await _candidateService.CreateAsync(_mapper.Map<Candidate>(newCandidate));
                return Ok(_mapper.Map<CandidateReadDto>(result));
            }
            catch (FieldRequiredException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DuplicateCandidateException ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<CandidateReadDto>> GetByIdAsync([FromRoute] int id)
        {
            var result = await _candidateService.GetByIdAsync(id);
            var resultReadDto = _mapper.Map<CandidateReadDto>(result);
            return resultReadDto != null ? Ok(resultReadDto) : NotFound();
        }

        [HttpGet]
        [Route("api/candidates/home")]
        public async Task<ActionResult<IEnumerable<CandidateHomeDto>>> ListOfCandidates()
        {
            List<CandidateHomeDto> candidateHomeDtos = new List<CandidateHomeDto>();
            var listCandidates = await _candidateService.ListOfCandidates();
            foreach (var candidate in listCandidates)
            {
                CandidateHomeDto can = new CandidateHomeDto();
                var jobOpening = await _jobOpeningService.GetByIdAsync(candidate.IdJobOpening);
                can.Id= candidate.Id;
                can.Name= candidate.FirstName;
                can.Position= jobOpening.Position;
                can.Deparment= jobOpening.Department;
                var lastInterviewCandidate = _mapper.Map<InterviewReadDto>(await _InterviewService.GetLastInterviewByCandidateIdAsync(candidate.Id));
                can.StepOfProcess=  lastInterviewCandidate.InterviewName;
                can.Status= (bool)candidate.IsActive;
                candidateHomeDtos.Add(can);
            }
            return Ok(candidateHomeDtos);
        }

        [HttpGet]
        [Route("api/candidates/interviews/{id}")]
        public async Task<ActionResult<IEnumerable<InterviewReadDto>>> GetInterviewByCandidateId([FromRoute] int id)
        {

            var result = await _candidateService.GetInterviewByCandidateId(id);
            List<InterviewReadDto> resultReadDto = result.Where(c => c != null)
            .Select(x => _mapper.Map<InterviewReadDto>(x)).ToList();
            return resultReadDto;
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            bool ok = await _candidateService.DeleteAsync(id);

            return ok ? NoContent() : NotFound("The candidate cannot be deleted ");
        }
        [HttpPut]
        public async Task<ActionResult<CandidateDto>> UpdateAsync(CandidateReadDto candidate)
        {
            var result = await _candidateService.UpdateAsync(_mapper.Map<Candidate>(candidate));
            var resultDto = _mapper.Map<CandidateDto>(result);
            return resultDto != null ? Ok(resultDto) : NotFound();
        }
    }
}