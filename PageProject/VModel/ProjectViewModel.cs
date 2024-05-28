using Microsoft.VisualBasic;
using PageProject.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace PageProject.VModel
{

    public class ProjectViewModel:INotifyPropertyChanged
    {
        public SondaaMicroonde SondaaMicroonde;

        public SondaResistiva SondaResistiva;

        private ObservableCollection<Router> routers;
        public ObservableCollection<Router> Routers
        {
            get
            {
                return routers;
            }
            set
            {
                routers = value;
            }
        }

        private int count_scale ;
        public int Count_Scale
        {
            get
            {
                return count_scale; 
            }
            set 
            {
                count_scale = value;
                
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private ObservableCollection<Bilancia> scales;
        public ObservableCollection<Bilancia> Scales 
        { 
            get 
            { 
                return scales; 
            }
            set
            {
                scales = value;
                
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ProjectViewModel()
        {
            Routers= new ObservableCollection<Router>();
            Scales= new ObservableCollection<Bilancia>();
            SondaaMicroonde= new SondaaMicroonde();
            SondaResistiva= new SondaResistiva();
        }
        public void Change_scale(string sign)
        {
            if (sign == "-")
            {
                if (scales.Count() > 0)
                {
                    scales.Remove(scales.Last());
                    count_scale = scales.Count();
                }

            }
            else
            {
                if (scales.Count() < 16) 
                { 
                scales.Add(new Bilancia($"Bilancia{scales.Count() + 1}"));
                count_scale += 1;
                }
            }
            OnPropertyChanged(nameof(count_scale));
        }



        private string right_string;
        public string Right_string 
        {
        get 
            {
                return right_string; 
            } 
            set 
            {  
                right_string = value; 
            }
        }




        private static List<char> list = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public void Check_TextBox(string text)
        {
            char Char = text[text.Length - 1];
            if (!list.Contains(Char))
                 right_string=text.Substring(0, text.Length - 1);
            else right_string = text;
            OnPropertyChanged(nameof(Right_string));

        }
        
    }
}
