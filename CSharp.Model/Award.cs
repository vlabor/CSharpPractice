using System;
using System.Collections.Generic;

namespace CSharp.Model
{
    public class Award
    {
        public int AwardId { get; set; }
        public DateTime AwardDate { get; set; }
        public string Title { get; set; }

        public virtual List<Grant> Grants { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
