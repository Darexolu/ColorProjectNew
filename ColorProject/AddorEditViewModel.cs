using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using System.Runtime.CompilerServices;


namespace ColorProject
{
    public class AddorEditViewModel : INotifyPropertyChanged
    {
        public ColorInfo _colorinfo;
        public ColorInfo Coloured
        {
            get => _colorinfo; set
            {
                _colorinfo = value;
                NotifyPropertyChanged();
            }
        }
        //public ICommand Delete { get; private set; }
        //        private double r;
        //        public double R { get => r; 
        //            private set { if (value == R) return;
        //                r = value;
        //                NotifyPropertyChanged();
        //            }
        //        }
        //        private double g;
        //        public double G { get => g; set {
        //                if (value == G) return;
        //                g = value;
        //                NotifyPropertyChanged();
        //            }
        //        }
        //        private double b;
        //        public double B { get => b; set {
        //                if (value == B) return;
        //                b = value;
        //                NotifyPropertyChanged();
        //            } 
        //        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //        //public ICommand Save { get => value; set; }
        public AddorEditViewModel()
        {
            Coloured = new ColorInfo();


        }
    }
}
