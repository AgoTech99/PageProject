using System.Collections.ObjectModel;

namespace PageProject.Models
{
    public class SummaryModel
    {
        private ObservableCollection<MultiserialModel> multiserialsList;
        private ObservableCollection<ScaleModel> scalesList;
        private int resistiveProbesNumber;
        private int resistiveProbesType;
        private int microwaveProbesNumber;


        public ObservableCollection<MultiserialModel> MultiserialsList
        {
            get { return multiserialsList; }
            set { multiserialsList = value; }
        }

        public ObservableCollection<ScaleModel> ScalesList
        {
            get { return scalesList; }
            set { scalesList = value; }
        }

        public int ResistiveProbesNumber
        {
            get { return resistiveProbesNumber; }
            set { resistiveProbesNumber = value; }
        }

        public int ResistiveProbesType
        {
            get { return resistiveProbesType; }
            set { resistiveProbesType = value; }
        }

        public int MicrowaveProbesNumber
        {
            get { return microwaveProbesNumber; }
            set { microwaveProbesNumber = value; }
        }


        public string MultiserialDescription
        {
            get
            {
                int mCount = MultiserialsList.Count;
                int count = 0;
                foreach(MultiserialModel m in MultiserialsList)
                {
                    count += m.ActivePort;
                }
                if (mCount == 0)
                {
                    return "0 multiserials";
                }
                return $"{mCount} multiserials with {count} total active ports";
            }
        }

        public string ScaleDescription
        {
            get
            {
                return $"{ScalesList.Count} scales";
            }
        }

        public string ResistiveDescription
        {
            get
            {
                return $"{ResistiveProbesNumber} type {ResistiveProbesType} probes";
            }
        }

        public string MicrowaveDescription
        {
            get
            {
                return $"{MicrowaveProbesNumber} microwave probes";
            }
        }

        public SummaryModel(ObservableCollection<MultiserialModel> MList, ObservableCollection<ScaleModel> SList, int Rn, int Rt, int Mn)
        {
            this.MultiserialsList = MList;
            this.ScalesList = SList;
            this.ResistiveProbesNumber = Rn;
            this.ResistiveProbesType = Rt;
            this.MicrowaveProbesNumber = Mn;
        }
    }
}
