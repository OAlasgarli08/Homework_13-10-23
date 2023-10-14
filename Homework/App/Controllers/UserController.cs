using Helpers.Helper;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;
        private readonly UserHelper _userHelper;
        public UserController()
        {
            _userService = new UserService();
            _userHelper = new UserHelper();
        }
        public void UserLoginDetails()
        {
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
            var users = _userService.UserLoginMethod(email, password);

            if (email != null || password!= null)
            {
                Console.WriteLine(UserHelper.BlankLoginDetails);
            }

            // I forgot how to do the rest
        }
    }
}
