using System;
using NUnit.Framework;
using OtherNamespace;
using Shuttle.ESB.Core;
using Shuttle.ESB.Test.Shared;

namespace Shuttle.ESB.Test.Unit.Core
{
    public class MessageRouteTest : UnitFixture
    {
        [Test]
        public void Should_be_able_to_create_a_new_route()
        {
            IMessageRoute map = new MessageRoute(new MemoryQueue(new Uri("memory://.")));

            map.AddSpecification(new RegexMessageRouteSpecification("simple"));

			Assert.IsFalse(map.IsSatisfiedBy(new OtherNamespaceCommand().GetType().FullName));
			Assert.IsTrue(map.IsSatisfiedBy(new SimpleCommand().GetType().FullName));
        }
    }
}
