using PageProject.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PageProject.ViewModels
{
    public class AggregateViewModel : INotifyPropertyChanged
    {

        private AggregateModel _aggregateModel;

        public AggregateModel AggregateModel { get => _aggregateModel; set => _aggregateModel = value; }

        public event PropertyChangedEventHandler? PropertyChanged;


        private int _selectedEntryM1;
        private int _selectedEntryR1;

        private int _selectedEntryM2;
        private int _selectedEntryR2;

        public int SelectedEntryM1 
        { 
            get => _selectedEntryM1;
            set
            {
                _selectedEntryM1 = value;
                System.Diagnostics.Debug.WriteLine("M1 - "+value.ToString());
                OnPropertyChanged();
                
            }
        }

        public int SelectedEntryR1
        {
            get => _selectedEntryR1;
            set
            {
                _selectedEntryR1 = value;
                System.Diagnostics.Debug.WriteLine("R1 - " + value.ToString());
                OnPropertyChanged();

            }
        }

        public int SelectedEntryM2
        {
            get => _selectedEntryM2;
            set
            {
                _selectedEntryM2 = value;
                System.Diagnostics.Debug.WriteLine("M2 - " + value.ToString());
                OnPropertyChanged();

            }
        }

        public int SelectedEntryR2
        {
            get => _selectedEntryR2;
            set
            {
                _selectedEntryR2 = value;
                System.Diagnostics.Debug.WriteLine("R2 - " + value.ToString());
                OnPropertyChanged();

            }
        }




        public AggregateViewModel(AggregateModel AM)
        {
            _aggregateModel = AM;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
