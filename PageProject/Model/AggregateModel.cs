using PageProject.VModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static PageProject.Model.AggregateEnum;

namespace PageProject.Model
{


    public class AggregateModel : INotifyPropertyChanged
    {

        private List<int> microwave;
        private List<int> resistance;



        private int value_R;
        private int value_M;

        public event PropertyChangedEventHandler? PropertyChanged;



        public int Value_R
        {
            get
            {
                return value_R;
            }
            set
            {
                value_R = value;
                value_M = 0;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value_R)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value_M)));
            }
        }
        public int Value_M
        {
            get
            {
                return value_M;
            }
            set
            {
                value_M = value;
                value_R = 0;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value_M)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value_R)));
            }
        }

        private Visibility image_M = Visibility.Hidden;
        private Visibility image_R = Visibility.Hidden;

        public Visibility Image_M
        {
            get
            {
                return image_M;
            }
            set
            {
                image_M = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(image_M)));
            }
        }

        public Visibility Image_R
        {
            get
            {
                return image_R;
            }
            set
            {
                image_R = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(image_R)));
            }
        }






        public string R { get; set; }
        public string M { get; set; }
        public Identificatore Assegnazione { get; set; }
        public List<int> Microwave => microwave;
        public List<int> Resistance => resistance;

        public AggregateModel(Identificatore identificatore)
        {
            Assegnazione = identificatore;
            if (Assegnazione.ToString().Contains("1"))
            {
                R = "R1";
                M = "M1";
            }
            else
            {
                R = "R2";
                M = "M2";

            }
            microwave = new List<int>();
            resistance = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                microwave.Add(i);
                resistance.Add(i);
            }
        }







    }
        
    }

