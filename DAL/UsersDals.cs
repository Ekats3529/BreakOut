using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UsersDal : IUsersDal
    {
        private List<User> users = new List<User>() {
            new User() { Id = 1, Name = "Ivan", Login = "somebody", RegistrationDate = new DateTime(2022, 12, 12) },
            new User() { Id = 2, Name = "Ivan", Login = "somebody1", RegistrationDate = new DateTime(2022, 12, 12) },
            new User() { Id = 3, Name = "Ivan", Login = "somebody2", RegistrationDate = new DateTime(2022, 12, 12) },
            new User() { Id = 4, Name = "Ivan", Login = "somebody_", RegistrationDate = new DateTime(2022, 12, 12) },
        };

        public User GetById(int id)
        {
            return users.FirstOrDefault(item => item.Id == id);
        }
        public User GetByLogin(string login)
        {
            return users.FirstOrDefault(item => item.Login == login);
        }
    }
}
