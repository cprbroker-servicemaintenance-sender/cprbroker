






/****** Object:  ForeignKey [FK_EventNotification_Subscription]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EventNotification_Subscription]') AND parent_object_id = OBJECT_ID(N'[dbo].[EventNotification]'))
ALTER TABLE [dbo].[EventNotification] DROP CONSTRAINT [FK_EventNotification_Subscription]
GO
/****** Object:  ForeignKey [FK_Subscription_SubscriptionType]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Subscription_SubscriptionType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subscription]'))
ALTER TABLE [dbo].[Subscription] DROP CONSTRAINT [FK_Subscription_SubscriptionType]
GO
/****** Object:  ForeignKey [FK_SubscriptionPerson_Subscription]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubscriptionPerson_Subscription]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubscriptionPerson]'))
ALTER TABLE [dbo].[SubscriptionPerson] DROP CONSTRAINT [FK_SubscriptionPerson_Subscription]
GO
/****** Object:  Default [DF_EventNotification_EventNotificationId]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EventNotification_EventNotificationId]') AND parent_object_id = OBJECT_ID(N'[dbo].[EventNotification]'))
Begin
ALTER TABLE [dbo].[EventNotification] DROP CONSTRAINT [DF_EventNotification_EventNotificationId]

End
GO
/****** Object:  Default [DF_Subscription_SubscriptionId]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Subscription_SubscriptionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subscription]'))
Begin
ALTER TABLE [dbo].[Subscription] DROP CONSTRAINT [DF_Subscription_SubscriptionId]

End
GO
/****** Object:  Default [DF_Subscription_IsForAllPersons]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Subscription_IsForAllPersons]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subscription]'))
Begin
ALTER TABLE [dbo].[Subscription] DROP CONSTRAINT [DF_Subscription_IsForAllPersons]

End
GO
/****** Object:  Default [DF_SubscriptionPerson_SubscriptionPersonId]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SubscriptionPerson_SubscriptionPersonId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubscriptionPerson]'))
Begin
ALTER TABLE [dbo].[SubscriptionPerson] DROP CONSTRAINT [DF_SubscriptionPerson_SubscriptionPersonId]

End
GO
/****** Object:  Table [dbo].[SubscriptionPerson]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubscriptionPerson]') AND type in (N'U'))
DROP TABLE [dbo].[SubscriptionPerson]
GO
/****** Object:  Table [dbo].[EventNotification]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EventNotification]') AND type in (N'U'))
DROP TABLE [dbo].[EventNotification]
GO
/****** Object:  Table [dbo].[Subscription]    Script Date: 02/13/2011 17:59:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subscription]') AND type in (N'U'))
DROP TABLE [dbo].[Subscription]
GO
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
/****** Object:  Table [dbo].[Subscription]    Script Date: 02/13/2011 17:59:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subscription]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Subscription](
	[SubscriptionId] [uniqueidentifier] NOT NULL,
	[SubscriptionTypeId] [int] NOT NULL,
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[IsForAllPersons] [bit] NOT NULL,
	[Criteria] [XML] NULL,
	[LastCheckedUUID] [uniqueidentifier] NULL,
	[Created] [Datetime] NOT NULL,
	[Deactivated] [Datetime] NULL,
    [Ready] BIT NOT NULL DEFAULT 0
 CONSTRAINT [PK_Subscription] PRIMARY KEY CLUSTERED 
(
	[SubscriptionId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[EventNotification]    Script Date: 02/13/2011 17:59:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EventNotification]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EventNotification](
	[EventNotificationId] [uniqueidentifier] NOT NULL,
	[SubscriptionId] [uniqueidentifier] NOT NULL,
	[PersonUuid] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[NotificationDate] [datetime] NULL,
	[Succeeded] [bit] NULL,
	[IsLastNotification] [bit] NULL,
 CONSTRAINT [PK_EventNotification] PRIMARY KEY CLUSTERED 
(
	[EventNotificationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[SubscriptionPerson]    Script Date: 02/13/2011 17:59:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubscriptionPerson]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SubscriptionPerson](
	[SubscriptionPersonId] [uniqueidentifier] NOT NULL,
	[SubscriptionId] [uniqueidentifier] NULL,
	[PersonUuid] [uniqueidentifier] NULL,
	[Created] [Datetime] NOT NULL,
	[Removed] [Datetime] NULL,
 CONSTRAINT [PK_SubscriptionPerson] PRIMARY KEY CLUSTERED 
(
	[SubscriptionPersonId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF),
 CONSTRAINT [IX_SubscriptionPerson] UNIQUE NONCLUSTERED 
(
	[SubscriptionId] ASC,
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

/****** Object:  Default [DF_EventNotification_EventNotificationId]    Script Date: 02/13/2011 17:59:04 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EventNotification_EventNotificationId]') AND parent_object_id = OBJECT_ID(N'[dbo].[EventNotification]'))
Begin
ALTER TABLE [dbo].[EventNotification] ADD  CONSTRAINT [DF_EventNotification_EventNotificationId]  DEFAULT (newid()) FOR [EventNotificationId]

End
GO
/****** Object:  Default [DF_Subscription_SubscriptionId]    Script Date: 02/13/2011 17:59:04 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Subscription_SubscriptionId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subscription]'))
Begin
ALTER TABLE [dbo].[Subscription] ADD  CONSTRAINT [DF_Subscription_SubscriptionId]  DEFAULT (newid()) FOR [SubscriptionId]

End
GO
/****** Object:  Default [DF_Subscription_IsForAllPersons]    Script Date: 02/13/2011 17:59:04 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Subscription_IsForAllPersons]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subscription]'))
Begin
ALTER TABLE [dbo].[Subscription] ADD  CONSTRAINT [DF_Subscription_IsForAllPersons]  DEFAULT ((1)) FOR [IsForAllPersons]

End
GO
/****** Object:  Default [DF_SubscriptionPerson_SubscriptionPersonId]    Script Date: 02/13/2011 17:59:04 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SubscriptionPerson_SubscriptionPersonId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubscriptionPerson]'))
Begin
ALTER TABLE [dbo].[SubscriptionPerson] ADD  CONSTRAINT [DF_SubscriptionPerson_SubscriptionPersonId]  DEFAULT (newid()) FOR [SubscriptionPersonId]

End
GO
/****** Object:  ForeignKey [FK_EventNotification_Subscription]    Script Date: 02/13/2011 17:59:04 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EventNotification_Subscription]') AND parent_object_id = OBJECT_ID(N'[dbo].[EventNotification]'))
ALTER TABLE [dbo].[EventNotification]  WITH CHECK ADD  CONSTRAINT [FK_EventNotification_Subscription] FOREIGN KEY([SubscriptionId])
REFERENCES [dbo].[Subscription] ([SubscriptionId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventNotification] CHECK CONSTRAINT [FK_EventNotification_Subscription]
GO
/****** Object:  ForeignKey [FK_Subscription_SubscriptionType]    Script Date: 02/13/2011 17:59:04 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Subscription_SubscriptionType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subscription]'))
ALTER TABLE [dbo].[Subscription]  WITH CHECK ADD  CONSTRAINT [FK_Subscription_SubscriptionType] FOREIGN KEY([SubscriptionTypeId])
REFERENCES [dbo].[SubscriptionType] ([SubscriptionTypeId])
GO
ALTER TABLE [dbo].[Subscription] CHECK CONSTRAINT [FK_Subscription_SubscriptionType]
GO
/****** Object:  ForeignKey [FK_SubscriptionPerson_Subscription]    Script Date: 02/13/2011 17:59:04 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubscriptionPerson_Subscription]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubscriptionPerson]'))
ALTER TABLE [dbo].[SubscriptionPerson]  WITH CHECK ADD  CONSTRAINT [FK_SubscriptionPerson_Subscription] FOREIGN KEY([SubscriptionId])
REFERENCES [dbo].[Subscription] ([SubscriptionId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubscriptionPerson] CHECK CONSTRAINT [FK_SubscriptionPerson_Subscription]
GO
