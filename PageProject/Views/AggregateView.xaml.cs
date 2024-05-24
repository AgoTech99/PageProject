using PageProject.ViewModels;
using System.Windows;


namespace PageProject.Views
{
    /// <summary>
    /// Interaction logic for AggregateView.xaml
    /// </summary>
    public partial class AggregateView : Window
    {
        public AggregateView(AggregateViewModel AVM)
        {
            DataContext = AVM;
            InitializeComponent();
        }
    }
}
