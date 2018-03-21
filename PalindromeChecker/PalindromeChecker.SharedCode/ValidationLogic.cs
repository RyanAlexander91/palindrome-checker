using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeChecker.SharedCode
{
    /// <summary>
    /// Class containing the validation logic for the code
    /// ----
    /// For this first example the example code is very simple and does not expect
    /// things such as captial letters.
    /// </summary>
    public class ValidationLogic
    {

        #region Properties

        private string inputReversed;

        public string InputReversed
        {
            get { return inputReversed; }
            set { inputReversed = value; }
        }

        #endregion

        #region Validation Code
        /// <summary>
        /// Initial Validation Code which can be used in all applications
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public bool CheckPalindrome(string userInput)
        {
            char[] inputarray = userInput.ToCharArray();
            Array.Reverse(inputarray);
            string result = new string(inputarray);

            if (result.Equals(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
