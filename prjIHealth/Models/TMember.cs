using System;
using System.Collections.Generic;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TMember
    {
        public TMember()
        {
            TBodyRecords = new HashSet<TBodyRecord>();
            TCalorieIntakes = new HashSet<TCalorieIntake>();
            TCandidates = new HashSet<TCandidate>();
            TCoachContacts = new HashSet<TCoachContact>();
            TCoachRates = new HashSet<TCoachRate>();
            TCoaches = new HashSet<TCoach>();
            TCourses = new HashSet<TCourse>();
            TNews = new HashSet<TNews>();
            TOrders = new HashSet<TOrder>();
            TProblems = new HashSet<TProblem>();
            TReplies = new HashSet<TReply>();
            TTrackLists = new HashSet<TTrackList>();
        }

        public int FMemberId { get; set; }
        public string FMemberName { get; set; }
        public string FPassword { get; set; }
        public string FBirthday { get; set; }
        public bool? FGender { get; set; }
        public string FPicturePath { get; set; }
        public string FUserName { get; set; }
        public string FAddress { get; set; }
        public string FPhone { get; set; }
        public string FEmail { get; set; }
        public string FRegisterDate { get; set; }
        public int? FAuthorityId { get; set; }
        public bool? FDisabled { get; set; }
        public string FRemarks { get; set; }

        public virtual TAuthority FAuthority { get; set; }
        public virtual ICollection<TBodyRecord> TBodyRecords { get; set; }
        public virtual ICollection<TCalorieIntake> TCalorieIntakes { get; set; }
        public virtual ICollection<TCandidate> TCandidates { get; set; }
        public virtual ICollection<TCoachContact> TCoachContacts { get; set; }
        public virtual ICollection<TCoachRate> TCoachRates { get; set; }
        public virtual ICollection<TCoach> TCoaches { get; set; }
        public virtual ICollection<TCourse> TCourses { get; set; }
        public virtual ICollection<TNews> TNews { get; set; }
        public virtual ICollection<TOrder> TOrders { get; set; }
        public virtual ICollection<TProblem> TProblems { get; set; }
        public virtual ICollection<TReply> TReplies { get; set; }
        public virtual ICollection<TTrackList> TTrackLists { get; set; }
    }
}
