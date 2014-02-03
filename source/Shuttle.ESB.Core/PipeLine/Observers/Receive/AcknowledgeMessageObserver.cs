﻿using Shuttle.Core.Infrastructure;

namespace Shuttle.ESB.Core
{
    public class AcknowledgeMessageObserver :
        IPipelineObserver<OnAcknowledgeMessage>
    {
        private readonly ILog log;

        public AcknowledgeMessageObserver()
        {
            log = Log.For(this);
        }

		public void Execute(OnAcknowledgeMessage pipelineEvent)
        {
			if (pipelineEvent.Pipeline.Exception != null && !pipelineEvent.GetTransactionComplete()) 
			{
				return;
			}

			var acknowledge = pipelineEvent.GetWorkQueue() as IAcknowledge;

			if (acknowledge == null)
			{
				return;
			}

			acknowledge.Acknowledge(TODO);
        }
    }
}
