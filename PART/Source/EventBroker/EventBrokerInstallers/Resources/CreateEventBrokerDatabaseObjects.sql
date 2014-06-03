







/****** Object:  Table [dbo].[PersonBirthdate]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonBirthdate]') AND type in (N'U'))
DROP TABLE [dbo].[PersonBirthdate]
GO
/****** Object:  Table [dbo].[DataChangeEvent]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataChangeEvent]') AND type in (N'U'))
DROP TABLE [dbo].[DataChangeEvent]
GO

/****** Object:  Table [dbo].[DataChangeEvent]    Script Date: 02/13/2011 17:59:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataChangeEvent]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataChangeEvent](
	[DataChangeEventId] [uniqueidentifier] NOT NULL,
	[PersonUuid] [uniqueidentifier] NOT NULL,
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	[ReceivedDate] [datetime] NOT NULL,
    [ReceivedOrder] int NOT NULL IDENTITY (1, 1)
 CONSTRAINT [PK_DataChangeEvent] PRIMARY KEY CLUSTERED 
(
	[DataChangeEventId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonBirthdate]    Script Date: 02/13/2011 17:59:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonBirthdate]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonBirthdate](
	[PersonUuid] [uniqueidentifier] NOT NULL,
	[Birthdate] [datetime] NOT NULL,
 CONSTRAINT [PK_PersonBirthdate] PRIMARY KEY CLUSTERED 
(
	[PersonUuid] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO

-------------------------------------
-- Table : SubscriptionCriteriaMatch
-------------------------------------

IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = object_id('SubscriptionCriteriaMatch'))
BEGIN
	CREATE TABLE [dbo].[SubscriptionCriteriaMatch](
		[SubscriptionCriteriaMatchId] [uniqueidentifier] NOT NULL DEFAULT NEWID(),
		[SubscriptionId] [uniqueidentifier] NOT NULL,
		[DataChangeEventId] [uniqueidentifier] NOT NULL,
		CONSTRAINT [PK_SubscriptionCriteriaMatch] PRIMARY KEY CLUSTERED ( [SubscriptionCriteriaMatchId] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
		CONSTRAINT [FK_SubscriptionCriteriaMatch_DataChangeEvent] FOREIGN KEY([DataChangeEventId]) REFERENCES [dbo].[DataChangeEvent] ([DataChangeEventId]) ON UPDATE CASCADE ON DELETE CASCADE,
		CONSTRAINT [FK_SubscriptionCriteriaMatch_Subscription] FOREIGN KEY([SubscriptionId]) REFERENCES [dbo].[Subscription] ([SubscriptionId]) ON UPDATE CASCADE ON DELETE CASCADE
	) ON [PRIMARY]
END

GO

