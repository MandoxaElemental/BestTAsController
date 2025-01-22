using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsController.Models;

namespace BestTAsController.Services
{
    public class SayHelloTwoServices
    {
        public List<SayHelloTwoModel> nameList = new();

        public SayHelloTwoServices()
        {
            nameList.Add(new SayHelloTwoModel {
                Name = "Boy"
            });
        }
        public List<SayHelloTwoModel> WithdrawName(){
            return nameList;
        }
    }
}