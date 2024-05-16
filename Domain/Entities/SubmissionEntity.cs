
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SubmissionEntity
    {
        public string SubmissionId { get; set; }
        public string QuestionId { get; set; }

        public string Answer { get; set; }

        public IEnumerable<SubmissionQuestionEntity> Questions { get; set; }
    }
}
