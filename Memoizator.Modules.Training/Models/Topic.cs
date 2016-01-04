using System;
using System.Collections.Generic;

namespace Memoizator.Modules.Training.Models
{
    public class Topic
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public Topic Parent { get; }
        public List<Term> Terms { get; } 

        public Topic(Guid id, string name, string description, Topic parent)
        {
            Id = id;
            Name = name;
            Description = description;
            Parent = parent;
            Terms = new List<Term>();
        }

        public void Add(Term term)
        {
            Terms.Add(term);
            term.ContainingTopics.Add(this);
        }

        public void Remove(Term term)
        {
            Terms.Remove(term);
            term.ContainingTopics.Remove(this);
        }
    }
}
