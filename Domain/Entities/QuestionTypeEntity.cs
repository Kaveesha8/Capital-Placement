using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class QuestionTypeEntity
    {
        public string Question { get; set; }
        public QuestionType Type { get; set; }

        public string QuestionId { get; set; }

        public QuestionEntity QuestionEntity { get; set; }
    }
}
