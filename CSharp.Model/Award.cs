using System;

namespace CSharp.Model
{
    public class Award
    {
        public int AwardId { get; set; }
        public DateTime AwardDate { get; set; }

        public string Title { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}
