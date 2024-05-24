using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PageProject.Model.AggregateEnum;

namespace PageProject.Model
{

    
    public class AggregateModel
    {
        
        private List<int> microwave ;
        private List<int> resistance;


        public Identificatore Assegnazione { get; set; }
        public List<int> Microwave => microwave;
        public List<int> Resistance => resistance;

        public AggregateModel(Identificatore identificatore)
        {
            Assegnazione = identificatore;
            microwave= new List<int>();
            resistance= new List<int>();
            for (int i = 0; i < 10; i++)
            {
                microwave.Add(i);
                resistance.Add(i);
            }
        }
        
    }
}
