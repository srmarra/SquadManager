using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validator;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace SquadManager.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            UserValidator validator = new UserValidator();


            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    user.Email = "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage;
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }

            }

            return View("Index", user);
        }

        [HttpPost]

        public IActionResult Test(UserViewModel user)
        {
            user.Email = "emailEnviado";
            

            return View("Index", user);
        }
    }
}
