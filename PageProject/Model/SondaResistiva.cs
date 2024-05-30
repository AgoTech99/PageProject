using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using static PageProject.Model.SResistivaenum;

namespace PageProject.Model
{

    public class SondaResistiva
    {
        public List<Tipo> ComunicationTypesCollection { get; set; }  = EnumHelper.EnumToList<Tipo>().ToList();

        private ObservableCollection<int> sonde = new ObservableCollection<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public ObservableCollection<int> Sonde 
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
