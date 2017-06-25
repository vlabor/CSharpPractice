using CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp.Web.ViewModels
{
    public class GrantViewModel
    {
        public int GrantId { get; set; }

        public int GrantAmount { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string AgencyName { get; set; }

        public int AwardId { get; set; }

    }
}