

namespace PageProject
{
    public class Attributes
    {
        private int maxMultiserialPortNumber = 20;
        private int maxResistiveProbeNumber = 9;
        private int maxMicrowaveProbeNumber = 15;
        private int maxScaleNumber = 20;
        private Dictionary<string, int> properties;

        public int MaxMultiserialPortNumber 
        {
            get { return maxMultiserialPortNumber; }
            set
            {
                maxMultiserialPortNumber = value;
            }
        }

        public int MaxResistiveProbeNumber
        {
            get { return maxResistiveProbeNumber; }
            set
            {
                maxResistiveProbeNumber = value;
            }
        }

        public int MaxMicrowaveProbeNumber
        {
            get { return maxMicrowaveProbeNumber; }
            set
            {
                maxMicrowaveProbeNumber = value;
            }
        }

        public int MaxScaleNumber
        {
            get { return maxScaleNumber; }
            set
            {
                maxScaleNumber = value;
            }
        }

        public Dictionary<string, int> Properties
        {
            get => properties;
            set => properties = value;
        }


        public Attributes()
        {
            Properties = new()
            {
                {"MaxMultiserialPortNumber",MaxMultiserialPortNumber },
                {"MaxResistiveProbeNumber",MaxResistiveProbeNumber },
                {"MaxMicrowaveProbeNumber",MaxMicrowaveProbeNumber },
                {"MaxScaleNumber",MaxScaleNumber }
            };

        }
    }
}
