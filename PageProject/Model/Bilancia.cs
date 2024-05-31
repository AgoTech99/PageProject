using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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
        public Bilancia(string Nome,SolidColorBrush color) 
        { 
            name = Nome;
            rectangleFill = color;
        }

        private SolidColorBrush rectangleFill;
        public SolidColorBrush RectangleFill
        {
            get
            {
                return rectangleFill;
            }
            set
            {
                rectangleFill = value;                
            }
        }



    }
}
