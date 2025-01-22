using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsController.Models;
using BestTAsController.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloTwoController : ControllerBase
    {
        private readonly SayHelloTwoServices _sayHelloTwoServices;
        public SayHelloTwoController(SayHelloTwoServices sayHelloTwoServices){
            _sayHelloTwoServices = sayHelloTwoServices;
        }
        [HttpGet] //Use HttpGet to Request Information or "Get info"
        [Route("SayHelloTwo")]
        public List<SayHelloTwoModel> WithdrawName()
        {
            return _sayHelloTwoServices.WithdrawName();
        }
    }
}