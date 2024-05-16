
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Entities
{
    public  class ProgramEntity
    {
        public string ProgramId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public List<QuestionEntity> Questions { get; set; } = new List<QuestionEntity>();
    }
}
