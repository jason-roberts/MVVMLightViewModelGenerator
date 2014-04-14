using System.Windows;
using SampleWpfApplication.ViewModel;

namespace SampleWpfApplication
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // Wire this up manually for demo puposes. In real implementation you could use MVVM Light's ViewModelLocator
            var vm = new MainViewModel();

            this.DataContext = vm;
        }
    }
}
