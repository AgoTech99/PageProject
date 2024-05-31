using System.Windows;
using PageProject.Views;
using PageProject.ViewModels;
using PageProject.Models;
using System.Collections.ObjectModel;

namespace PageProject
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, int> properties;

        public Dictionary<string, int> Properties
        {
            get { return properties; }
            set { properties = value; }
        }




        private ConfigurationView configurationView;
        private ConfigurationViewModel configurationViewModel;

        private ConstantsViewModel constantsViewModel;
        private ConstantsView constantsView;


        private ObservableCollection<ScaleModel> scaleModelsList;
        private ObservableCollection<MultiserialModel> multiserialModelsList;
        private MicrowaveModel microwaveModel;




        public MainWindow()
        {
            Properties = new()
            {
                {"MaxMultiserialNumber", 5},
                {"MaxMultiserialPortNumber", 8},
                {"MaxScaleNumber", 16},
                {"MaxResistiveNumber", 9},
                {"MaxMicrowaveNumber", 15}
            };

            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            configurationViewModel = new([], [], new(), Properties);

            configurationView = new ConfigurationView(configurationViewModel)
            {
                Owner = this
            };
            configurationView.Show();
            this.Hide();
        }

        private void Button_Constant_Click(object sender, RoutedEventArgs e)
        {
            constantsViewModel = new(Properties);

            constantsView = new(constantsViewModel)
            {
                Owner = this
            };
            constantsView.ShowDialog();
        }
    }
}