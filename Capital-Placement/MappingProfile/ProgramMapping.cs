using Application.Dtos;
using Application.Dtos.QuestionDtos;
using Application.Dtos.QuestionTypeDtos;
using Application.DTOs;
using AutoMapper;
using AutoMapper.Features;
using Domain.Entities;

namespace Submission_Form.MappingProfile
{
    public class ProgramMapping : Profile
    {
        public ProgramMapping() {
            CreateMap<ProgramEntity, ProgramDto>()
                .ForMember(dest => dest.PersonalInformation, opt => opt.MapFrom(src => src.Questions.FindAll(q => q.IsManadory)))
                .ForMember(dest => dest.CustomQuestions, opt => opt.MapFrom(src => src.Questions.FindAll(q => !q.IsManadory)));

            CreateMap<ProgramDto, ProgramEntity>()
                .ForMember(dest => dest.Questions, opt => opt.MapFrom(src => src.PersonalInformation.Concat(src.CustomQuestions)));


            CreateMap<QuestionType, SubmissionQuestionTypeEntity>().ReverseMap();

            CreateMap<QuestionDto, SubmissionQuestionEntity>().ReverseMap();

            CreateMap<SubmissionDTO, SubmissionEntity>().ReverseMap();
        }
    }
}
