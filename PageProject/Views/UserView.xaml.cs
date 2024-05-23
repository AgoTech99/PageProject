using PageProject.ViewModels;
using System.Windows;
using System.Windows.Media;

namespace PageProject.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        public UserView(UserViewModel UVM)
        {
            DataContext = UVM;

            InitializeComponent();

        }


        private void ProfileBox_Event(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (ProfileBox.Text.Length == 0)
            {
                
                ProfileBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF58C8C"));
                ProfileBox.BorderThickness = new Thickness(2);
            }
            else
            {
                
                ProfileBox.Background = Brushes.LightGray;
                ProfileBox.BorderThickness = new Thickness(1);
            }
        }

    }
}
