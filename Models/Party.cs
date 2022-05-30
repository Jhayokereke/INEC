using System.Collections.Generic;

namespace Models
{
    public class Party : BaseEntity
    {
        public string Name { get; set; }
        public IList<Candidate> Candidates { get; set; }

        public Party()
        {
        }

        public Party(string id) : base (id)
        {
        }
    }
}
