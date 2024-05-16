
using Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NumericQuestionTypeEntity : QuestionTypeEntity
    {
        public NumericQuestionTypeEntity()
        {
            Type = QuestionType.Number;
        }

        public int Answer { get; set; }
    }
}