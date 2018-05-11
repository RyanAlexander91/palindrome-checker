using PalindromeChecker.UserInterface.Console.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker.UserInterface.Console.Views
{
    class MainView
    {
        static void Main(string[] args)
        {
            var mvm = new MainViewModel();
            mvm.LaunchApplication();
        }
    }
}
