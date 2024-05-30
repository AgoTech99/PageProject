using static PageProject.Models.EnumResistive;

namespace PageProject.Models
{
    public class ResistiveModel : MicrowaveModel
    {
        private int probeType;
        private List<int> numberOptions;
        private int Max { get; set; }

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

        public List<ResistiveEnum> TypeOption { get; set; } = EnumHelper.EnumToList<ResistiveEnum>().ToList();

        public ResistiveModel(int max = 9) 
        {
            Max = max;
            ProbeNumber = 0;
            ProbeType = 0;
            NumberOptions = new List<int>(Enumerable.Range(0, Max+1).ToList());
        }
    }
}
