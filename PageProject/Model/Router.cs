using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageProject.Model
{
    public class Router
    {



        private ObservableCollection<int> pin;
        public ObservableCollection<int> Pin
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }

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
            pin =new ObservableCollection<int> ();  
        }


    }

   


}
