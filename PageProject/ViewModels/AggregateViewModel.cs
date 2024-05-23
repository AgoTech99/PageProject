using PageProject.Models;

namespace PageProject.ViewModels
{
    public class AggregateViewModel
    {
        private AggregateModel _aggregateModel { get; set; }

        public AggregateViewModel(AggregateModel AM)
        {
            _aggregateModel = AM;
        }


    }
}
