using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsController.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItServices _reverseItServices;
        public ReverseItController(ReverseItServices reverseItServices){
            _reverseItServices = reverseItServices;
        }
        [HttpPost]
        [Route("reversedWord/{userInput}")]
         public string ReversedWord(string userInput){
            return _reverseItServices.ReversedString(userInput);
         }
    }
}