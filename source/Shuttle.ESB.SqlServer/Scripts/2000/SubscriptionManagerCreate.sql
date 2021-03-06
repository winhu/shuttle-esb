CREATE TABLE [dbo].[SubscriberMessageType](
	[MessageType] [varchar](265) NOT NULL,
	[InboxWorkQueueUri] [varchar](265) NOT NULL
 CONSTRAINT [PK_SubscriberMessageType] PRIMARY KEY CLUSTERED 
(
	[MessageType] ASC,
	[InboxWorkQueueUri] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
