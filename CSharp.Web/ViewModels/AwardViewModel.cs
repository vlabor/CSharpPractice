using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp.Web.ViewModels
{
    public class AwardViewModel
    {
        public int AwardId { get; set; }
        public DateTime AwardDate { get; set; }

        public string Title { get; set; }

        public List<GrantViewModel> Grants { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}