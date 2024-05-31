namespace PageProject.ViewModels
{
    public class ConstantsViewModel
    {
        private Dictionary<string, int> properties;
        private string maxMultiserialNumber;
        private string maxMultiserialPortNumber;
        private string maxScalesNumber;
        private string maxResistiveNumber;
        private string maxMicrowaveNumber;


        public Dictionary<string, int> Properties
        { 
            get { return properties; }
            set { properties = value; }
        }

        public string MaxMultiserialNumber
        {
            get { return maxMultiserialNumber; }
            set 
            { 
                if(value != "")
                {
                    maxMultiserialNumber = value;
                }
                else
                {
                    maxMultiserialNumber = "0";
                }                
            }
        }

        public string MaxMultiserialPortNumber
        {
            get { return maxMultiserialPortNumber; }
            set 
            {
                if (value != "")
                {
                    maxMultiserialPortNumber = value;
                }
                else
                {
                    maxMultiserialPortNumber = "0";
                }
            }
        }

        public string MaxScalesNumber
        {
            get { return maxScalesNumber; }
            set 
            {
                if (value != "")
                {
                    maxScalesNumber = value;
                }
                else
                {
                    maxScalesNumber = "0";
                }
            }
        }

        public string MaxResistiveNumber
        {
            get { return maxResistiveNumber; }
            set 
            {
                if (value != "")
                {
                    maxResistiveNumber = value;
                }
                else
                {
                    maxResistiveNumber = "0";
                }
            }
        }

        public string MaxMicrowaveNumber
        {
            get { return maxMicrowaveNumber; }
            set 
            {
                if (value != "")
                {
                    maxMicrowaveNumber = value;
                }
                else
                {
                    maxMicrowaveNumber = "0";
                }
            }
        }

        public bool Check()
        {
            int MN = int.Parse(MaxMultiserialNumber);
            int MPN = int.Parse(MaxMultiserialPortNumber);
            int SN = int.Parse(MaxScalesNumber);
            int RN = int.Parse(MaxResistiveNumber);
            int MWN = int.Parse(MaxMicrowaveNumber);
            if (MN * MPN >= SN + RN + MWN)
            {
                Properties["MaxMultiserialNumber"] = MN;
                Properties["MaxMultiserialPortNumber"] = MPN;
                Properties["MaxScaleNumber"] = SN;
                Properties["MaxResistiveNumber"] = RN;
                Properties["MaxMicrowaveNumber"] = MWN;
                return true;
            }
            return false;
        }

        public ConstantsViewModel(Dictionary<string, int> Properties) 
        {
            this.Properties = Properties;
            MaxMultiserialNumber = Properties["MaxMultiserialNumber"].ToString();
            MaxMultiserialPortNumber = Properties["MaxMultiserialPortNumber"].ToString();
            MaxScalesNumber = Properties["MaxScaleNumber"].ToString();
            MaxResistiveNumber = Properties["MaxResistiveNumber"].ToString();
            MaxMicrowaveNumber = Properties["MaxMicrowaveNumber"].ToString();
        }
    }
}
