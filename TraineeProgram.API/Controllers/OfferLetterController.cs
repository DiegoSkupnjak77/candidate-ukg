using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.OfferLetterException;

namespace TraineeProgram.API.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [Authorize]
    [ApiController]
    [Route("api/offerLetters")]
    public class OfferLetterController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOfferLetterService _offerLetterService;

        public OfferLetterController(IOfferLetterService offerLetterService, IMapper mapper)
        {
            _offerLetterService = offerLetterService;
            _mapper = mapper;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<OfferLetterReadDto>>> GetAllAsync()
        //{
        //    var result = await _offerLetterService.GetAllAsync();
        //    List<OfferLetterReadDto> resultDto = result.Where(c => c != null)
        //        .Select(x => _mapper.Map<OfferLetterReadDto>(x)).ToList();
        //    return Ok(resultDto);
        //}

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<ActionResult<OfferLetterReadDto>> GetByIdAsync([FromRoute] int id)
        //{
        //    var result = await _offerLetterService.GetByIdAsync(id);
        //    var resultReadDto = _mapper.Map<OfferLetterReadDto>(result);
        //    return resultReadDto != null ? Ok(resultReadDto) : NotFound();
        //}

        //[HttpPost]
        //public async Task<ActionResult<OfferLetterReadDto>> CreateCandidate(OfferLetterDto offerLetter)
        //{
        //    try
        //    {
        //        var result = await _offerLetterService.CreateAsync(_mapper.Map<OfferLetter>(offerLetter));
        //        var offerLetterReadDto = _mapper.Map<OfferLetterReadDto>(result);
        //        return Ok(offerLetterReadDto);
        //    }
        //    catch (EntityDoesntExistException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (FieldRequiredException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Internal server error");
        //    }
        //}
    }
}