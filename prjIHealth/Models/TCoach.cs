using System;
using System.Collections.Generic;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TCoach
    {
        public TCoach()
        {
            TCandidates = new HashSet<TCandidate>();
            TCoachAvailableTimes = new HashSet<TCoachAvailableTime>();
            TCoachContacts = new HashSet<TCoachContact>();
            TCoachRates = new HashSet<TCoachRate>();
            TCoachSkills = new HashSet<TCoachSkill>();
            TCourses = new HashSet<TCourse>();
        }

        public int FCoachId { get; set; }
        public int? FMemberId { get; set; }
        public int? FRegionId { get; set; }
        public string FCoachImage { get; set; }
        public string FExperience { get; set; }
        public string FLicense { get; set; }
        public string FCoachFee { get; set; }
        public string FCoachDescription { get; set; }
        public string FApplyDate { get; set; }
        public int? FStatusNumber { get; set; }
        public bool? FVisible { get; set; }
        public int? FCourseCount { get; set; }

        public virtual TMember FMember { get; set; }
        public virtual TRegion FRegion { get; set; }
        public virtual TStatus FStatusNumberNavigation { get; set; }
        public virtual ICollection<TCandidate> TCandidates { get; set; }
        public virtual ICollection<TCoachAvailableTime> TCoachAvailableTimes { get; set; }
        public virtual ICollection<TCoachContact> TCoachContacts { get; set; }
        public virtual ICollection<TCoachRate> TCoachRates { get; set; }
        public virtual ICollection<TCoachSkill> TCoachSkills { get; set; }
        public virtual ICollection<TCourse> TCourses { get; set; }
    }
}
