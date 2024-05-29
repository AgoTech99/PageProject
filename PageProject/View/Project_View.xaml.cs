using PageProject.VModel;
using System;
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


        private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key >= System.Windows.Input.Key.NumPad0 && e.Key <= System.Windows.Input.Key.NumPad9 && e.Key >= System.Windows.Input.Key.D0 && e.Key <= System.Windows.Input.Key.D9)
            {
                e.Handled = true;
                if (sender is TextBox textBox)
                    VModel.Check_TextBox(true, textBox);
            }
            else 
            {
                if (sender is TextBox textBox)
                    VModel.Check_TextBox(false, textBox);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                VModel.Check_ComboBox(Convert.ToString( comboBox.SelectedValue));
                
            }
        }
    }
}
