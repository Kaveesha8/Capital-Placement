using Application.Dtos;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repositories
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly ProgramDbContext _programDbContext;

        public ProgramRepository(ProgramDbContext programDbContext)
        {
            _programDbContext = programDbContext;
        }

        public async Task<ProgramEntity> CreateProgram(ProgramEntity program)
        {
            await _programDbContext.Program.AddAsync(program);
            await _programDbContext.SaveChangesAsync();
            return program;
        }

        public async Task DeleteProgram(string id)
        {
            var program = await _programDbContext.Program.FirstOrDefaultAsync(x => x.ProgramId == id);
            if (program != null)
            {
                _programDbContext.Program.Remove(program);
                await _programDbContext.SaveChangesAsync();
            }
        }


        public async Task<ProgramEntity> GetProgram(string id)
        {
            var program = await _programDbContext.Program.FirstOrDefaultAsync(x => x.ProgramId == id);
            return program;
        }

        public async Task<IEnumerable<ProgramEntity>> GetAllPrograms()
        {
            return await _programDbContext.Program.ToListAsync();
        }

        public async Task UpdateProgram(string id, ProgramEntity program)
        {
            var programToUpdate = await _programDbContext.Program.FirstOrDefaultAsync(x => x.ProgramId == id);
            if (programToUpdate != null)
            {
                programToUpdate.ProgramId = id;
                programToUpdate.Questions = program.Questions;
                programToUpdate.Title = program.Title;
                programToUpdate.Description = program.Description;

                await _programDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Program not found.");
            }
        }


        public async Task<SubmissionEntity> SubmitAnswers(SubmissionEntity programAnswers)
        {
            await _programDbContext.Answer.AddAsync(programAnswers);
            await _programDbContext.SaveChangesAsync();
            return programAnswers;
        }
    }
}