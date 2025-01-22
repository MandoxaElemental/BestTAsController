using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;
        public AddingTwoNumbers(AddTwoNumbersServices addTwoNumbersServices){
            _addTwoNumbersServices = addTwoNumbersServices;
        }
        [HttpPost]
        [Route("addNumber/{numberOne}/{numberTwo}")]
        public string AddNumbers(string numberOne, string numberTwo){
            return _addTwoNumbersServices.AddNumbers(numberOne, numberTwo);
        }
    }
}