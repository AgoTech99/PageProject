using PageProject.ViewModels;
using System.Windows;


namespace PageProject.Views
{
    public partial class AggregateView : Window
    {
        private readonly AggregateViewModel _aggregateViewModel;
        public AggregateView(AggregateViewModel AVM)
        { 
            _aggregateViewModel = AVM;
            DataContext = AVM;
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _aggregateViewModel.ChangeVisibility();
        }
    }
}
