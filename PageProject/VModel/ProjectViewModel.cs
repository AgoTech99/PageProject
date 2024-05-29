using Microsoft.VisualBasic;
using PageProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;

namespace PageProject.VModel
{

    public class ProjectViewModel : INotifyPropertyChanged
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

        private int count_scale;
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

        private List<int> sonde;
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
            Routers = new ObservableCollection<Router>();
            Scales = new ObservableCollection<Bilancia>();
            SondaaMicroonde = new SondaaMicroonde();
            SondaResistiva = new SondaResistiva();
            sonde = SondaResistiva.Sonde;

        }


        
        public void Change_scale(string sign)
        {
            if (sign == "-")
            {
                if (scales.Count() > 0)
                {
                    scales.Remove(scales.Last());
                    count_scale = scales.Count();
                    OnPropertyChanged(nameof(count_scale));
                    check_router_minus(1);
                }

            }
            else
            {
                if (scales.Count() < 16)
                {
                    scales.Add(new Bilancia($"Bilancia{scales.Count() + 1}"));
                    count_scale += 1;
                    check_router_plus(1);
                    OnPropertyChanged(nameof(count_scale));
                }

            }


        }
        private int Value_comboBox;
        private int Value_TextBox;
        /*

        private static List<char> list = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        
            bool check = false; 
            foreach (char c in text) 
            {
                if (!list.Contains(c)) 
                    check = true;
            }

            if (check == true)
            {
                textBox.Background = new SolidColorBrush(Colors.Red);
                
                check =false;
            }
            else
            {
                if (Convert.ToInt32(text) > 11)
                    textBox.Background = new SolidColorBrush(Colors.Red);
                else
                {
                    textBox.Background = new SolidColorBrush(Colors.White);
                    OnPropertyChanged(nameof(textBox.Background));
                    int value = Convert.ToInt32(text) - Value_TextBox;
                    if (value > 0)
                        check_router_plus(value);
                    else
                        check_router_minus(value*-1);
                    Value_TextBox = Convert.ToInt32(text);
                }
            }
            */
        public void Check_TextBox(bool check, TextBox textBox)
        {
            if (check)
            {

            }
            else
            {

            }
        }
        public void Check_ComboBox(string text)
        {
            int value = Convert.ToInt32(text) - Value_comboBox;
            if (value > 0)
                check_router_plus(value);
            else
                check_router_minus(value*-1);
            Value_comboBox = Convert.ToInt32(text);
        }
        public void check_router_plus(int Device)
        {
            if (routers.Count == 0)
                routers.Add(new Router($"Router{routers.Count + 1}"));

            for (int i = 0; i < Device; i++)
            {
                if (routers.Count < 6 && routers[routers.Count - 1].Active_Port < 9)
                {
                    if (routers[routers.Count - 1].Active_Port == 8)
                    {
                        routers.Add(new Router($"Router{routers.Count + 1}"));
                        routers[routers.Count - 1].Active_Port += 1;
                    }
                    else routers[routers.Count - 1].Active_Port += 1;
                }

            }
        }
        public void check_router_minus(int Device)
        {
            if (routers.Count != 0)
            {
                for (int i = 0;i<Device;i++)
                {
                    if (routers[routers.Count - 1].Active_Port == 1)
                    {
                        routers.Remove(routers[routers.Count - 1]);
                    }
                    else routers[routers.Count - 1].Active_Port -= 1;
                }
            }
                
        }
    }
}
