using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManager.Models;

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