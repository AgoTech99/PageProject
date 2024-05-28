using PageProject.VModel;
using System.Windows;
using System.Windows.Controls;

namespace PageProject.View
{
    /// <summary>
    /// Interaction logic for Project_View.xaml
    /// </summary>
    public partial class Project_View : Window
    {
        public ProjectViewModel VModel;
        public Project_View(ProjectViewModel viewModel)
        {
            VModel= viewModel;
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Button_plus(object sender, RoutedEventArgs e)
        {
            VModel.Change_scale("+");
        }

        private void Button_minus(object sender, RoutedEventArgs e)
        {
            VModel.Change_scale("-");
        }


        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (sender is TextBox textBox)
                VModel.Check_TextBox(textBox.Text);
        }

        private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == System.Windows.Input.Key.Enter )
            {
                e.Handled = true;
            }
            if (sender is TextBox textBox)
                VModel.Check_TextBox(textBox.Text);
        }
    }
}
