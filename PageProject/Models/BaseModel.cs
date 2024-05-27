using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace PageProject.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        private string _mName = "Microwave-";
        private string _rName = "Resistor-";

        private readonly List<int> _mList = new(Enumerable.Range(0, 10).ToList());
        private readonly List<int> _rList = new(Enumerable.Range(0, 10).ToList());

        public string MicrowaveName { get => _mName; set => _mName = value; }
        public string ResistorName { get => _rName; set => _rName = value; }

        public List<int> MicrowaveList { get { return _mList; } }
        public List<int> ResistorList { get { return _rList; } }


        private int _mN;
        private int _rN;

        public int MSelection
        {
            get => _mN;
            set
            {
                if (_mN != value)
                {
                    _mN = value;
                    OnPropertyChanged(nameof(MSelection));

                    if (_rN != 0)
                    {
                        _rN = 0;
                        OnPropertyChanged(nameof(RSelection));
                    }
                }
            }
        }

        public int RSelection
        {
            get => _rN;
            set
            {
                if (_rN != value)
                {
                    _rN = value;
                    OnPropertyChanged(nameof(RSelection));


                    if (_mN != 0)
                    {
                        _mN = 0;
                        OnPropertyChanged(nameof(MSelection));
                    }
                }
            }
        }


        private Visibility img1 = Visibility.Hidden;
        private Visibility img2 = Visibility.Hidden;
        public Visibility Img1
        {
            get { return img1; }
            set { img1 = value; OnPropertyChanged(nameof(Img1)); }
        }        
        public Visibility Img2
        {
            get { return img2; }
            set { img2 = value; OnPropertyChanged(nameof(Img2)); }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public BaseModel(int Number) 
        {
            _mName += Number;
            _rName += Number;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
