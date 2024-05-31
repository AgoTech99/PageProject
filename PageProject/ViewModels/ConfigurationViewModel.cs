using PageProject.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using static PageProject.Models.EnumResistive;

namespace PageProject.ViewModels
{
    public class ConfigurationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MultiserialModel> multiSerialModelsList;
        private ObservableCollection<ScaleModel> scaleModelsList;
        private MicrowaveModel microwaveModel;
        private ResistiveModel resistiveModel;
        private Visibility panelVisibility = Visibility.Collapsed;
        private SolidColorBrush bgColor;

        private string status;
        private string textBoxText;

        private int portCount;
        private int comboSelectedNumber;
        private ResistiveEnum comboSelectedType;
        private int previousComboSelectedNumber;
        private int previousTextBoxNumber;
        private int maxMultiserialNumber;
        private int maxMultiserialPorts;
        private int maxScalesNumber;
        private int maxMicrowaveNumber;

        private bool isTypeSelected;
        private bool isTextInputOk = true;


        public ObservableCollection<MultiserialModel> MultiserialModelsList
        {
            get { return multiSerialModelsList; }
            set { multiSerialModelsList = value; }
        }
        
        public ObservableCollection<ScaleModel> ScaleModelsList
        {
            get { return scaleModelsList; }
            set { scaleModelsList = value; }
        }
        
        public MicrowaveModel MicrowaveModel
        {
            get { return microwaveModel; }
            set { microwaveModel = value; }
        }
        
        public ResistiveModel ResistiveModel
        {
            get { return resistiveModel; }
            set { resistiveModel = value; }
        }
        
        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(nameof(Status)); }
        }
        
        public int PortCount
        {
            get { return portCount; }
            set 
            { 
                portCount = value;
                ChangePortCount();
            }
        }

        public Visibility PanelVisibility
        {
            get { return panelVisibility; }
            set 
            { 
                panelVisibility = value; 
                OnPropertyChanged(nameof(PanelVisibility));
            }
        }

        public int ComboSelectedNumber
        {
            get { return comboSelectedNumber; }
            set 
            { 
                if (value != 0)
                {
                    ResistiveModel.ProbeNumber = value;
                    Status = "";
                    PortCount += value-previousComboSelectedNumber;
                    previousComboSelectedNumber = value;
                    comboSelectedNumber = value;
                    PanelVisibility = Visibility.Visible;
                    OnPropertyChanged(nameof(ComboSelectedNumber));
                }
                else
                {
                    ResistiveModel.ProbeNumber = 0;
                    Status = "";
                    isTypeSelected = true;
                    comboSelectedNumber = value;
                    PortCount -= previousComboSelectedNumber;
                    previousComboSelectedNumber = 0;
                    PanelVisibility = Visibility.Collapsed;
                }
            }
        }

        public ResistiveEnum ComboSelectedType
        {
            get { return comboSelectedType; }
            set 
            {
                Status = "";
                comboSelectedType = value; 
                ResistiveModel.ProbeType = (int)value;
                isTypeSelected = true;
            }
        }

        public SolidColorBrush BgColor
        {
            get { return bgColor; }
            set 
            {
                bgColor = value;
                OnPropertyChanged(nameof (BgColor));
            }
        }

        public string TextBoxText
        {
            get { return textBoxText; }
            set
            {
                textBoxText = value;
                TextBoxChanged();
            }
        }
        
        public int MaxMultiserialNumber
        {
            get => maxMultiserialNumber;
            set => maxMultiserialNumber = value;
        }

        public int MaxScalesNumber 
        {
            get { return maxScalesNumber; }
            set
            {
                maxScalesNumber = value;
            }
        }

        public int MaxMicrowavesNumber
        {
            get { return maxMicrowaveNumber; }
            set
            {
                maxMicrowaveNumber = value;
            }
        }

        public int MaxMultiserialPorts
        {
            get { return maxMultiserialPorts; }
            set
            {
                maxMultiserialPorts = value;
                MultiserialModel.Width = value * 10 + 20 * (value + 1) + 3;
            } 
        }



        public ConfigurationViewModel(ObservableCollection<MultiserialModel> MSMList, ObservableCollection<ScaleModel> SMList, MicrowaveModel MM, Dictionary<string,int> Properties) 
        {
            MultiserialModelsList = MSMList;
            ScaleModelsList = SMList;
            MicrowaveModel = MM;
            ResistiveModel = new ResistiveModel(Properties["MaxResistiveNumber"]);

            MaxMultiserialNumber = Properties["MaxMultiserialNumber"];
            MaxMultiserialPorts = Properties["MaxMultiserialPortNumber"];
            MaxScalesNumber = Properties["MaxScaleNumber"];
            MaxMicrowavesNumber = Properties["MaxMicrowaveNumber"];
        }


        public void RemoveScale()
        {
            if (ScaleModelsList.Count != 0)
            {
                PortCount--;
                ScaleModelsList.RemoveAt(ScaleModelsList.Count - 1);
                OnPropertyChanged(nameof(ScaleModelsList));
                Status = "";
            }
            else
            {
                Status = "Can't Delete More Items";
            }
        }

        public void AddScale(SolidColorBrush color)
        {
            if (ScaleModelsList.Count < MaxScalesNumber)
            {
                PortCount++;
                ScaleModelsList.Add(new ScaleModel(ScaleModelsList.Count() + 1, color));
                OnPropertyChanged(nameof(ScaleModelsList));
                Status = "";
            }
            else
            {
                Status = "Can't Add More Items";
            }
        }

        public void ChangePortCount()
        {
            int pC = portCount;
            MultiserialModelsList.Clear();
            while ((pC / MaxMultiserialPorts) >= 1)
            {
                pC -= MaxMultiserialPorts;
                MultiserialModelsList.Add(new MultiserialModel(MultiserialModelsList.Count + 1, MaxMultiserialPorts));
            }
            if (pC != 0)
            {
                MultiserialModelsList.Add(new(MultiserialModelsList.Count + 1, pC));
            }
        }

        public void TextBoxChanged()
        {
            bool result = int.TryParse(TextBoxText, out int number);
            if (textBoxText != "")
            {
                if (number >= 0 && number <= MaxMicrowavesNumber)
                {
                    Status = "";
                    MicrowaveModel.ProbeNumber = number;
                    isTextInputOk = true;
                    BgColor = Brushes.Transparent;
                    PortCount += number-previousTextBoxNumber;
                    previousTextBoxNumber = number;
                }
                else
                {
                    isTextInputOk = false;
                    Status = $"Number Must Be Between 0 and {MaxMicrowavesNumber}";
                    PortCount -= previousTextBoxNumber;
                    previousTextBoxNumber = 0;
                    BgColor = Brushes.Red;
                }
            }
            else
            {
                Status = "";
                isTextInputOk = true;
                PortCount -= previousTextBoxNumber;
                previousTextBoxNumber = 0;
                BgColor = Brushes.Transparent;
            }
            OnPropertyChanged(nameof(TextBoxText));
        }

        public bool CheckAll()
        {
            if (ScaleModelsList.Count() > 0)
            {
                if (isTextInputOk)
                {
                    if (comboSelectedNumber == 0)
                    {
                        Status = "";
                        return true;
                    }
                    else
                    {
                        if (isTypeSelected)
                        {
                            Status = "";
                            return true;
                        }
                        else
                        {
                            Status = "Resistive Type Not Selected";
                            return false;
                        }
                    }
                }
                else
                {
                    Status = "Text Input Is Incorrect";
                    return false;
                }
            }
            else
            {
                Status = "You Must Add At Least One Scale";
                return false;
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
