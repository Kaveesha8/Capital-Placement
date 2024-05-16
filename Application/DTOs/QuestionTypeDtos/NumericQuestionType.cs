using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.QuestionTypeDtos
{
    public class NumericQuestionType : QuestionType
    {
        public NumericQuestionType()
        {
            Type = QuestionTypeEnum.Number;
        }

        public int Answer { get; set; }
    }
}