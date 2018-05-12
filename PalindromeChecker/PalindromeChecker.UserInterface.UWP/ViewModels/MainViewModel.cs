using PalindromeChecker.SharedCode;
using PalindromeChecker.SharedCode.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker.UserInterface.UWP.ViewModels
{
    public class MainViewModel : BaseINPC
    {

        private UserInterfaceLogic uiLogic;
        private ValidationLogic vlogic = new ValidationLogic();
        private string resultLabel;

        public MainViewModel()
        {
            uiLogic = new UserInterfaceLogic();
            CheckCommand = new CheckPalindromeCommand(GetResult);
            resultLabel = uiLogic.DefaultResult;
        }

        #region Properties
        // For this CheckCommand I am testing Auto Properties.
        public CheckPalindromeCommand CheckCommand { get; private set; }

        public string UserPrompt
        {
            get
            {
                return uiLogic.UserPrompt;
            }
        }

        public string PositiveResult
        {
            get
            {
                return uiLogic.PostiveResult;
            }
        }

        public string NegativeResult
        {
            get
            {
                return uiLogic.NegativeResult;
            }
        }

        public string ResultLabel
        {
            get
            {
                return resultLabel;
            }
            set
            {
                resultLabel = value;
                RaisePropertyChangedEvent("ResultLabel");
            }
        }


        #endregion

        #region Main Logic Methods

        public void GetResult(string userInput)
        {
            var result = vlogic.CheckPalindrome(userInput);
            if (result == true)
            {
                ResultLabel = PositiveResult;
            }
            else
            {
                ResultLabel = NegativeResult;
            }

        }

        #endregion
    }
}
