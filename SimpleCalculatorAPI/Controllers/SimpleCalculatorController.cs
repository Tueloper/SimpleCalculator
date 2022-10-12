using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCalculatorAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SimpleCalculatorController : ControllerBase
    {
        [HttpPost]
        public double Add(double num1, double num2)
        {
            double result = SimpleCalculatorLogic.SimpleCalculator.AddNumbers(num1, num2);

            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Substract(double num1, double num2)
        {
            double result = SimpleCalculatorLogic.SimpleCalculator.SubstractNumbers(num1, num2);

            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Multiply(double num1, double num2)
        {
            double result = SimpleCalculatorLogic.SimpleCalculator.MultiplyNumbers(num1, num2);

            return Math.Round(result, 2);
        }

        [HttpPost]
        public double Divide(double num1, double num2)
        {
            double result = 0;

            try
            {
                result = SimpleCalculatorLogic.SimpleCalculator.DivideNumbers(num1, num2);
            }
            catch (DivideByZeroException)
            {
                Response.StatusCode = 400;
            }

            return Math.Round(result, 2);
        }
    }
}
