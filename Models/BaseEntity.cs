using System;

namespace Models
{
    public abstract class BaseEntity
    {
        public string Id { get; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid()
                .ToString()
                .Substring(5, 11)
                .Replace("-", "%");
        }

        public BaseEntity(string id)
        {
            Id = id;
        }
    }
}
