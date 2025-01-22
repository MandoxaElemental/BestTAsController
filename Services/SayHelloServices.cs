using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsController.Services
{
    public class SayHelloServices
    {
         public string result = "";
        bool validCheck = false;
        int convertedNum;
        public string AddNameToList(string name){
            validCheck = int.TryParse(name, out convertedNum);
            if (validCheck == true){
                result = "ERROR: Please enter a Name, not a Number";
            }
            else{    
            result = "Hello, " + name + "! It is nice to meet you!";
            }
            return result;
        }
    }
}