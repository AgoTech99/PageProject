using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static PageProject.Model.AggregateEnum;

namespace PageProject.Model
{

    
    public class AggregateModel
    {
        
        private List<int> microwave ;
        private List<int> resistance;

        private bool check_M = false;
        private bool check_R = false;

        public bool Check_M { get; set; }
        public bool Check_R { get; set; }



        public string R { get; set; }
        public string M { get; set; }
        public Identificatore Assegnazione { get; set; }
        public List<int> Microwave => microwave;
        public List<int> Resistance => resistance;

        public AggregateModel(Identificatore identificatore)
        {
            Assegnazione =identificatore;
            if (Assegnazione.ToString().Contains("1"))
            {
                R = "R1";
                M = "M1";
            }
            else
            {
                R = "R2";
                M = "M2";

            }
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
