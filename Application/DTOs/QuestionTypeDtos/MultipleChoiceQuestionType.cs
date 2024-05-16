using Application.Dtos.QuestionTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.QuestionTypeDtos
{
    public class MultipleChoiceQuestionType : QuestionType
    {
        public MultipleChoiceQuestionType() {

            Type = QuestionTypes.MultiplChoice;
            _isOtherOptionEnabled = false;
        }
        

        public int Answer { get; set; }

        public Dictionary<int, string> MultipleChoiceOptions { get; set; } = new Dictionary<int, string>();

        private bool _isOtherOptionEnabled;

        public bool IsOtherOptionEnabled
        {
            get
            {
                return _isOtherOptionEnabled;
            }
            set
            {
                _isOtherOptionEnabled = value;

                if (_isOtherOptionEnabled)
                {
                    MultipleChoiceOptions.Add(0, "Other");
                }
            }
        }

        public string OtherOptionAnswer { get; set; }
        public int MaxChoicesAllowed { get; set; }
    }
}
