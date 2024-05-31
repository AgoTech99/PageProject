namespace PageProject.Models
{
    public class ScaleModel
    {
        private string name = "Scale-";
        public string Name
        {
            get {  return name; }
            set { name = value; } 
        }

        public ScaleModel(int number) 
        {
            Name += $"{number}";
        }
    }
}
