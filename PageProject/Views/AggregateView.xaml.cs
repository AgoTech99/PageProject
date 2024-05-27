using PageProject.ViewModels;
using System.Configuration;
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
            this.Closed += AggregateView_Closed;
            InitializeComponent();
        }

        private void AggregateView_Closed(object? sender, EventArgs e)
        {
            this.Owner.Show();
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _aggregateViewModel.ChangeVisibility();
        }
    }
}
