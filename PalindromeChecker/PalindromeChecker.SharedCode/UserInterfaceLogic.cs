using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeChecker.SharedCode
{
    public class UserInterfaceLogic
    {
        #region Properties
        private const string userPrompt = "Please Enter word below:";
        private const string negativeResult = "Oops, that isn't a Palinddrome";
        private const string positiveResult = "Success! That is a Palindrome";
        private const string promptText = "Enter your word";
        private const string defaultResult = "Click button above to see your result";

        public string UserPrompt
        {
            get { return userPrompt; }
        }

        public string NegativeResult
        {
            get { return negativeResult; }
        }

        public string PostiveResult
        {
            get { return positiveResult; }
        }

        public string DefaultResult { get
            {
                return defaultResult;
            }
        }


        #endregion
        
    }
}
