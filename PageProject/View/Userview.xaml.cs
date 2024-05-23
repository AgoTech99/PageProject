using PageProject.Models;
using PageProject.VModels;
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
    /// Interaction logic for Userview.xaml
    /// </summary>
    public partial class Userview : Window
    {
        public Userview(UserViewModel userViewModel)
        {
            DataContext = userViewModel;
            InitializeComponent();
            
        }


        

        private void TextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox text)
            {
                if (text.Text.Length == 0)
                {
                    text.Background=  new SolidColorBrush(Colors.Red);

                }
                else
                {
                    text.Background= new SolidColorBrush(Colors.White);
                }

            }
        }




    }
}
