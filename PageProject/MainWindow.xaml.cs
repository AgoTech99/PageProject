using PageProject.View;
using PageProject.VModel;
using System.Windows;
namespace PageProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProjectViewModel viewModel ;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel ??= new ProjectViewModel();
            Project_View view = new Project_View(viewModel);
            view.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewModel ??= new ProjectViewModel();
            ProjectCostantiView view = new ProjectCostantiView(viewModel);
            view.Show();
        }
    }
}