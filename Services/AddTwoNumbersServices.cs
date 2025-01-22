using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsController.Services
{
    public class AddTwoNumbersServices
    {
        public string numbers = "";
        bool validCheck1 = false;
        int convertedNum1;
        bool validCheck2 = false;
        int convertedNum2;
        public string AddNumbers(string numberOne, string numberTwo)
        {
            validCheck1 = int.TryParse(numberOne, out convertedNum1);
            validCheck2 = int.TryParse(numberTwo, out convertedNum2);
            if (validCheck1 == false || validCheck2 == false)
            {
                numbers = "ERROR: Please Enter a Valid Number";
                return numbers;
            }
            else
            {
                numbers = $"{numberOne} Plus {numberTwo} is Equal to: {convertedNum1 + convertedNum2}. Noice!";
                return numbers;
            }
        }
    }
}