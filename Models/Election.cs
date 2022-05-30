using System.Collections.Generic;
using Models.Enums;

namespace Models
{
    public class Election : BaseEntity
    {
        public ElectionType Type { get; set; }
        public string Location { get; set; }
        public Candidate Winner { get; set; }
        public Candidate FirstRunnerUp { get; set; }
        public Candidate SecondRunnerUp { get; set; }
        public ICollection<Candidate> Contenders { get; set; }

        public Election()
        {
        }

        public Election(string id) : base(id)
        {
        }
    }
}
