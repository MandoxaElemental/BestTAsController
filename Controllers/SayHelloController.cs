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
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;
        public SayHelloController(SayHelloServices sayHelloServices){
            _sayHelloServices = sayHelloServices;
        }

        [HttpPost]
        [Route("HelloWorld/{name}")]
        public string YourName(string name){
            return _sayHelloServices.AddNameToList(name);
        }
    }
}