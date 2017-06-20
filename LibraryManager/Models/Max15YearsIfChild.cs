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
        Verify that if the Child membership type has been selected that the new
        customer is not older than 15 years.
    */

    public class Max15YearsIfChild : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId != MembershipType.Child)
            {
                return ValidationResult.Success;
            }

            if (customer.BirthDate == null)
            {
                return new ValidationResult("BirthDate is required.");
            }

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return (age <= 15)
                ? ValidationResult.Success
                : new ValidationResult("Customer's age should be 15 years or less for Child Membership");
        }
    }
}