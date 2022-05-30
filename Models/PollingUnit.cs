using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PollingUnit : BaseEntity
    {
        public string Unit_No { get; }
        [RegularExpression(@"^[A-Z]{3}$")]
        public string LocalGovernment { get; }
        public string PollingUnitCode { get; }
        public IList<Voter> Voters { get; set; }

        public PollingUnit(string LGA)
        {
            LocalGovernment = LGA;
            Unit_No = $"{LGA}-{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6)}";
            PollingUnitCode = Unit_No.Substring(0, 7);
        }

        public PollingUnit(string LGA, string unitNo, string id) : base(id)
        {
            LocalGovernment = LGA;
            Unit_No = unitNo;
            PollingUnitCode = Unit_No.Substring(0, 7);
        }
    }
}
