using SampleWpfApplication.Model;

namespace SampleWpfApplication.ViewModel
{
    class MainViewModel : MainViewModelBase
    {
        protected override void ExecuteLoad()
        {
            Who = new Person {Name="Jason"};
            LoadCommand.RaiseCanExecuteChanged();
        }

        protected override bool CanExecuteLoad()
        {
            return Who == null;
        }
    }
}
