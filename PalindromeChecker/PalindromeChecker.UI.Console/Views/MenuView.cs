using PalindromeChecker.UI.Console.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker.UI.Console.Views
{
    class MenuView
    {
        static void Main(string[] args)
        {
            var mvm = new MenuViewModel();
            mvm.LaunchApplication();
        }
    }
}
