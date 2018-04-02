using PalindromeChecker.SharedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker.UI.Console.ViewModels
{
    public class MainViewModel
    {
        
        /// <summary>
        /// Method run when the application is launched.
        /// </summary>
        public void LaunchApplication()
        {
            // New Instance of Models
            var uiLogic = new UserInterfaceLogic();
            var vLogic = new ValidationLogic();

            // Display Initial Menu
            DisplayInitialPrompt(uiLogic);

            // Store the user's input into the 'userInput' string.
            string userInput = System.Console.ReadLine();

            // Run the validation vLogic and display result 
            DisplayResult(uiLogic, vLogic, userInput);

            // User presses enter to exit the application
            DisplayExitPrompt();
        }

        // Method to display result
        private static void DisplayResult(UserInterfaceLogic menu, ValidationLogic logic, string userInput)
        {
            var result = logic.CheckPalindrome(userInput);
            if(result == true)
            {
                System.Console.WriteLine(menu.PostiveResult);
            }
            else
            {
                System.Console.WriteLine(menu.NegativeResult);
            }
        }


        // Display initial uiLogic prompt
        private void DisplayInitialPrompt(UserInterfaceLogic menu)
        {
            System.Console.WriteLine(menu.UserPrompt);
        }

        // Exit prompt method
        private static void DisplayExitPrompt()
        {
            StringBuilder exitPrompt = new StringBuilder("-------\n");
            exitPrompt.Append("Press Enter to Exit\n");
            exitPrompt.Append("-------");
            System.Console.WriteLine(exitPrompt);
            System.Console.ReadLine();
        }
    }
}
