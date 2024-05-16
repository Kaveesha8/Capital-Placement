using Application.DTOs;

namespace Application.Dtos.QuestionTypeDtos
{
    public class YesNoQuestionType : QuestionType
    {
        public YesNoQuestionType()
        {
            Type = QuestionTypeEnum.YesNo;
        }

        public bool Answer { get; set; }
    }
}