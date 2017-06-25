using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp.Web.ViewModels
{
    public class GrantFormViewModel
    {
        public int Amount { get; set; }
        
        public string GrantedAgencyName { get; set; }

        public int OriginalAwardId { get; set; }
    }
}