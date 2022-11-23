using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Tasks.Controller
{
    public class FactorialController
    {
        public void Factorial(int num)
        {
            IFactorialService factorialService = new FactorialService();

            Console.WriteLine(factorialService.GetFactorial(num));
        }
    }
}
