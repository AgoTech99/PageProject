using PageProject.ViewModels;
using System.Windows;


namespace PageProject.Views
{
    public partial class AggregateView : Window
    {
        public AggregateView(AggregateViewModel AVM)
        {
            DataContext = AVM;
            InitializeComponent();
        }
    }
}
