using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PageProject.Model.SResistivaenum;

namespace PageProject.Model
{
     
    public class SondaResistiva
    {
        public List<Tipo> ComunicationTypesCollection { get; set; }  = EnumHelper.EnumToList<Tipo>().ToList();

        private List<int>sonde = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public List<int> Sonde 
        {
            get 
            {  
                return sonde; 
            } 
            set 
            { 
                sonde = value; 
            }
        }
    }
}
