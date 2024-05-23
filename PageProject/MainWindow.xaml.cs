using PageProject.Models;
using PageProject.ViewModels;
using PageProject.Views;
using System.Windows;


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
            UserModel UModel = new UserModel();

            UserViewModel UViewModel = new UserViewModel(UModel);

            UserView UserV = new UserView(UViewModel);
            UserV.Owner = this;
            UserV.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            UserV.Show();
            UserV.Owner = null;
            this.Close();

        }
    }
}