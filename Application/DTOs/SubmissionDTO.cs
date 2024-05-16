using Application.Dtos.QuestionDtos;
using Application.Dtos.QuestionTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class SubmissionDTO

    {
        public string SubmissionId { get; set; }
        public string QuestionId { get; set; }

        public string Answer { get; set; }

        public IEnumerable<QuestionDto> Questions { get; set; }

    }
}
