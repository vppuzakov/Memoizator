using System;
using Memoizator.Modules.Training.Models;
using NUnit.Framework;

namespace Memoizator.Modules.Training.Tests.Models
{
    [TestFixture]
    public class TopicTests
    {
        [Test]
        public void ShouldAddTerm()
        {
            var topic = new Topic(Guid.NewGuid(), "Topic name", "Topic description", null);
            var term = new Term(Guid.NewGuid(), "term name", "term description");

            topic.Add(term);
 
            Assert.That(topic.Terms, Has.Member(term));
        }

        [Test]
        public void ShouldAddTopic()
        {
            var topic = new Topic(Guid.NewGuid(), "Topic name", "Topic description", null);
            var term = new Term(Guid.NewGuid(), "term name", "term description");

            topic.Add(term);

            Assert.That(term.ContainingTopics, Has.Member(topic));
        }

        [Test]
        public void ShouldRemoveTerm()
        {
            var topic = new Topic(Guid.NewGuid(), "Topic name", "Topic description", null);
            var term = new Term(Guid.NewGuid(), "term name", "term description");
            topic.Add(term);

            topic.Remove(term);

            Assert.That(topic.Terms, Has.No.Member(term));
        }

        [Test]
        public void ShouldRemoveTopic()
        {
            var topic = new Topic(Guid.NewGuid(), "Topic name", "Topic description", null);
            var term = new Term(Guid.NewGuid(), "term name", "term description");
            topic.Add(term);

            topic.Remove(term);

            Assert.That(term.ContainingTopics, Has.No.Member(topic));
        }

    }
}
