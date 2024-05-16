using Application.Dtos;
using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProgramService
    {
        
        Task<ProgramDto> GetProgram(string id);
        Task<IEnumerable<ProgramDto>> GetAllPrograms();
        Task<ProgramDto> CreateProgram(ProgramDto program);
        Task UpdateProgram(string id, ProgramDto program);
        Task DeleteProgram(string id);
        Task<SubmissionDTO> SubmitAnswers(SubmissionDTO programAnswers);
    }
}
