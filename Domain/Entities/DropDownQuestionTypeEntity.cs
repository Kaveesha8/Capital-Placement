
using Common;
using Domain.Entities;

namespace Domain.Entities
{
    public class DropDownQuestionTypeEntity : QuestionTypeEntity
    {
        public DropDownQuestionTypeEntity()
        {
            Type = QuestionType.DropDown;
            _isOtherOptionEnabled = false;
        }

        public int Answer { get; set; }

        public Dictionary<int, string> DropDownOptions { get; set; } = new Dictionary<int, string>();

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
                    DropDownOptions.Add(0, "Other");
                }
            }
        }

        public string OtherOptionAnswer { get; set; }
    }
}