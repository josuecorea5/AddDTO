using AutoMapper;
using ExampleDTO.Models;
using ExampleDTO.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleDTO.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = GetUserDetails();
            var userViewModel = _mapper.Map<UserViewModel>(user);
            //var mappedUser = _mapper.Map<User>(UserViewModel);

            return View(userViewModel);
        }
        private static User GetUserDetails()
        {
            return new User
            {
                Id =1,
                FirstName = "Josue",
                LastName = "Paiz",
                Email= "davidcoreas@gmail.com",
                Address = new Address { Country="ESA"}
               
            };
        }
    }
}
