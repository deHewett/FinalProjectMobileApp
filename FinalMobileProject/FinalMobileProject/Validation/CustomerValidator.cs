using FinalMobileProject.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalMobileProject.Validation
{
    public class CustomerValidator: AbstractValidator<User>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Username).NotNull();
            RuleFor(customer => customer.Password).NotNull();
            RuleFor(customer => customer.FullName).NotNull();
            RuleFor(customer => customer.Email).NotNull();
            RuleFor(customer => customer.ContactNumber).NotNull();
            RuleFor(customer => customer.BillingAddress).NotNull();

        }
    }
}
