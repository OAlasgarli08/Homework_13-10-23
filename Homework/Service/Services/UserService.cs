using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService
    {
        private User[] GetAll()
        {
            return new User[]
            {
                new User {Id = 1 ,FullName = "Person A", Age = 10, Email = "persona@gmail.com", Password = "person1"},
                new User {Id = 2 ,FullName = "Person B", Age = 12, Email = "personb@gmail.com", Password = "person2"},
                new User {Id = 3 ,FullName = "Person C", Age = 15, Email = "personc@gmail.com", Password = "person3"}
            };
        }


    }
}
