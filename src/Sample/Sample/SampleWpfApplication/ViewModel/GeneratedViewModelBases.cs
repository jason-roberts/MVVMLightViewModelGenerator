

using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;


using SampleWpfApplication.Model;



namespace SampleWpfApplication.ViewModel
{
    public abstract class MainViewModelBase :  ViewModelBase
    {
                public const string WhoPropertyName = "Who";
                protected  Person _who;

                public  Person Who
                {
                    get
                    {
                        return _who;
                    }
                    set
                    {
                        if (_who == value)
                        {
                            return;
                        }
                        Set(ref _who, value);
                    }
                }
        protected void InitCommands()
        {          
            _loadCommand = new RelayCommand(ExecuteLoad, CanExecuteLoad);
        }

        private RelayCommand _loadCommand;
        public virtual RelayCommand LoadCommand
        {
            get
            {
                return _loadCommand;
            }
        }

        protected virtual void ExecuteLoad() {}
        protected virtual bool CanExecuteLoad() { return true;}
    }

    public abstract class AnotherViewModelBase :  ViewModelBase
    {
                public const string SomePropertyPropertyName = "SomeProperty";
                protected  int _someproperty;

                public  int SomeProperty
                {
                    get
                    {
                        return _someproperty;
                    }
                    set
                    {
                        if (_someproperty == value)
                        {
                            return;
                        }
                        Set(ref _someproperty, value);
                    }
                }
        protected void InitCommands()
        {          
            _aCommand = new RelayCommand(ExecuteA, CanExecuteA);
            _bCommand = new RelayCommand(ExecuteB, CanExecuteB);
        }

        private RelayCommand _aCommand;
        public virtual RelayCommand ACommand
        {
            get
            {
                return _aCommand;
            }
        }

        protected virtual void ExecuteA() {}
        protected virtual bool CanExecuteA() { return true;}

        private RelayCommand _bCommand;
        public virtual RelayCommand BCommand
        {
            get
            {
                return _bCommand;
            }
        }

        protected virtual void ExecuteB() {}
        protected virtual bool CanExecuteB() { return true;}
    }

}



