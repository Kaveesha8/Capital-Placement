
using Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ParagraphQuestionTypeEntity : QuestionTypeEntity
    {
        public ParagraphQuestionTypeEntity()
        {
            Type = QuestionType.Paragraph;
        }

        public string Answer { get; set; }
    }
}