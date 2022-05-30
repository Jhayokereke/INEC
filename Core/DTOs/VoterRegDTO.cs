using Commons.Enums;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class VoterRegDTO
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public PollingUnit PollingUnit { get; set; }
    }
}
