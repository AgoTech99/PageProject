using PageProject.ViewModels;
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
    /// Interaction logic for AggregateView.xaml
    /// </summary>
    public partial class AggregateView : Window
    {
        public AggregateView(AggregateViewModel AVM)
        {
            DataContext = AVM;
            InitializeComponent();
        }
    }
}
