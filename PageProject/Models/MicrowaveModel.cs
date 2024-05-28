
namespace PageProject.Models
{
    public class MicrowaveModel
    {
        private int probeNumber;

        public int ProbeNumber
        {
            get { return probeNumber; } 
            set { probeNumber = value; } 
        }

        public MicrowaveModel() 
        {
            ProbeNumber = 0;
        }
    }
}
