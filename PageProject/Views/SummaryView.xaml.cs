using PageProject.ViewModels;
using System.Windows;

namespace PageProject.Views
{
    public partial class SummaryView : Window
    {
        private SummaryViewModel summaryViewModel;

        public SummaryViewModel SummaryViewModel
        {
            get { return summaryViewModel; } 
            set { summaryViewModel = value; }
        }


        public SummaryView(SummaryViewModel SVM)
        {
            this.SummaryViewModel = SVM;
            this.DataContext = SVM;


            InitializeComponent();
        }

        private void Button_Confirm_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Close();
            this.Owner.Owner.Close();
        }
    }
}
