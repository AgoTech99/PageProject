using System.Windows;
using PageProject.Models;
using PageProject.ViewModels;

namespace PageProject.Views
{
    public partial class ConfigurationView : Window
    {
        private readonly ConfigurationViewModel _confVM;

        public ConfigurationView(ConfigurationViewModel CVM)
        {
            _confVM = CVM;
            DataContext = CVM;
            this.WindowState = WindowState.Maximized;
            this.Closed += WindowClosed;
            InitializeComponent();
        }

        public void WindowClosed(object? sender, EventArgs e) 
        {
            if (this.Owner.IsActive)
            {
                this.Owner.Show();
            }
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            _confVM.AddScale();
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
    }
}
