using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using PageProject.Models;
using PageProject.ViewModels;

namespace PageProject.Views
{
    public partial class ConfigurationView : Window
    {
        private readonly ConfigurationViewModel _confVM;

        private Dictionary<string, SolidColorBrush> colors = new Dictionary<string, SolidColorBrush>()
        {
            {"Aggregates",Brushes.Yellow },
            {"Cements",Brushes.Green },
            {"Water",Brushes.LightBlue },
            {"Additives",Brushes.Purple },
            {"Fibres",Brushes.LightSeaGreen },
            {"Ice",Brushes.White }
        };

        public ConfigurationView(ConfigurationViewModel CVM)
        {
            _confVM = CVM;
            DataContext = CVM;
            this.WindowState = WindowState.Maximized;
            this.Closed += WindowClosed;
            InitializeComponent();
            MultiserialScrollViewer.PreviewMouseWheel += ScrollViewer_PreviewMouseWheel;
        }

        public void WindowClosed(object? sender, EventArgs e) 
        {
            this.Owner.Show();
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            _confVM.RemoveScale();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _confVM.TextBoxChanged();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (_confVM.CheckAll())
            {
                SummaryModel SM = new(_confVM.MultiserialModelsList, _confVM.ScaleModelsList, _confVM.ResistiveModel.ProbeNumber, _confVM.ResistiveModel.ProbeType, _confVM.MicrowaveModel.ProbeNumber);

                SummaryViewModel SVM = new(SM);

                SummaryView SV = new(SVM);
                SV.Owner = this;
                SV.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                SV.ShowDialog();
            }
        }

        private void TextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9) && !(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) && !(e.Key == Key.Delete || e.Key == Key.Back || e.Key == Key.Left || e.Key == Key.Right))
            {
                e.Handled = true;
            }
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta < 0)
            {
                MultiserialScrollViewer.LineRight();
            }
            else if (e.Delta > 0)
            {
                MultiserialScrollViewer.LineLeft();
            }
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var contextMenu = this.Resources["MyContextMenu"] as ContextMenu;
                if (contextMenu != null)
                {
                    contextMenu.PlacementTarget = button;
                    contextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
                    contextMenu.IsOpen = true;
                }
            }
        }


        private void ItemClicked(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                _confVM.AddScale(colors[menuItem.Header.ToString()]);
            }
        }


    }
}
