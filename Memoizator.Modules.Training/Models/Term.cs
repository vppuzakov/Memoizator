using System;
using System.Collections.Generic;

namespace Memoizator.Modules.Training.Models
{
    public class Term
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public List<Topic> ContainingTopics { get; }

        public Term(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            ContainingTopics = new List<Topic>();
        }
    }
}
