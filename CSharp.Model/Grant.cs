using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Model
{
    public class Grant
    {
        public int GrantId { get; set; }

        public int GrantAmount { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string AgencyName { get; set; }

        public int AwardId { get; set; }
        public Award Award { get; set; }

        public Grant()
        {
            DateCreated = DateTime.Now;
        }
    }
}
