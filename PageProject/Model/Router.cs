using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageProject.Model
{
    public class Router
    {

        public List<int> Port= new List<int> ();



        private int active_port;
        public int Active_Port
        {
            get
            {
                return active_port;
            }
            set
            {
                active_port = value;
            }
        }
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
        public Router(string nome)
        {
            name=nome;
        }


    }

   


}
