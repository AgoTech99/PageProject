

namespace PageProject.ViewModels
{
    public class ConstantsViewModel
    {
        private string maxMultiserialNumber = "5";
        private string maxMultiserialPortNumber = "8";
        private string maxScalesNumber = "16";
        private string maxResistiveNumber = "9";
        private string maxMicrowaveNumber = "15";

        private bool multiserialNumberOk = true;
        private bool multiserialPortNumberOk = true;
        private bool scalesNumberOk = true;
        private bool resistiveNumberOk = true;
        private bool microwaveNumberOk = true;


        public string MaxMultiserialNumber
        {
            get { return maxMultiserialNumber; }
            set 
            { 
                if(value != "")
                {
                    multiserialNumberOk = true;
                }
                else
                {
                    multiserialNumberOk = false;
                }
                maxMultiserialNumber = value; 
            }
        }

        public string MaxMultiserialPortNumber
        {
            get { return maxMultiserialPortNumber; }
            set 
            {
                if (value != "")
                {
                    multiserialPortNumberOk = true;
                }
                else
                {
                    multiserialPortNumberOk = false;
                }
                maxMultiserialPortNumber = value;
            }
        }

        public string MaxScalesNumber
        {
            get { return maxScalesNumber; }
            set 
            {
                if (value != "")
                {
                    scalesNumberOk = true;
                }
                else
                {
                    scalesNumberOk = false;
                }
                maxScalesNumber = value;
            }
        }

        public string MaxResistiveNumber
        {
            get { return maxResistiveNumber; }
            set 
            {
                if (value != "")
                {
                    resistiveNumberOk = true;
                }
                else
                {
                    resistiveNumberOk = false;
                }
                maxResistiveNumber = value;
            }
        }

        public string MaxMicrowaveNumber
        {
            get { return maxMicrowaveNumber; }
            set 
            {
                if (value != "")
                {
                    microwaveNumberOk = true;
                }
                else
                {
                    microwaveNumberOk = false;
                }
                maxMicrowaveNumber = value;
            }
        }


        public bool Check()
        {
            if (multiserialNumberOk && multiserialPortNumberOk && scalesNumberOk && resistiveNumberOk && microwaveNumberOk)
            {  
                System.Diagnostics.Debug.WriteLine("ciao");
            }
            return false;
        }

        public ConstantsViewModel() 
        {
        
        }

    }
}
