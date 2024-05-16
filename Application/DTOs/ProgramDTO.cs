using Application.Dtos.QuestionDtos;
using Application.Dtos.QuestionTypeDtos;

namespace Application.Dtos
{
    public class ProgramDto
    {
        public string ProgramId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public List<QuestionDto> PersonalInformation { get; set; } = new List<QuestionDto>()
        {
            new QuestionDto
            {
                IsManadory = true,
                QuestionType = new ParagraphQuestionType { Question = "First Name" }

            },
             new QuestionDto
            {
                IsManadory = true,
                QuestionType = new ParagraphQuestionType { Question = "Last Name"  }
            },
              new QuestionDto
            {
                IsManadory = true,
                QuestionType = new ParagraphQuestionType {  Question = "Email"  }
            }
        };

        public List<QuestionDto> CustomQuestions { get; set; } = new List<QuestionDto>();
    }
}