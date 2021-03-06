﻿using NUnit.Framework;

namespace Shuttle.ESB.Test.Integration
{
	public class MsmqResourceUsageTest : ResourceUsageFixture
	{
		[Test]
		[TestCase(false)]
		[TestCase(true)]
		public void Should_not_exceeed_normal_resource_usage(bool isTransactionalEndpoint)
		{
			TestResourceUsage("msmq://./{0}", isTransactionalEndpoint);
		}
	}
}