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
        public SondaaMicroonde SondaaMicroonde { get; set; }

        public SondaResistiva SondaResistiva { get; set; }

        private readonly SolidColorBrush whitebrush = new SolidColorBrush(Colors.White);
        private readonly SolidColorBrush redbrush = new SolidColorBrush(Colors.Red);

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

        private ObservableCollection<int> sonde;
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

        private int n_scale = 16;
        public int N_Scale
        {
            get { return n_scale; }
            set { n_scale = value;}
        }

        

        private int n_microwaveprobe = 11;
        public int N_MicrowaveProbe
        {
            get { return n_microwaveprobe; }
            set { n_microwaveprobe = value; }
        }

        private int n_multiserial;
        public int N_Multiserial        {
            get { return n_multiserial; }
            set { n_multiserial = value; }
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
        public void Change_N_Resistive(int n_resistive)
        {
            if (sonde.Count < n_resistive)
            {
                
                for (int i = Sonde.Count+1; i <= n_resistive;i++)
                    sonde.Add(i);
            }
            else
            {
                for (int i = Sonde.Count; i > n_resistive;i--)
                    sonde.RemoveAt(sonde.Count-1);
            }
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
                if (scales.Count() < N_Scale)
                {
                    scales.Add(new Bilancia($"Bilancia{scales.Count() + 1}"));
                    count_scale += 1;
                    check_router_plus(1);
                    OnPropertyChanged(nameof(count_scale));
                }

            }


        }
        private int Value_comboBox;
        private int Value_textBox;
        public void Check_TextBox(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (Convert.ToInt32(textBox.Text) > N_MicrowaveProbe)
                    textBox.Background = redbrush;
                else
                {
                    textBox.Background = whitebrush;
                    int value = Convert.ToInt32(textBox.Text) - Value_textBox;
                    if (value > 0)
                        check_router_plus(value);
                    else
                        check_router_minus(value * -1);
                    Value_textBox = Convert.ToInt32(textBox.Text);
                }
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
            {
                routers.Add(new Router($"Router{routers.Count + 1}"));              
            }

            for (int i = 0; i < Device; i++)
            {
                if (routers.Count < 6 && routers[routers.Count - 1].Active_Port < 9)
                {
                    if (routers[routers.Count - 1].Active_Port == 8)
                    {
                        routers.Add(new Router($"Router{routers.Count + 1}"));
                        routers[routers.Count - 1].Active_Port += 1;
                        routers[routers.Count - 1].Pin.Add(1);
                    }
                    else
                    {
                        routers[routers.Count - 1].Active_Port += 1;
                        routers[routers.Count - 1].Pin.Add(1);
                    }                  
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
                    else
                    {
                        routers[routers.Count - 1].Active_Port -= 1;
                        routers[routers.Count - 1].Pin.RemoveAt(routers[routers.Count - 1].Pin.Count - 1);                        
                    }
                }
            }
                
        }
    }
}
