using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMDal
{
    public class OrmUsersDal : IUsersDal
    {
        public Entities.User GetByLogin(string login)
        {
            var context = new DefaultDbContext();
            try
            {
                var user = context.Users.FirstOrDefault(item => item.Name == login);

                if (user == null)
                {
                    return null;
                }
                var entity = new Entities.User()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Login = user.Login,
                    Password = user.Password,
                    RegistrationDate = user.RegistrationDate
                };
                return entity;
            }
            finally
            {
                context.Dispose();
            }
        }

            public Entities.User GetById(int id)
        {
            var context = new DefaultDbContext();
            try {
                var user = context.Users.FirstOrDefault(item => item.Id == id);

                if (user == null) {
                    return null;
                }
                var entity = new Entities.User()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Login = user.Login,
                    Password = user.Password,
                    RegistrationDate = user.RegistrationDate
                };
                return entity;
            }
            finally {
                context.Dispose();
            }

        }

        public void AddUser(Entities.User user)
        {
            var context = new DefaultDbContext();
            try
            {
                context.Users.Add(new User()
                {
                    Name = user.Name,
                    Password = user.Password,
                    Login = user.Login,
                    RegistrationDate = user.RegistrationDate
                });
                context.SaveChanges();
            }
            finally
            {
                context.Dispose();
            }
        }
    }
}
