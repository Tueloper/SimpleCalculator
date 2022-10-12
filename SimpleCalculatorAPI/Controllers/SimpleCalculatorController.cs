using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleCalculatorController : ControllerBase
    {

        [HttpGet]
        public double Division(double num1, double num2)
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

            return result;
        }
    }
}
