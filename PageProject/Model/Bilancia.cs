using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageProject.Model
{
    public class Bilancia
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Bilancia(string Nome) 
        { 
            name = Nome;
        }



    }
}
