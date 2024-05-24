using PageProject.Models;
using System.ComponentModel;

namespace PageProject.ViewModels
{
    public class AggregateViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private AggregateModel _aggregateModel;

        public AggregateModel AggregateModel { get => _aggregateModel; set => _aggregateModel = value; }

        public AggregateViewModel(AggregateModel AM)
        {
            _aggregateModel = AM;
        }

    }
}
