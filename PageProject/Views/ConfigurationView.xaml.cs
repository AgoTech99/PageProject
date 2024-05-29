using System.Windows;
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
            this.Owner.Show();
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            _confVM.RemoveScale();
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            _confVM.AddScale();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _confVM.TextBoxChanged();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            _confVM.CheckAll();
        }

    }
}
