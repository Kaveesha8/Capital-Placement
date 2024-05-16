using Application.DTOs;

namespace Application.Dtos.QuestionTypeDtos
{
    public class YesNoQuestionType : QuestionType
    {
        public YesNoQuestionType()
        {
            Type = QuestionTypes.YesNo;
        }

        public bool Answer { get; set; }
    }
}