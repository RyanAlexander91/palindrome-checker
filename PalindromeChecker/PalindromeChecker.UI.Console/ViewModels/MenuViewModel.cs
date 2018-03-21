using PalindromeChecker.SharedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker.UI.Console.ViewModels
{
    public class MenuViewModel
    {

        public void LaunchApplication()
        {
            var menu = new MenuModel();
            System.Console.WriteLine(menu.GetInstructionMenu());
            string userInput = System.Console.ReadLine();
            System.Console.WriteLine(menu.DisplayResultOutcome(userInput));
            System.Console.ReadLine();
        }
    }
}
