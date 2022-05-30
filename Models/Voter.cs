using Commons.Enums;
using System;

namespace Models
{
    public class Voter : BaseEntity
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Photo { get; set; }
        public string Registration_No { get; }
        public string DateOfBirth { get; set; }
        public bool HasVoted { get; set; }
        public PollingUnit PollingUnit { get; set; }
        public Voter()
        {
            Registration_No = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
        }

        public Voter(string regNo, string id) : base(id)
        {
            Registration_No = regNo;
        }
    }
}
