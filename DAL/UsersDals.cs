﻿using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UsersDal : IUsersDal
    {
        private List<User> users = new List<User>() {
            
        };

        public User GetById(int id)
        {
            return users.FirstOrDefault(item => item.Id == id);
        }

        public User GetByLogin(string login)
        {
            return users.FirstOrDefault(item => item.Login == login);
        }


        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
