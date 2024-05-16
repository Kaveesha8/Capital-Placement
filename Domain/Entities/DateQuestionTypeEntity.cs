using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DateQuestionTypeEntity : QuestionTypeEntity
    {
        public DateQuestionTypeEntity()
        { 
            Type = Common.QuestionType.Date;
        }

        public DateOnly Answer { get; set; }
    }
}
