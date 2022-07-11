using System;
using System.Collections.Generic;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TAuthority
    {
        public TAuthority()
        {
            TMembers = new HashSet<TMember>();
        }

        public int FAutorityId { get; set; }
        public string FAuthorityName { get; set; }
        public string FRemarks { get; set; }

        public virtual ICollection<TMember> TMembers { get; set; }
    }
}
