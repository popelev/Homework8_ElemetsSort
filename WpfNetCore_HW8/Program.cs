
using System;
using System.Windows.Navigation;
using WpfNetCore_HW8.Model;
using WpfNetCore_HW8.ViewModel;

namespace WpfNetCore_HW8
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            App application = new App();
            application.InitializeComponent();

            //MainViewVM vm = new MainViewVM();


            application.Run();
        }
    }
}
