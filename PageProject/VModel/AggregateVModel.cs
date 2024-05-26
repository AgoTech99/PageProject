using PageProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static PageProject.Model.AggregateEnum;

namespace PageProject.VModel
{
    public class AggregateVModel
    {
        private Identificatore identificatore;
        private AggregateModel aggregateModel;
        
        public AggregateVModel()
        {                                
            Model= new ObservableCollection<AggregateModel>();
            Model.Add(new AggregateModel(Identificatore.Aggregate1));
            Model.Add(new AggregateModel(Identificatore.Aggregate2));
            //System.Diagnostics.Debug.WriteLine(Models[0].Assegnazione);
        }
        private ObservableCollection<AggregateModel> model;

        public ObservableCollection<AggregateModel> Model
        {
            get { return model;}
            set { model = value;}
        }
        public bool check(string lettera, AggregateModel aggregateModel)
        {
            if (lettera== "M")
            {
                //System.Diagnostics.Debug.WriteLine(aggregateModel.Check_M);
                //System.Diagnostics.Debug.WriteLine(aggregateModel.Check_R);
                aggregateModel.Check_M=true;
                if (aggregateModel.Check_R)
                {
                    aggregateModel.Check_R = false;
                    System.Diagnostics.Debug.WriteLine("R");
                    return true;
                }
                return false;
            }
            else
            {
               // System.Diagnostics.Debug.WriteLine(aggregateModel.Check_M);
                //System.Diagnostics.Debug.WriteLine(aggregateModel.Check_R);

                aggregateModel.Check_R = true; 
                if (aggregateModel.Check_M)
                {
                    aggregateModel.Check_M = false;
                    System.Diagnostics.Debug.WriteLine("M");
                    return true;
                }
                return false;
                
            }
        }

    }
}
