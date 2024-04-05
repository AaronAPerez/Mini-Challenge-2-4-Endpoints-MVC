using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge_2_4_Endpoints_MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EndpointsController : ControllerBase
    {
        [HttpGet("/mathSum")]
        public string mathSum(int a = 1, int b =2)
        {
            int sum = a + b;

            string result = "The sum of " + a + " and " + b + " is " + sum + ".";
            return result;
        }

        [HttpGet("/nameWakeUpTime")]
        public string nameWakeUpTime(string name, string time, string amPm)
        {
            string result = "Hello " + name + "," + " you woke up at " + time +  amPm + "," + " Great Job!!!!!";
            return result;
        }

        [HttpGet("/compareNumbers")]

        public string compareNumbers(double a, double b){
            string resultOne = "";
            string resultTwo = "";

        if (a > b){
                resultOne = a + " is greater than " + b + "!";
                resultTwo = b + " is less than " + a + "!";
            }

            else if (b > a){
                resultOne = b + " is greater than " + a + "!";
                resultTwo = a + " is less than " + b + "!";   
            }

            else {
                resultOne = b + " is equal to " + a + "!";
                resultTwo = a + " is equal to " + b + "!";
            }
    
            string statement = resultOne + "\n" + resultTwo;
            return statement;
        }
    }
}
     