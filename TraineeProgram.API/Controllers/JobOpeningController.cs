using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.JobOpeningException;

namespace TraineeProgram.API.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [Route("api/jobOpenings")]
    [ApiController]
    public class JobOpeningController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IJobOpeningService _jobOpeningService;

        public JobOpeningController(IJobOpeningService jobOpeningService, IMapper mapper)
        {
            _jobOpeningService = jobOpeningService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobOpeningDto>>> GetAllAsync()
        {
            var result = await _jobOpeningService.GetAllAsync();
            List<JobOpeningReadDto> resultDto = result.Where(c => c != null)
                .Select(x => _mapper.Map<JobOpeningReadDto>(x)).ToList();
            return Ok(resultDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<JobOpeningReadDto>> GetByIdAsync([FromRoute] int id)
        {
            var result = await _jobOpeningService.GetByIdAsync(id);
            var resultDto = _mapper.Map<JobOpeningReadDto>(result);
            return resultDto != null ? Ok(resultDto) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<JobOpeningReadDto>> CreateJobOpening(JobOpeningDto jobOpening)
        {
            try
            {
                var result = await _jobOpeningService.CreateAsync(_mapper.Map<JobOpening>(jobOpening));
                var jobOpeningReadDto = _mapper.Map<JobOpeningReadDto>(result);
                return Ok(jobOpeningReadDto);
            }
            catch (FieldRequiredException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}