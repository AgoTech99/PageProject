using PageProject.VModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            //System.Diagnostics.Debug.WriteLine(e.Key);
            if (!(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Back || e.Key == Key.Tab))
                e.Handled = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                VModel.Check_ComboBox(Convert.ToString( comboBox.SelectedValue));
                
            }
        }

        private void TextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Back || e.Key == Key.Tab)
                if (sender is TextBox textBox)
                    VModel.Check_TextBox(textBox);
        }
    }
}
