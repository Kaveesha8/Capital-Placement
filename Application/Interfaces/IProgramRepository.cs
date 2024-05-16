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
   public interface IProgramRepository
    {
        Task<ProgramEntity> GetProgram(string id);
        Task<IEnumerable<ProgramEntity>> GetAllPrograms();
        Task<ProgramEntity> CreateProgram(ProgramEntity program);
        Task UpdateProgram(string id, ProgramEntity program);
        Task DeleteProgram(string id);
        Task<SubmissionEntity> SubmitAnswers(SubmissionEntity programAnswers);
    }
}
