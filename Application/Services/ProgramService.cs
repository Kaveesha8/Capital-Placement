using Application.Dtos;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.Features;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProgramService : IProgramService
    {
        private readonly IProgramRepository _programRepository;
        private readonly IMapper _mapper;

        public ProgramService(IProgramRepository programRepository, IMapper mapper)
        {
            _programRepository = programRepository;
            _mapper = mapper;
        }

        public async Task<ProgramDto> CreateProgram(ProgramDto program)
        {
            var programEntity = _mapper.Map<ProgramEntity>(program);
            await _programRepository.CreateProgram(programEntity);
            return program;
        }

        public async Task DeleteProgram(string id)
        {
            await _programRepository.DeleteProgram(id);
        }

        public async Task<ProgramDto> GetProgram(string id)
        {
            var programentity = await _programRepository.GetProgram(id);
            var programDto = _mapper.Map<ProgramDto>(programentity);
            return programDto;
        }

        public async Task<IEnumerable<ProgramDto>> GetAllPrograms()
        {
            var programEntityList = _programRepository.GetAllPrograms();
            var programDtoList = _mapper.Map<List<ProgramDto>>(programEntityList);
            return programDtoList;
        }

        public async Task<SubmissionDTO> SubmitAnswers(SubmissionDTO programAnswers)
        {
            var submissionEntity = _mapper.Map<SubmissionEntity>(programAnswers);
            await _programRepository.SubmitAnswers(submissionEntity);
            return programAnswers;
        }


        public async Task UpdateProgram(string id, ProgramDto program)
        {
            var programEntity = _mapper.Map<ProgramEntity>(program);
            await _programRepository.UpdateProgram(id, programEntity);
        }
    }
}
