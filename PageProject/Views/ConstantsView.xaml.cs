using System.Windows;
using System.Windows.Input;
using PageProject.ViewModels;

namespace PageProject.Views
{
    public partial class ConstantsView : Window
    {
        private ConstantsViewModel constantViewModel;
        public ConstantsViewModel ConstantViewModel
        {
            get { return constantViewModel; }
            set { constantViewModel = value; }
        }

        public ConstantsView(ConstantsViewModel CVM)
        {
            this.ConstantViewModel = CVM;
            this.DataContext = CVM;
            InitializeComponent();
        }

        private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9) && !(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) && !(e.Key == Key.Delete || e.Key == Key.Back || e.Key == Key.Left || e.Key == Key.Right))
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ConstantViewModel.Check())
            {
                this.Close();
                this.Owner.Show();
            }
        }
    }
}
