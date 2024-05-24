

namespace PageProject.Models
{
    public class AggregateModel
    {

        

        private List<BaseModel> _modelsList;

        public List<BaseModel> ModelsList { get { return _modelsList; } }

        public AggregateModel()
        {
            _modelsList = [new BaseModel((int)EnumModel.AggregateId.Aggregate1), new BaseModel((int)EnumModel.AggregateId.Aggregate2)];
        }

    }
}
