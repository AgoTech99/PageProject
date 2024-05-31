using System.Collections.ObjectModel;

namespace PageProject.Models
{
    public class MultiserialModel
    {
        private int activePort;
        private string portName = "MultiSerial-";
        private ObservableCollection<int> portsList;
        private static int width;

        public int ActivePort
        {
            get { return activePort; }
            set 
            { 
                activePort = value; 
                PortsList = new(Enumerable.Range(1,value));
            }
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

        public static int Width { get => width; set => width = value; }

        public MultiserialModel(int number, int ports = 0)
        { 
            ActivePort = ports;
            PortName += $"{number}";
        }
    }
}
