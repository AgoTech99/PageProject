using PageProject.Models;
using System.ComponentModel;

namespace PageProject.ViewModels
{
    public class AggregateViewModel : INotifyPropertyChanged
    {

        public string prova = "titoloprova";

        public AggregateModel AggregateModel { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;


        public AggregateViewModel(AggregateModel AM)
        {
            AggregateModel = AM;
        }

        


    }
}
