using FluentValidation;
using SquadManager.Models;
using System.ComponentModel.DataAnnotations;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {

        public UserValidator()
        {
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("E-maiinvalido");
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");



        }
    }
}
