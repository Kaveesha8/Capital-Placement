using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SubmissionQuestionEntity
    {
        public string QuestionId { get; set; }
        public SubmissionQuestionTypeEntity QuestionType { get; set; }

        public bool IsManadory { get; set; }

        public bool IsInternal { get; set; } = false;

        public bool IsHidden { get; set; } = false;

        public string SubmissionId { get; set; }

        public SubmissionEntity Submission { get; set; }


    }
}
