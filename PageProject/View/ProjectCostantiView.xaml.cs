using PageProject.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PageProject.View
{
    /// <summary>
    /// Interaction logic for ProjectCostantiView.xaml
    /// </summary>
    public partial class ProjectCostantiView : Window
    {
        public ProjectViewModel VModel;
        public ProjectCostantiView(ProjectViewModel viewModel)
        {
            VModel = viewModel;
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Scale_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Back || e.Key == Key.Enter))
                e.Handled = true;
            else
            {
                if (e.Key.Equals(Key.Enter))
                {
                    if (sender is TextBox textBox)
                        VModel.N_Scale = Convert.ToInt32(textBox.Text);
                }
            }
        }
        private void Resistive_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Back || e.Key == Key.Enter))
                e.Handled = true;
            else
            {
                if (e.Key.Equals(Key.Enter))
                {
                    if (sender is TextBox textBox)
                        VModel.Change_N_Resistive(Convert.ToInt32(textBox.Text));
                }
            }
        }
        private void Microwave_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Back || e.Key == Key.Enter))
                e.Handled = true;
            else
            {
                if (e.Key.Equals(Key.Enter))
                {
                    if (sender is TextBox textBox)
                        VModel.N_MicrowaveProbe = Convert.ToInt32(textBox.Text);
                }
            }
        }
        private void Multiserial_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Back || e.Key == Key.Enter))
                e.Handled = true;
            else
            {
                if (e.Key.Equals(Key.Enter))
                {
                    if (sender is TextBox textBox)
                        VModel.N_Multiserial = Convert.ToInt32(textBox.Text);
                }
            }
        }
        private void Pin_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Back || e.Key == Key.Enter))
                e.Handled = true;
            else
            {
                if (e.Key.Equals(Key.Enter))
                {
                    if (sender is TextBox textBox) ;

                        
                }
            }
        }
    }
}
