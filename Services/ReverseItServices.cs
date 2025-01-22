using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsController.Services
{
    public class ReverseItServices
    {
        public string reversedWord = "";
        string emptyWord = string.Empty;
        public string ReversedString(string userInput){
            for(int i=userInput.Length-1; i >= 0; i--){
                emptyWord += userInput[i];
            }
            reversedWord = $"Input = {userInput}... Output = {emptyWord}; Have a nice day";
            return reversedWord;
        }
    }
}