using System;
using System.Collections.Generic;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TAvailableTime
    {
        public TAvailableTime()
        {
            TCoachAvailableTimes = new HashSet<TCoachAvailableTime>();
        }

        public int FAvailableTimeId { get; set; }
        public string FAvailableTime { get; set; }

        public virtual ICollection<TCoachAvailableTime> TCoachAvailableTimes { get; set; }
    }
}
