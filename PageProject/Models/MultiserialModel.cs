
using System.Collections.ObjectModel;

namespace PageProject.Models
{
    public class MultiserialModel
    {
        private int activePort;
        private string portName = "MultiSerial-";

        private ObservableCollection<int> portsList;

        public int ActivePort
        {
            get { return activePort; }
            set { activePort = value; }
        }

        public string PortName
        {
            get { return portName; }
            set { portName = value; }
        }

        public string ActiveNumberDescription
        {
            get { return $"{ActivePort} Active Ports"; }
        }

        public ObservableCollection<int> PortsList
        {
            get { return portsList; }
            set { portsList = value; }
        }



        public MultiserialModel(int number, int ports = 0)
        { 
            ActivePort = ports;
            PortName += $"{number}";
        }
    }
}
