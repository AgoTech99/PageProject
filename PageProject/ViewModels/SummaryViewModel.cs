using PageProject.Models;

namespace PageProject.ViewModels
{
    public class SummaryViewModel
    {
        private SummaryModel summaryModel;

        public SummaryModel SummaryModel
        {
            get { return summaryModel; }
            set { summaryModel = value; }
        }

        public SummaryViewModel(SummaryModel SM)
        {
            SummaryModel = SM;   
        }

    }
}
