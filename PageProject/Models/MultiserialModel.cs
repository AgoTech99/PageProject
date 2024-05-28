
namespace PageProject.Models
{
    public class MultiserialModel
    {
        private int activePort;
        public int ActivePort
        {
            get { return activePort; }
            set { activePort = value; }
        }

        private string portName = "MultiSerial-";
        public string PortName
        {
            get { return portName; }
            set { portName = value; }
        }

        public string ActiveNumberDescription
        {
            get { return $"{ActivePort} Active Ports"; }
        }

        public MultiserialModel(int number, int ports = 0)
        { 
            ActivePort = ports;
            PortName += $"{number}";
        }
    }
}
