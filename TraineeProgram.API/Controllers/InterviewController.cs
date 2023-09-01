using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.MapToInterviewType;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.InterviewException;

namespace TraineeProgram.API.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [Authorize]
    [Route("api/interviews")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IInterviewService _iInterviewService;

        public InterviewController(IMapper mapper, IInterviewService iIntervieweService)
        {
            _mapper=mapper;
            _iInterviewService=iIntervieweService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InterviewReadDto>>> GetAllAsync()
        {
            var result = await _iInterviewService.GetAllAsync();
            List<InterviewReadDto> resultDto = result.Where(res => res !=null)
                .Select(x => _mapper.Map<InterviewReadDto>(x)).ToList();
            return Ok(resultDto);
        }
        [HttpGet]

        [Route("{id}")]
        public async Task<ActionResult<InterviewReadDto>> GetLastInterviewByCandidateId(int id)
        {
            var result = await _iInterviewService.GetLastInterviewByCandidateIdAsync(id);
            var interviewReadDto = _mapper.Map<InterviewReadDto>(result);
            return Ok(interviewReadDto);
        }

        [HttpPost]
        public async Task<ActionResult<InterviewReadDto>> CreateInterview(InterviewDto interview)
        {
            try
            {
                var mappedInterview = MapType.MapToInterviewType(interview, _mapper);
                var result = await _iInterviewService.CreateAsync(mappedInterview);
                var interviewReadDto = _mapper.Map<InterviewReadDto>(result);
                return Ok(interviewReadDto);
            }
            catch (RelationForeignKeyException ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}