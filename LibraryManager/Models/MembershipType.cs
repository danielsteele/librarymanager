using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        // percentage of late fees paid by this membership type
        // seniors and children => 50%, else 100%
        public short LateFeeRate { get; set; }

        // senior member => 10 years, child => 1 year, standard => 2 years
        public byte DurationInYears { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte Standard = 1;
        public static readonly byte Senior = 2;
        public static readonly byte Child = 3;

    }
}