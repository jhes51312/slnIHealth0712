using System;
using System.Collections.Generic;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TCourse
    {
        public TCourse()
        {
            TReservations = new HashSet<TReservation>();
        }

        public int FCourseId { get; set; }
        public int? FMemberId { get; set; }
        public int? FCoachId { get; set; }
        public int? FRemainingCourse { get; set; }
        public int? FStatusNumber { get; set; }
        public bool? FVisible { get; set; }

        public virtual TCoach FCoach { get; set; }
        public virtual TMember FMember { get; set; }
        public virtual TStatus FStatusNumberNavigation { get; set; }
        public virtual ICollection<TReservation> TReservations { get; set; }
    }
}
