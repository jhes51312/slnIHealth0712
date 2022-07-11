using System;
using System.Collections.Generic;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TCity
    {
        public TCity()
        {
            TRegions = new HashSet<TRegion>();
        }

        public int FCityId { get; set; }
        public string FCityName { get; set; }

        public virtual ICollection<TRegion> TRegions { get; set; }
    }
}
