

namespace PageProject.Models
{
    public class BaseModel
    {
        private string _mName = "Microwave-";
        private string _rName = "Resistor-";

        private readonly List<int> _mList = new(Enumerable.Range(1, 10).ToList());
        private readonly List<int> _rList = new(Enumerable.Range(1, 10).ToList());

        public string MicrowaveName { get => _mName; set => _mName = value; }
        public string ResistorName { get => _rName; set => _rName = value; }

        public List<int> MicrowaveList { get { return _mList; } }
        public List<int> ResistorList { get { return _rList; } }

        

        public BaseModel(int Number) 
        {
            _mName += Number;
            _rName += Number;

        }

    }
}
