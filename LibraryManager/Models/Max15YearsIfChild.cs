using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
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