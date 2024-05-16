using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.QuestionTypeDtos
{
    public class ParagraphQuestionType : QuestionType
    {
        public ParagraphQuestionType()
        {
            Type = QuestionTypes.Paragraph;
        }

        public string Answer { get; set; }
    }
}