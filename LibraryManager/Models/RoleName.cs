using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    /*
        Model the access levels available to different roles.
        Administrator Role can manage books, add new content, delete books etc.
        All other users must be logged in, but can perform all other actions.
    */

    public static class RoleName
    {
        public const string CanManageBooks = "CanManageBooks";
    }
}