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

        
        private string microwave;
        public string Microwave
        {
            get
            {
               return microwave;
            }
            set
            {
                microwave = value;  
            }
        }
        

        private string resistance;
        

        public string Resistance
        {
            get
            {
                return resistance;
            }
            set
            {
                resistance = value;
            }
        }



    }
}
