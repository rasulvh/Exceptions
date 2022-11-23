using Domain.Models;
using Service.Exceptions;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        public string Login(string email, string password)
        {
			User user = new User();

			user.Email = email;
			user.Password = password;

			try
			{
				if (!email.Contains("@") && password != "rasul1234")
				{
					throw new LoginException("Please check your email or password");
				}
				else
				{
					return "Login succeed";
				}
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
        }
    }
}
