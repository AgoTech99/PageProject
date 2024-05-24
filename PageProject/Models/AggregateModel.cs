

using System.Collections.ObjectModel;

namespace PageProject.Models
{
    public class AggregateModel
    {

        

        private ObservableCollection<BaseModel> _modelsList;

        public ObservableCollection<BaseModel> ModelsList { get { return _modelsList; } }

        public AggregateModel()
        {
            _modelsList = [new BaseModel((int)EnumModel.AggregateId.Aggregate1), new BaseModel((int)EnumModel.AggregateId.Aggregate2)];
        }

    }
}
