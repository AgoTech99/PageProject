using System.ComponentModel;


namespace PageProject.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        private string _mName = "Microwave-";
        private string _rName = "Resistor-";

        private readonly List<int> _mList = new(Enumerable.Range(0, 9).ToList());
        private readonly List<int> _rList = new(Enumerable.Range(0, 9).ToList());

        public event PropertyChangedEventHandler PropertyChanged;

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
