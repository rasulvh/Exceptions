using Service.Exceptions;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class FactorialService : IFactorialService
    {
        public string GetFactorial(int num)
        {
            try
            {
                if (num<0)
                {
                    throw new FactorialException("Plesa write correct number");
                }
                else
                {
                    int result = 1;

                    for (int i = num; i > 0; i--)
                    {
                        result *= i;
                    }

                    return $"Answer : {result}";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
