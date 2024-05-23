using PageProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageProject.VModel
{
    public class AggregateVModel
    {

        private AggregateModel aggrergateModel { get; set; }

        public string Microwave
        {
            get
            {
                return aggrergateModel.Microwave;

            }
            set
            {
            
                aggrergateModel.Microwave = value;

            }
        }





    }
}
