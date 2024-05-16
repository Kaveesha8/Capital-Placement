using Application.Dtos;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Submission_Form.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly IProgramService _programService;
        public ProgramController(IProgramService programService)
        {
            _programService = programService;
        }

        [HttpGet("{id}")]
        public ActionResult<ProgramDto> GetProgram(string id)
        {
            var program = _programService.GetProgram(id);
            
            if (program == null)
            {
                return NotFound(); 
            }
            return Ok(program);
        }

        [HttpGet("GetAllPrograms")]
        public ActionResult<List<ProgramDto>> Get()
        {
            var programList = _programService.GetAllPrograms();
            return Ok(programList);

        }


        [HttpPost]
        public async Task<ActionResult<ProgramDto>> CreateProgram(ProgramDto program)
        {
            await _programService.CreateProgram(program);
            
            return Ok();
         
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProgram(string id, ProgramDto program)
        {
            var existingProgram = await _programService.GetProgram(id);

            if (existingProgram == null)
            {
                return NotFound();
            }
            else
            {
                await _programService.UpdateProgram(id, existingProgram);
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgram(string id)
        {
            var program = await _programService.GetProgram(id); 

            if (program == null)
            {
                return NotFound();
            }
            else
            {
                await _programService.DeleteProgram(id); 
            }

            return NoContent();
        }



        [HttpPost("SubmitAnswer")]
        
        public async Task<ActionResult<ProgramDto>> SubmitAnswers(SubmissionDTO programAnswers)
        {
            await _programService.SubmitAnswers(programAnswers);

            return Ok();

        }
    }
}