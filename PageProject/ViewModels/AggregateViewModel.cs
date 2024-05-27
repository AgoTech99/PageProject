using PageProject.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

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

        private bool MSelected;
        private bool RSelected;

        public void ChangeVisibility()
        {
            ModelsList[1].Img1 = Visibility.Hidden;
            ModelsList[1].Img2 = Visibility.Hidden;

            MSelected = ModelsList[0].MSelection != 0;
            RSelected = ModelsList[0].RSelection != 0;


            for (int i = 1; i < ModelsList.Count; i++) 
            {
                if (ModelsList[i].MSelection != 0 && RSelected)
                {
                    ModelsList[i].Img1 = Visibility.Visible;
                }
                if (ModelsList[i].RSelection != 0 && MSelected)
                {
                    ModelsList[i].Img2 = Visibility.Visible;
                }
            }
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
