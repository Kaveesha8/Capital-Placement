using Application.DTOs;

namespace Application.Dtos.QuestionTypeDtos
{
    public class DateQuestionType : QuestionType
    {
        public DateQuestionType()
        {
            Type = QuestionTypeEnum.Date;
        }

        public DateOnly Answer { get; set; }
    }
}