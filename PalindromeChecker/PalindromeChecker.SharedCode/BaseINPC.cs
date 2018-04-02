using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PalindromeChecker.SharedCode
{
    public class BaseINPC : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
