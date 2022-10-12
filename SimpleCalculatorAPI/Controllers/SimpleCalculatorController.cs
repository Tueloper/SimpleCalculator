using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCalculatorAPI.Controllers
{
//here defines the api route via the api of each api method
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SimpleCalculatorController : ControllerBase
    {
        [HttpPost]
        public double Add(double num1, double num2)
        {
            //using the simple calculator logic class to add 2 numbers
            double result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(num1, num2);

            //return added values in 2 decimal points
            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Substract(double num1, double num2)
        {
            //using the simple calculator logic class to substract 2 numbers
            double result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(num1, num2);

            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Multiply(double num1, double num2)
        {
            //using the simple calculator logic class to multiply 2 numbers
            double result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(num1, num2);

            //return added values in 2 decimal points
            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Divide(double num1, double num2)
        {
            double result = 0;

            //I am using the try and catch method here to catch any exception error throw from diving any number by zero
            try
            {
                //using the simple calculator logic class to divide 2 numbers
                result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(num1, num2);
            }
            catch (DivideByZeroException)
            {
                //using dividebyzeo exception to catch specific error and changing status code to 400
                Response.StatusCode = 400;
            }

            return Math.Round(result, 2);
        }
    }
}
