

using System;
using System.IO;
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
                public const string CPropertyName = "C";
                protected  int _c;

                public  int C
                {
                    get
                    {
                        return _c;
                    }
                    set
                    {
                        if (_c == value)
                        {
                            return;
                        }
                        Set(ref _c, value);
                    }
                }


        private RelayCommand _loadCommand;
        public virtual RelayCommand LoadCommand
        {
            get
            {
				if (_loadCommand == null)
				{
					_loadCommand = new RelayCommand(ExecuteLoad, CanExecuteLoad);
				}
                return _loadCommand;
            }
        }

        protected virtual void ExecuteLoad() {}
        protected virtual bool CanExecuteLoad() { return true;}

        private RelayCommand _saveCommand;
        public virtual RelayCommand SaveCommand
        {
            get
            {
				if (_saveCommand == null)
				{
					_saveCommand = new RelayCommand(ExecuteSave, CanExecuteSave);
				}
                return _saveCommand;
            }
        }

        protected virtual void ExecuteSave() {}
        protected virtual bool CanExecuteSave() { return true;}
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

    }

}



