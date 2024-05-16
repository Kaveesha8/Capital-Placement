
using Common;
using Domain.Entities;

namespace Domain.Entities
{
    public class YesNoQuestionTypeEntity : QuestionTypeEntity
    {
        public YesNoQuestionTypeEntity()
        {
            Type = QuestionType.YesNo;
        }

        public bool Answer { get; set; }
    }
}