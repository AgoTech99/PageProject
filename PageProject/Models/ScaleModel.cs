using System.Windows.Media;

namespace PageProject.Models
{
    public class ScaleModel
    {
        private SolidColorBrush color;
        private string name = "Scale-";
        public string Name
        {
            get {  return name; }
            set { name = value; } 
        }

        public SolidColorBrush Color
        {
            get { return color; }
            set { color = value; }
        }

        public ScaleModel(int number, SolidColorBrush clr) 
        {
            Name += $"{number}";
            Color = clr;
        }
    }
}
