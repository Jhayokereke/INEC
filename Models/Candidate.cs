namespace Models
{
    public class Candidate : BaseEntity
    {
        public string Name { get; set; }
        public int Votes { get; set; }
        public Party Party { get; set; }
        public Election ElectionContested { get; set; }

        public Candidate()
        {
        }

        public Candidate(string id) : base(id)
        {
        }
    }
}
