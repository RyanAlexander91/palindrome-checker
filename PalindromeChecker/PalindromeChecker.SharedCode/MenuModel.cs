using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeChecker.SharedCode
{
    public class MenuModel
    {
        /// <summary>
        /// Use of auto properties as a test
        /// </summary>
        private const string instructionMenu = "Please Enter word below:";
        private const string negativeResult = "Oops, that isn't a Palinddrome";
        private const string positiveResult = "Success! That is a Palindrome";

        public string GetInstructionMenu()
        {
            return instructionMenu;
        }

        public string DisplayResultOutcome(string userInput)
        {
            var vl = new ValidationLogic();
            if (vl.CheckPalindrome(userInput).Equals(true))
            {
                return positiveResult;
            }
            else
            {
                return negativeResult;
            }
        }
        
    }
}
