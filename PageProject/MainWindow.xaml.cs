using System.Windows;
using PageProject.Views;
using PageProject.ViewModels;
using PageProject.Models;
using System.Collections.ObjectModel;

namespace PageProject
{
    public partial class MainWindow : Window
    {
        private Attributes Attributes { get; set; }

        public MainWindow()
        {
            Attributes = new Attributes();
            resistiveModel = new ResistiveModel(Attributes.Properties["MaxResistiveProbeNumber"]);
            InitializeComponent();
        }

        private ConfigurationView configurationView;
        private ConfigurationViewModel configurationViewModel;

        private ObservableCollection<ScaleModel> scaleModelsList = [];
        private ObservableCollection<MultiserialModel> multiserialModelsList = [];
        private ResistiveModel resistiveModel;
        private MicrowaveModel microwaveModel = new();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            configurationViewModel = new(multiserialModelsList, scaleModelsList, resistiveModel, microwaveModel, Attributes.Properties["MaxScaleNumber"], Attributes.Properties["MaxMicrowaveProbeNumber"], Attributes.Properties["MaxMultiserialPortNumber"]);

            configurationView = new ConfigurationView(configurationViewModel)
            {
                Owner = this
            };
            configurationView.Show();
            this.Hide();
        }
    }
}