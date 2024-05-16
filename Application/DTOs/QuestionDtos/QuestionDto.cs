using Application.Dtos.QuestionTypeDtos;

namespace Application.Dtos.QuestionDtos
{
    public class QuestionDto
    {
        public string QuestionId { get; set; }
        public QuestionType QuestionType { get; set; }
        

        public bool IsManadory { get; set; }

        public bool IsInternal { get; set; } = false;

        public bool IsHidden { get; set; } = false;
    }
}