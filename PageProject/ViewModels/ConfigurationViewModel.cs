using PageProject.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace PageProject.ViewModels
{
    public class ConfigurationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MultiserialModel> multiSerialModelsList;
        private ObservableCollection<ScaleModel> scaleModelsList;
        private MicrowaveModel microwaveModel;
        private ResistiveModel resistiveModel;
        private string status;
        private int portCount;
        private int comboSelectedNumber;
        private Visibility panelVisibility = Visibility.Collapsed;
        private int comboSelectedType;
        private int previousComboSelectedNumber;

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
                    PortCount += value-previousComboSelectedNumber;
                    previousComboSelectedNumber = value;
                    comboSelectedNumber = value;
                    PanelVisibility = Visibility.Visible;
                    OnPropertyChanged(nameof(ComboSelectedNumber));
                }
                else
                {
                    PortCount += previousComboSelectedNumber;
                    previousComboSelectedNumber = 0;
                    PanelVisibility = Visibility.Collapsed;
                }
            }
        }

        public int ComboSelectedType
        {
            get { return comboSelectedType; }
            set 
            { 
                comboSelectedType = value; 
                ResistiveModel.ProbeType = value;
            }
        }



        public ConfigurationViewModel(ObservableCollection<MultiserialModel> MSMList, ObservableCollection<ScaleModel> SMList, ResistiveModel RM, MicrowaveModel MM) 
        {
            MultiserialModelsList = MSMList;
            ScaleModelsList = SMList;
            MicrowaveModel = MM;
            ResistiveModel = RM;
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

        public void AddScale()
        {
            if (ScaleModelsList.Count < 16)
            {
                PortCount++;
                ScaleModelsList.Add(new ScaleModel(ScaleModelsList.Count() + 1));
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
            int zambo = portCount;
            MultiserialModelsList.Clear();

            while ((zambo / 8) >= 1) 
            {
                zambo -= 8;
                MultiserialModelsList.Add(new MultiserialModel(MultiserialModelsList.Count()+1, 8));
            }
            while (zambo > 0)
            {
                zambo--;
                try
                {
                    if (MultiserialModelsList[MultiserialModelsList.Count() - 1].ActivePort < 8)
                    {
                        MultiserialModelsList[MultiserialModelsList.Count() - 1].ActivePort++;
                    }
                    else
                    {
                        MultiserialModelsList.Add(new MultiserialModel(MultiserialModelsList.Count() + 1, 1));
                    }
                    
                }
                catch
                {
                    MultiserialModelsList.Add(new MultiserialModel(MultiserialModelsList.Count() + 1,1));
                }
            }

        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
