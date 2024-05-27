using PageProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static PageProject.Model.AggregateEnum;

namespace PageProject.VModel
{

    
    public class AggregateVModel 
    {
        private Identificatore identificatore;
        
        public AggregateVModel()
        {                                
            Model= new ObservableCollection<AggregateModel>();
            Model.Add(new AggregateModel(Identificatore.Aggregate1));
            Model.Add(new AggregateModel(Identificatore.Aggregate2));
            //System.Diagnostics.Debug.WriteLine(Models[0].Assegnazione);
        }
        private ObservableCollection<AggregateModel> model;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<AggregateModel> Model
        {
            get { return model;}
            set { model = value;}
        }


    


        public void check(AggregateModel aggregateModel)
        {
            
       
           if (Model[0].Value_M != 0 && Model[1].Value_R != 0)
            {                
                Model[1].Image_R=Visibility.Visible;                
            }
           else if (Model[0].Value_R!=0 && Model[1].Value_M!=0)
            {
                Model[1].Image_M = Visibility.Visible;
            }
           if(Model[0].Value_M == 0 || Model[1].Value_R == 0)
            {
                Model[1].Image_R = Visibility.Hidden;
            }
            if (Model[0].Value_R == 0 || Model[1].Value_M == 0)
            {
                Model[1].Image_M = Visibility.Hidden;
            }
        }

    }
}
