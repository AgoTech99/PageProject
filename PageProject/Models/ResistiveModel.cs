
namespace PageProject.Models
{
    public class ResistiveModel : MicrowaveModel
    {
        private int probeType;
        private List<int> numberOptions;
        private List<int> typeOptions;

        public int ProbeType
        {
            get { return probeType; }
            set { probeType = value; }
        }

        public List<int> NumberOptions
        {
            get { return numberOptions; }
            set { numberOptions = value; }
        }

        public List<int> TypeOptions
        {
            get { return typeOptions; }
            set { typeOptions = value; }
        }


        public ResistiveModel() 
        {
            ProbeNumber = 0;
            ProbeType = 0;
            NumberOptions = new List<int>(Enumerable.Range(0,10).ToList());
            TypeOptions = new List<int>(Enumerable.Range(1, 3).ToList());
        }
    }
}
