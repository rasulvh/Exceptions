using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Tasks.Controller
{
    public class LoginController
    {
        public void Login()
        {
            Console.WriteLine("Enter your email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            ILoginService loginService = new LoginService();

            Console.WriteLine(loginService.Login(email, password));
        }
    }
}
