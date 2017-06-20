using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    /*
        Validation class that is applied to a new customer upon account creation.
        Verify that a BirthDate value has been entered.
        Verify that if the Senior membership type has been selected that the new
        customer is not younger than 65 years.
    */

    public class Min65YearsIfSenior : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId != MembershipType.Senior)
            {
                return ValidationResult.Success;
            }

            if (customer.BirthDate == null)
            {
                return new ValidationResult("BirthDate is required.");
            }

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return (age >= 65)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 65 years old for Senior Membership");
        }
    }
}