using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManager.Models;

/// <summary>
///  The CustomerFormViewModel is a model built 
///  specifically for the CustomerForm View.
///   
///   It includes data from the Customer and  
///   MembershipType classes.
///   
///   The CustomerFormViewModel is passed to the
///   CustomerForm.cshtml View by the Customers Controller.
///  
/// </summary>

namespace LibraryManager.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public int? Id { get; set; }

        public string HeadingTitle { get; set; }
    }
}
