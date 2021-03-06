﻿using NUnit.Framework;

namespace Shuttle.ESB.Test.Integration
{
	public class MsmqOutboxTest : OutboxFixture
	{
		[Test]
		[TestCase(false)]
		[TestCase(true)]
		public void Should_be_able_handle_errors(bool isTransactionalEndpoint)
		{
			TestOutboxSending("msmq://./{0}", isTransactionalEndpoint);
		}
	}
}