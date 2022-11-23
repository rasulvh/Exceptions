﻿using Domain.Models;
using Service.Exceptions;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public User GetUserById(int id)
        {
            List<User> users = new List<User>();

            users.Add(new User { Id = 1, Username = "Test1", Email = "test1@gmail.com", Password = "12345" });
            users.Add(new User { Id = 2, Username = "Test2", Email = "test2@gmail.com", Password = "12345" });
            users.Add(new User { Id = 3, Username = "Test3", Email = "test3@gmail.com", Password = "12345" });
            users.Add(new User { Id = 4, Username = "Test4", Email = "test4@gmail.com", Password = "12345" });
            users.Add(new User { Id = 5, Username = "Test5", Email = "test5@gmail.com", Password = "12345" });


            var result = users.Find(m => m.Id == id);

            if (result==null)
            {
                throw new NotFoundException("User not found");
            }

            return result;
        }

        public bool Register(User user)
        {
            if (!user.Email.Contains("@"))
            {
                return false;
            }

            return true;
        }
    }
}
