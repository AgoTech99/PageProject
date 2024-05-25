using PageProject.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PageProject.ViewModels
{
    public class AggregateViewModel : INotifyPropertyChanged
    {
        private AggregateModel _aggregateModel { get; set; }

        public AggregateViewModel(AggregateModel AM)
        {
            _aggregateModel = AM;
        }



        public ObservableCollection<BaseModel> ModelsList 
        { 
            get { return _aggregateModel.ModelsList; }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
