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

namespace PageProject.Views
{
    /// <summary>
    /// Interaction logic for AggregateViews.xaml
    /// </summary>
    public partial class AggregateViews : Window
    {
        public AggregateViews(AggregateVModel aggregateVModel)
        {
            DataContext = aggregateVModel;
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged_M(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if (comboBox.DataContext is AggregateVModel aggregateVModel)
                {
                    if (aggregateVModel.check("M"))
                    {
                        comboBox.SelectedValue = 0;
                    }
                }   
            }
        }

        private void ComboBox_SelectionChanged_R(object sender, SelectionChangedEventArgs e)
        {

            if (sender is ComboBox comboBox)
            {
               
                if (comboBox.DataContext is AggregateVModel aggregateVModel)
                {
                    System.Diagnostics.Debug.WriteLine(aggregateVModel.check("M"));
                    if (aggregateVModel.check("R"))
                    {
                        comboBox.SelectedValue = 0;
                    }
                }
            }
        }
    }
}
