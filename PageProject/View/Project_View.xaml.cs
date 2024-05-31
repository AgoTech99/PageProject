using PageProject.VModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using PageProject.Converter;
using System.Collections.Generic;

namespace PageProject.View
{
    /// <summary>
    /// Interaction logic for Project_View.xaml
    /// </summary>
    public partial class Project_View : Window
    {
        public ProjectViewModel VModel;
        private Dictionary<string,SolidColorBrush> colors;
        public Project_View(ProjectViewModel viewModel)
        {
            colors = new Dictionary<string, SolidColorBrush>() 
            {
                {"Aggregati",Brushes.Yellow},
                {"Cementi",Brushes.Green},
                {"Acqua",Brushes.SkyBlue},
                {"Additivi",Brushes.Violet},
                {"Fibre",Brushes.LightSeaGreen},
                {"Ghiaccio",Brushes.White},
            };
            VModel= viewModel;
            DataContext = viewModel;
            InitializeComponent();
        }
       
       
        private void Button_plus(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                VModel.Change_scale("+", colors[ menuItem.Header.ToString()]);
            }
        }

        private void Button_minus(object sender, RoutedEventArgs e)
        {
            VModel.Change_scale("-",Brushes.Transparent);
           
        }


        private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {            
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta < 0)
            {
                Scroll.LineRight();
            }
            else if (e.Delta > 0) 
            {
                Scroll.LineLeft();
            }
            e.Handled = true;
        }
    }
}
