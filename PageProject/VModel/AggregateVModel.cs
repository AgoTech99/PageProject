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
        private bool check_M = false;
        private bool check_R = false;
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
        public bool check(string lettera)
        {
            if (lettera== "M")
            {
                if (check_R)
                {
                    check_M = false;
                    return true;
                }
                return false;
            }
            else
            {
                check_R = true; 
                if (check_M)
                {
                    check_M = false;
                    return true;
                }
                return false;
                
            }
        }

    }
}
