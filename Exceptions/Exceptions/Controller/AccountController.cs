using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Controller
{
    public class AccountController
    {
        public void Register()
        {
            try
            {
                Console.WriteLine("Enter username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                User user = new User();

                user.Email = email;
                user.Password = password;
                user.Username = username;

                IAccountService service = new AccountService();

                var result = service.Register(user);

                if (!result)
                {
                    throw new Exception("Email doesn't have '@' symbol");
                }

                else
                {
                    Console.WriteLine("Success");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetUserById()
        {
            try
            {
                IAccountService service = new AccountService();

                service.GetUserById(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
