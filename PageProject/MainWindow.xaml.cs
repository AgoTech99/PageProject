using PageProject.Models;
using PageProject.View;
using PageProject.VModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PageProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();

            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userview userview = new Userview(new UserViewModel(new UserData()));
            userview.Show();
        }
 
    }
}