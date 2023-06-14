using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ColorProject
{
    public class BaseMVVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChangedEventHandler vmpptyChanged = PropertyChanged;
            vmpptyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value)) return false;
            storage = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }
    }
}
