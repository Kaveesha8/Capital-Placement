using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class QuestionEntity
    {
        public string QuestionId { get; set; }
        public QuestionTypeEntity QuestionType { get; set; }

        public bool IsManadory { get; set; }

        public bool IsInternal { get; set; } = false;

        public bool IsHidden { get; set; } = false;

        public string ProgramId {  get; set; }

        public ProgramEntity Program { get; set; }
    }
}
