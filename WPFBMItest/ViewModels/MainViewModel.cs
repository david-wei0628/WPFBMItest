using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace WPFBMItest.ViewModels
{
    class MainViewModel : NotifyPropertyBase
    {
        public double _weight;
        public double Weight
        {
            get { return _weight;}
            set { SetProperty(ref _weight, value); }
        }

        public double _height;
        public double Height
        {
            get { return _height; }
            set { SetProperty(ref _height, value);}
        }

        public double _result;
        public double Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        public ICommand _myCommand;
        public ICommand MyCommand
        {
            get 
            {
                if (_myCommand == null)
                {
                    _myCommand = new RelayCommand((x) =>
                   {
                       if(Height >= 100) { Height = Height / 100; }
                       Result = Weight / Math.Pow(Height, 2);
                   });
                }
                return _myCommand;
            }
        }
    }
}
