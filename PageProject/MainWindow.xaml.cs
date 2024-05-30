using System.Windows;
using PageProject.Views;
using PageProject.ViewModels;
using PageProject.Models;
using System.Collections.ObjectModel;

namespace PageProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private ConfigurationView configurationView;
        private ConfigurationViewModel configurationViewModel;

        private ConstantsViewModel constantsViewModel;
        private ConstantsView constantsView;

        private ObservableCollection<ScaleModel> scaleModelsList = [];
        private ObservableCollection<MultiserialModel> multiserialModelsList = [];
        private ResistiveModel resistiveModel = new();
        private MicrowaveModel microwaveModel = new();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            configurationViewModel = new(multiserialModelsList, scaleModelsList, resistiveModel, microwaveModel);

            configurationView = new ConfigurationView(configurationViewModel)
            {
                Owner = this
            };
            configurationView.Show();
            this.Hide();
        }

        private void Button_Constant_Click(object sender, RoutedEventArgs e)
        {
            constantsViewModel = new();

            constantsView = new(constantsViewModel)
            {
                Owner = this
            };
            constantsView.ShowDialog();
        }
    }
}