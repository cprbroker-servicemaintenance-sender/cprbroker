/****** Object:  ForeignKey [FK_AddressPoint_DanishAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AddressPoint_DanishAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[AddressPoint]'))
ALTER TABLE [dbo].[AddressPoint] DROP CONSTRAINT [FK_AddressPoint_DanishAddress]
GO
/****** Object:  ForeignKey [FK_AddressPointStatus_AddressPoint]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AddressPointStatus_AddressPoint]') AND parent_object_id = OBJECT_ID(N'[dbo].[AddressPointStatus]'))
ALTER TABLE [dbo].[AddressPointStatus] DROP CONSTRAINT [FK_AddressPointStatus_AddressPoint]
GO
/****** Object:  ForeignKey [FK_ContactChannel_ContactChannelType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContactChannel_ContactChannelType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactChannel]'))
ALTER TABLE [dbo].[ContactChannel] DROP CONSTRAINT [FK_ContactChannel_ContactChannelType]
GO
/****** Object:  ForeignKey [FK_CountryRef_CountrySchemeType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CountryRef_CountrySchemeType]') AND parent_object_id = OBJECT_ID(N'[dbo].[CountryRef]'))
ALTER TABLE [dbo].[CountryRef] DROP CONSTRAINT [FK_CountryRef_CountrySchemeType]
GO
/****** Object:  ForeignKey [FK_CprData_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CprData_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[CprData]'))
ALTER TABLE [dbo].[CprData] DROP CONSTRAINT [FK_CprData_Address]
GO
/****** Object:  ForeignKey [FK_CprData_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CprData_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[CprData]'))
ALTER TABLE [dbo].[CprData] DROP CONSTRAINT [FK_CprData_CountryRef]
GO
/****** Object:  ForeignKey [FK_CprData_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CprData_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[CprData]'))
ALTER TABLE [dbo].[CprData] DROP CONSTRAINT [FK_CprData_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_DanishAddress_DenmarkAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DanishAddress_DenmarkAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[DanishAddress]'))
ALTER TABLE [dbo].[DanishAddress] DROP CONSTRAINT [FK_DanishAddress_DenmarkAddress]
GO
/****** Object:  ForeignKey [FK_DenmarkAddress_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DenmarkAddress_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[DenmarkAddress]'))
ALTER TABLE [dbo].[DenmarkAddress] DROP CONSTRAINT [FK_DenmarkAddress_Address]
GO
/****** Object:  ForeignKey [FK_DenmarkAddress_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DenmarkAddress_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[DenmarkAddress]'))
ALTER TABLE [dbo].[DenmarkAddress] DROP CONSTRAINT [FK_DenmarkAddress_CountryRef]
GO
/****** Object:  ForeignKey [FK_Effect_ActorRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Effect_ActorRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[Effect]'))
ALTER TABLE [dbo].[Effect] DROP CONSTRAINT [FK_Effect_ActorRef]
GO
/****** Object:  ForeignKey [FK_ForeignAddress_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignAddress_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignAddress]'))
ALTER TABLE [dbo].[ForeignAddress] DROP CONSTRAINT [FK_ForeignAddress_Address]
GO
/****** Object:  ForeignKey [FK_ForeignAddress_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignAddress_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignAddress]'))
ALTER TABLE [dbo].[ForeignAddress] DROP CONSTRAINT [FK_ForeignAddress_CountryRef]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenCountry_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenCountry_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenCountry]'))
ALTER TABLE [dbo].[ForeignCitizenCountry] DROP CONSTRAINT [FK_ForeignCitizenCountry_CountryRef]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenCountry_ForeignCitizenData]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenCountry_ForeignCitizenData]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenCountry]'))
ALTER TABLE [dbo].[ForeignCitizenCountry] DROP CONSTRAINT [FK_ForeignCitizenCountry_ForeignCitizenData]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenData_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenData_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenData]'))
ALTER TABLE [dbo].[ForeignCitizenData] DROP CONSTRAINT [FK_ForeignCitizenData_CountryRef]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenData_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenData_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenData]'))
ALTER TABLE [dbo].[ForeignCitizenData] DROP CONSTRAINT [FK_ForeignCitizenData_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_GeographicCoorditaneTuple_GeographicPointLocation]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GeographicCoorditaneTuple_GeographicPointLocation]') AND parent_object_id = OBJECT_ID(N'[dbo].[GeographicCoorditaneTuple]'))
ALTER TABLE [dbo].[GeographicCoorditaneTuple] DROP CONSTRAINT [FK_GeographicCoorditaneTuple_GeographicPointLocation]
GO
/****** Object:  ForeignKey [FK_GeographicPointLocation_AddressPoint]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GeographicPointLocation_AddressPoint]') AND parent_object_id = OBJECT_ID(N'[dbo].[GeographicPointLocation]'))
ALTER TABLE [dbo].[GeographicPointLocation] DROP CONSTRAINT [FK_GeographicPointLocation_AddressPoint]
GO
/****** Object:  ForeignKey [FK_GreenlandicAddress_DenmarkAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GreenlandicAddress_DenmarkAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[GreenlandicAddress]'))
ALTER TABLE [dbo].[GreenlandicAddress] DROP CONSTRAINT [FK_GreenlandicAddress_DenmarkAddress]
GO
/****** Object:  ForeignKey [FK_HealthInformation_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HealthInformation_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[HealthInformation]'))
ALTER TABLE [dbo].[HealthInformation] DROP CONSTRAINT [FK_HealthInformation_Effect]
GO
/****** Object:  ForeignKey [FK_HealthInformation_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HealthInformation_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[HealthInformation]'))
ALTER TABLE [dbo].[HealthInformation] DROP CONSTRAINT [FK_HealthInformation_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_LogEntry_Application]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LogEntry_Application]') AND parent_object_id = OBJECT_ID(N'[dbo].[LogEntry]'))
ALTER TABLE [dbo].[LogEntry] DROP CONSTRAINT [FK_LogEntry_Application]
GO
/****** Object:  ForeignKey [FK_LogEntry_LogType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LogEntry_LogType]') AND parent_object_id = OBJECT_ID(N'[dbo].[LogEntry]'))
ALTER TABLE [dbo].[LogEntry] DROP CONSTRAINT [FK_LogEntry_LogType]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonAttributes]'))
ALTER TABLE [dbo].[PersonAttributes] DROP CONSTRAINT [FK_PersonAttributes_Effect]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_PersonRegistration]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonAttributes]'))
ALTER TABLE [dbo].[PersonAttributes] DROP CONSTRAINT [FK_PersonAttributes_PersonRegistration]
GO
/****** Object:  ForeignKey [FK_PersonCivilState_CivilStatusCodeType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonCivilState_CivilStatusCodeType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonCivilState]'))
ALTER TABLE [dbo].[PersonCivilState] DROP CONSTRAINT [FK_PersonCivilState_CivilStatusCodeType]
GO
/****** Object:  ForeignKey [FK_PersonCivilState_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonCivilState_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonCivilState]'))
ALTER TABLE [dbo].[PersonCivilState] DROP CONSTRAINT [FK_PersonCivilState_Effect]
GO
/****** Object:  ForeignKey [FK_PersonCivilState_PersonState]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonCivilState_PersonState]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonCivilState]'))
ALTER TABLE [dbo].[PersonCivilState] DROP CONSTRAINT [FK_PersonCivilState_PersonState]
GO
/****** Object:  ForeignKey [FK_PersonLifeState_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonLifeState_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonLifeState]'))
ALTER TABLE [dbo].[PersonLifeState] DROP CONSTRAINT [FK_PersonLifeState_Effect]
GO
/****** Object:  ForeignKey [FK_PersonLifeState_LifeStatusCodeType1]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonLifeState_LifeStatusCodeType1]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonLifeState]'))
ALTER TABLE [dbo].[PersonLifeState] DROP CONSTRAINT [FK_PersonLifeState_LifeStatusCodeType1]
GO
/****** Object:  ForeignKey [FK_PersonLifeState_PersonState]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonLifeState_PersonState]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonLifeState]'))
ALTER TABLE [dbo].[PersonLifeState] DROP CONSTRAINT [FK_PersonLifeState_PersonState]
GO
/****** Object:  ForeignKey [FK_PersonName_PersonProperties]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonName_PersonProperties]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonName]'))
ALTER TABLE [dbo].[PersonName] DROP CONSTRAINT [FK_PersonName_PersonProperties]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties] DROP CONSTRAINT [FK_PersonAttributes_Address]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_ContactChannel]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_ContactChannel]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties] DROP CONSTRAINT [FK_PersonAttributes_ContactChannel]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_ContactChannel1]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_ContactChannel1]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties] DROP CONSTRAINT [FK_PersonAttributes_ContactChannel1]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_Gender]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_Gender]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties] DROP CONSTRAINT [FK_PersonAttributes_Gender]
GO
/****** Object:  ForeignKey [FK_PersonProperties_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonProperties_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties] DROP CONSTRAINT [FK_PersonProperties_Effect]
GO
/****** Object:  ForeignKey [FK_PersonProperties_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonProperties_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties] DROP CONSTRAINT [FK_PersonProperties_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_PersonRegistration_ActorRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRegistration_ActorRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
ALTER TABLE [dbo].[PersonRegistration] DROP CONSTRAINT [FK_PersonRegistration_ActorRef]
GO
/****** Object:  ForeignKey [FK_PersonRegistration_LifecycleStatus]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRegistration_LifecycleStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
ALTER TABLE [dbo].[PersonRegistration] DROP CONSTRAINT [FK_PersonRegistration_LifecycleStatus]
GO
/****** Object:  ForeignKey [FK_PersonRegistration_Person]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRegistration_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
ALTER TABLE [dbo].[PersonRegistration] DROP CONSTRAINT [FK_PersonRegistration_Person]
GO
/****** Object:  ForeignKey [FK_PersonRelationship_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRelationship_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
ALTER TABLE [dbo].[PersonRelationship] DROP CONSTRAINT [FK_PersonRelationship_Effect]
GO
/****** Object:  ForeignKey [FK_PersonRelationship_PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRelationship_PersonRegistration]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
ALTER TABLE [dbo].[PersonRelationship] DROP CONSTRAINT [FK_PersonRelationship_PersonRegistration]
GO
/****** Object:  ForeignKey [FK_PersonRelationship_RelationshipType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRelationship_RelationshipType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
ALTER TABLE [dbo].[PersonRelationship] DROP CONSTRAINT [FK_PersonRelationship_RelationshipType]
GO
/****** Object:  ForeignKey [FK_PersonStates_PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonStates_PersonRegistration]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonState]'))
ALTER TABLE [dbo].[PersonState] DROP CONSTRAINT [FK_PersonStates_PersonRegistration]
GO
/****** Object:  ForeignKey [FK_UnknownCitizenData_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UnknownCitizenData_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[UnknownCitizenData]'))
ALTER TABLE [dbo].[UnknownCitizenData] DROP CONSTRAINT [FK_UnknownCitizenData_PersonAttributes]
GO
/****** Object:  Default [DF_ActorRef_ActorRefId]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ActorRef_ActorRefId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ActorRef]'))
Begin
ALTER TABLE [dbo].[ActorRef] DROP CONSTRAINT [DF_ActorRef_ActorRefId]

End
GO
/****** Object:  Default [DF_Address_AddressId]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Address_AddressId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Address]'))
Begin
ALTER TABLE [dbo].[Address] DROP CONSTRAINT [DF_Address_AddressId]

End
GO
/****** Object:  Default [DF_Application_ApplicationId]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Application_ApplicationId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Application]'))
Begin
ALTER TABLE [dbo].[Application] DROP CONSTRAINT [DF_Application_ApplicationId]

End
GO
/****** Object:  Default [DF_Application_IsApproved]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Application_IsApproved]') AND parent_object_id = OBJECT_ID(N'[dbo].[Application]'))
Begin
ALTER TABLE [dbo].[Application] DROP CONSTRAINT [DF_Application_IsApproved]

End
GO
/****** Object:  Default [DF_ContactChannel_ContactChannelId]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ContactChannel_ContactChannelId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactChannel]'))
Begin
ALTER TABLE [dbo].[ContactChannel] DROP CONSTRAINT [DF_ContactChannel_ContactChannelId]

End
GO
/****** Object:  Default [DF_CountryRef_CountryRefId]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_CountryRef_CountryRefId]') AND parent_object_id = OBJECT_ID(N'[dbo].[CountryRef]'))
Begin
ALTER TABLE [dbo].[CountryRef] DROP CONSTRAINT [DF_CountryRef_CountryRefId]

End
GO
/****** Object:  Default [DF_Person_UUID]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Person_UUID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person]'))
Begin
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [DF_Person_UUID]

End
GO
/****** Object:  Default [DF_PersonRegistration_PersonRegistrationId]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PersonRegistration_PersonRegistrationId]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
Begin
ALTER TABLE [dbo].[PersonRegistration] DROP CONSTRAINT [DF_PersonRegistration_PersonRegistrationId]

End
GO
/****** Object:  Default [DF_PersonRelationship_PersonRelationshipId]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PersonRelationship_PersonRelationshipId]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
Begin
ALTER TABLE [dbo].[PersonRelationship] DROP CONSTRAINT [DF_PersonRelationship_PersonRelationshipId]

End
GO
/****** Object:  Table [dbo].[PersonRelationship]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonRelationship]') AND type in (N'U'))
DROP TABLE [dbo].[PersonRelationship]
GO
/****** Object:  Table [dbo].[PersonLifeState]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonLifeState]') AND type in (N'U'))
DROP TABLE [dbo].[PersonLifeState]
GO
/****** Object:  Table [dbo].[PersonCivilState]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonCivilState]') AND type in (N'U'))
DROP TABLE [dbo].[PersonCivilState]
GO
/****** Object:  Table [dbo].[PersonState]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonState]') AND type in (N'U'))
DROP TABLE [dbo].[PersonState]
GO
/****** Object:  Table [dbo].[PersonName]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonName]') AND type in (N'U'))
DROP TABLE [dbo].[PersonName]
GO
/****** Object:  Table [dbo].[ForeignAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ForeignAddress]') AND type in (N'U'))
DROP TABLE [dbo].[ForeignAddress]
GO
/****** Object:  Table [dbo].[GreenlandicAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GreenlandicAddress]') AND type in (N'U'))
DROP TABLE [dbo].[GreenlandicAddress]
GO
/****** Object:  Table [dbo].[ForeignCitizenCountry]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ForeignCitizenCountry]') AND type in (N'U'))
DROP TABLE [dbo].[ForeignCitizenCountry]
GO
/****** Object:  Table [dbo].[GeographicCoorditaneTuple]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeographicCoorditaneTuple]') AND type in (N'U'))
DROP TABLE [dbo].[GeographicCoorditaneTuple]
GO
/****** Object:  Table [dbo].[HealthInformation]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HealthInformation]') AND type in (N'U'))
DROP TABLE [dbo].[HealthInformation]
GO
/****** Object:  Table [dbo].[CprData]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CprData]') AND type in (N'U'))
DROP TABLE [dbo].[CprData]
GO
/****** Object:  Table [dbo].[UnknownCitizenData]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UnknownCitizenData]') AND type in (N'U'))
DROP TABLE [dbo].[UnknownCitizenData]
GO
/****** Object:  Table [dbo].[ForeignCitizenData]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ForeignCitizenData]') AND type in (N'U'))
DROP TABLE [dbo].[ForeignCitizenData]
GO
/****** Object:  Table [dbo].[GeographicPointLocation]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeographicPointLocation]') AND type in (N'U'))
DROP TABLE [dbo].[GeographicPointLocation]
GO
/****** Object:  Table [dbo].[AddressPointStatus]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddressPointStatus]') AND type in (N'U'))
DROP TABLE [dbo].[AddressPointStatus]
GO
/****** Object:  Table [dbo].[AddressPoint]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddressPoint]') AND type in (N'U'))
DROP TABLE [dbo].[AddressPoint]
GO
/****** Object:  Table [dbo].[DanishAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DanishAddress]') AND type in (N'U'))
DROP TABLE [dbo].[DanishAddress]
GO
/****** Object:  Table [dbo].[DenmarkAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DenmarkAddress]') AND type in (N'U'))
DROP TABLE [dbo].[DenmarkAddress]
GO
/****** Object:  Table [dbo].[CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CountryRef]') AND type in (N'U'))
DROP TABLE [dbo].[CountryRef]
GO
/****** Object:  Table [dbo].[LogEntry]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LogEntry]') AND type in (N'U'))
DROP TABLE [dbo].[LogEntry]
GO
/****** Object:  Table [dbo].[PersonProperties]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonProperties]') AND type in (N'U'))
DROP TABLE [dbo].[PersonProperties]
GO
/****** Object:  Table [dbo].[PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[PersonAttributes]
GO
/****** Object:  Table [dbo].[PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonRegistration]') AND type in (N'U'))
DROP TABLE [dbo].[PersonRegistration]
GO
/****** Object:  Table [dbo].[Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Effect]') AND type in (N'U'))
DROP TABLE [dbo].[Effect]
GO
/****** Object:  Table [dbo].[ContactChannel]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactChannel]') AND type in (N'U'))
DROP TABLE [dbo].[ContactChannel]
GO
/****** Object:  Table [dbo].[ContactChannelType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactChannelType]') AND type in (N'U'))
DROP TABLE [dbo].[ContactChannelType]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Address]') AND type in (N'U'))
DROP TABLE [dbo].[Address]
GO
/****** Object:  Table [dbo].[RelationshipType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelationshipType]') AND type in (N'U'))
DROP TABLE [dbo].[RelationshipType]
GO
/****** Object:  Table [dbo].[Municipality]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Municipality]') AND type in (N'U'))
DROP TABLE [dbo].[Municipality]
GO
/****** Object:  Table [dbo].[CountrySchemeType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CountrySchemeType]') AND type in (N'U'))
DROP TABLE [dbo].[CountrySchemeType]
GO
/****** Object:  Table [dbo].[LifeStatusCodeType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LifeStatusCodeType]') AND type in (N'U'))
DROP TABLE [dbo].[LifeStatusCodeType]
GO
/****** Object:  Table [dbo].[CivilStatusCodeType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CivilStatusCodeType]') AND type in (N'U'))
DROP TABLE [dbo].[CivilStatusCodeType]
GO
/****** Object:  Table [dbo].[DataChangeEvent]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataChangeEvent]') AND type in (N'U'))
DROP TABLE [dbo].[DataChangeEvent]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
DROP TABLE [dbo].[Person]
GO
/****** Object:  Table [dbo].[CoordinateQualityType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CoordinateQualityType]') AND type in (N'U'))
DROP TABLE [dbo].[CoordinateQualityType]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
DROP TABLE [dbo].[Country]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Gender]') AND type in (N'U'))
DROP TABLE [dbo].[Gender]
GO
/****** Object:  Table [dbo].[ActorRef]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActorRef]') AND type in (N'U'))
DROP TABLE [dbo].[ActorRef]
GO
/****** Object:  Table [dbo].[DataProvider]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataProvider]') AND type in (N'U'))
DROP TABLE [dbo].[DataProvider]
GO
/****** Object:  Table [dbo].[PersonMapping]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PersonMapping]
GO
/****** Object:  Table [dbo].[LifecycleStatus]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LifecycleStatus]') AND type in (N'U'))
DROP TABLE [dbo].[LifecycleStatus]
GO
/****** Object:  Table [dbo].[Notification]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Notification]') AND type in (N'U'))
DROP TABLE [dbo].[Notification]
GO
/****** Object:  Table [dbo].[EventStatus]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EventStatus]') AND type in (N'U'))
DROP TABLE [dbo].[EventStatus]
GO
/****** Object:  Table [dbo].[LogType]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LogType]') AND type in (N'U'))
DROP TABLE [dbo].[LogType]
GO
/****** Object:  Table [dbo].[Application]    Script Date: 02/12/2011 19:13:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Application]') AND type in (N'U'))
DROP TABLE [dbo].[Application]
GO
/****** Object:  Role [cpr]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'cpr')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'cpr' AND type = 'R')
CREATE ROLE [cpr]

END
GO
/****** Object:  Table [dbo].[Application]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Application]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Application](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Token] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RegistrationDate] [datetime] NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[ApprovedDate] [datetime] NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[ApplicationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[LogType]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LogType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LogType](
	[LogTypeId] [int] NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_LogType] PRIMARY KEY CLUSTERED 
(
	[LogTypeId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[EventStatus]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EventStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EventStatus](
	[EventStatusId] [int] NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_EventStatus] PRIMARY KEY CLUSTERED 
(
	[EventStatusId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[Notification]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Notification]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Notification](
	[NotificationId] [uniqueidentifier] NOT NULL,
	[DueDate] [datetime] NULL,
	[CreationDate] [datetime] NULL,
	[HandlingDate] [datetime] NULL,
 CONSTRAINT [PK_Notification] PRIMARY KEY CLUSTERED 
(
	[NotificationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[LifecycleStatus]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LifecycleStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LifecycleStatus](
	[LifecycleStatusId] [int] NOT NULL,
	[LifecycleStatusName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_LifecycleStatus] PRIMARY KEY CLUSTERED 
(
	[LifecycleStatusId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonMapping]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonMapping](
	[UUID] [uniqueidentifier] NOT NULL,
	[CprNumber] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_PersonMapping] PRIMARY KEY CLUSTERED 
(
	[UUID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF),
 CONSTRAINT [IX_PersonMapping] UNIQUE NONCLUSTERED 
(
	[CprNumber] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[DataProvider]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataProvider]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataProvider](
	[DataProviderId] [uniqueidentifier] NOT NULL,
	[TypeName] [varchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ordinal] [int] NOT NULL,
	[Data] [image] NULL,
	[IsExternal] [bit] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
 CONSTRAINT [PK_DataProvider] PRIMARY KEY CLUSTERED 
(
	[DataProviderId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[ActorRef]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActorRef]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ActorRef](
	[ActorRefId] [uniqueidentifier] NOT NULL,
	[Type] [int] NOT NULL,
	[Value] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_ActorRef] PRIMARY KEY CLUSTERED 
(
	[ActorRefId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Gender]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Gender](
	[GenderId] [int] NOT NULL,
	[GenderName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[GenderId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[Country]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Country](
	[Alpha2Code] [varchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Alpha3Code] [varchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NumericCode] [int] NOT NULL,
	[CountryName] [nvarchar](60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DanishCountryName] [nvarchar](60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DanishCountryName2] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[KmdCode] [int] NULL,
	[KmdCode2] [int] NULL,
	[KmdCode3] [int] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Alpha2Code] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'Notes' , N'SCHEMA',N'dbo', N'TABLE',N'Country', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'Notes', @value=N'This is a list of iso3166 Standard Country Codes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Country'
GO
/****** Object:  Table [dbo].[CoordinateQualityType]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CoordinateQualityType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CoordinateQualityType](
	[Code] [char](1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_CoordinateQualityType] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[Person]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Person](
	[UUID] [uniqueidentifier] NOT NULL,
	[UserInterfaceKeyText] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Object] PRIMARY KEY CLUSTERED 
(
	[UUID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[DataChangeEvent]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataChangeEvent]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataChangeEvent](
	[DataChangeEventId] [uniqueidentifier] NOT NULL,
	[PersonUuid] [uniqueidentifier] NOT NULL,
	[ReceivedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_DataChangeEvent] PRIMARY KEY CLUSTERED 
(
	[DataChangeEventId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[CivilStatusCodeType]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CivilStatusCodeType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CivilStatusCodeType](
	[CivilStatusCodeTypeId] [int] NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_CivilStatusCodeType] PRIMARY KEY CLUSTERED 
(
	[CivilStatusCodeTypeId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[LifeStatusCodeType]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LifeStatusCodeType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LifeStatusCodeType](
	[LifeStatusCodeTypeId] [int] NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_LifeStatusCodeType] PRIMARY KEY CLUSTERED 
(
	[LifeStatusCodeTypeId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[CountrySchemeType]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CountrySchemeType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CountrySchemeType](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_CountrySchemeType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[Municipality]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Municipality]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Municipality](
	[MunicipalityCode] [varchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MunicipalityName] [nvarchar](24) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Municipality_1] PRIMARY KEY CLUSTERED 
(
	[MunicipalityCode] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[RelationshipType]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelationshipType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RelationshipType](
	[RelationshipTypeId] [int] NOT NULL,
	[ForwardName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_RelationshipType] PRIMARY KEY CLUSTERED 
(
	[RelationshipTypeId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[Address]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Address]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Address](
	[AddressId] [uniqueidentifier] NOT NULL,
	[Note] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsUnknown] [bit] NOT NULL,
 CONSTRAINT [PK_Address_1] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[ContactChannelType]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactChannelType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContactChannelType](
	[ContactChannelTypeId] [int] NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_ContactChannelType] PRIMARY KEY CLUSTERED 
(
	[ContactChannelTypeId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[ContactChannel]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactChannel]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContactChannel](
	[ContactChannelId] [uniqueidentifier] NOT NULL,
	[ContactChannelTypeId] [int] NOT NULL,
	[UsageLimits] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Value] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CanSendSms] [bit] NULL,
	[Note] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OtherNote] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_ContactChannel] PRIMARY KEY CLUSTERED 
(
	[ContactChannelId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[Effect]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Effect]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Effect](
	[EffectId] [uniqueidentifier] NOT NULL,
	[ActorRefId] [uniqueidentifier] NULL,
	[CommentText] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
 CONSTRAINT [PK_Effect] PRIMARY KEY CLUSTERED 
(
	[EffectId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonRegistration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonRegistration](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[UUID] [uniqueidentifier] NOT NULL,
	[ActorRefId] [uniqueidentifier] NULL,
	[RegistrationDate] [datetime] NOT NULL,
	[BrokerUpdateDate] [datetime] NOT NULL,
	[CommentText] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LifecycleStatusId] [int] NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonAttributes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonAttributes](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[EffectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_PersonAttributes_1] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonProperties]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonProperties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonProperties](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[NickName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NameNoteText] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddressingName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GenderId] [int] NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[BirthPlace] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[BirthRegistrationAuthority] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EffectId] [uniqueidentifier] NULL,
	[ContactChannelId] [uniqueidentifier] NULL,
	[NextOfKinContactChannelId] [uniqueidentifier] NULL,
	[OtherAddressId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_PersonAttributes] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[LogEntry]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LogEntry]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LogEntry](
	[LogEntryId] [uniqueidentifier] NOT NULL,
	[LogTypeId] [int] NOT NULL,
	[ApplicationId] [uniqueidentifier] NULL,
	[UserToken] [varchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UserId] [varchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MethodName] [varchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Text] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DataObjectType] [varchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DataObjectXml] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LogDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LogEntry] PRIMARY KEY CLUSTERED 
(
	[LogEntryId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CountryRef]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CountryRef](
	[CountryRefId] [uniqueidentifier] NOT NULL,
	[CountrySchemeTypeId] [int] NOT NULL,
	[Value] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_CountryRef] PRIMARY KEY CLUSTERED 
(
	[CountryRefId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[DenmarkAddress]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DenmarkAddress]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DenmarkAddress](
	[AddressId] [uniqueidentifier] NOT NULL,
	[SpecialRoadCode] [bit] NULL,
	[MunicipalityCode] [varchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StreetCode] [varchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MailDeliverySublocation] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StreetName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StreetNameForAddressing] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StreetBuildingIdentifier] [varchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FloorIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SuiteIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DistrictSubdivisionIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PostCodeIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DistrictName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CountryRefId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_DenmarkAddress] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[DanishAddress]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DanishAddress]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DanishAddress](
	[AddressId] [uniqueidentifier] NOT NULL,
	[AddressPointId] [uniqueidentifier] NULL,
	[SocialDistrict] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SchoolDistrict] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PostDistrict] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ParishDistrict] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ConstituencyDistrict] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PoliceDistrict] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PostOfficeBoxIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_DanishAddress] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[AddressPoint]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddressPoint]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AddressPoint](
	[AddressId] [uniqueidentifier] NOT NULL,
	[Identifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_AddressPoint] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[AddressPointStatus]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddressPointStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AddressPointStatus](
	[AddressId] [uniqueidentifier] NOT NULL,
	[RevisionDate] [datetime] NOT NULL,
	[ValidStartDate] [datetime] NULL,
	[ValidEndDate] [datetime] NULL,
	[CoordinateQualityTypeCode] [char](1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_AddressPointStatus] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[GeographicPointLocation]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeographicPointLocation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GeographicPointLocation](
	[AddressId] [uniqueidentifier] NOT NULL,
	[CrsIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_GeographicPointLocation] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[ForeignCitizenData]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ForeignCitizenData]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ForeignCitizenData](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[PersonIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CivilRegistrationReplacementIdentifier] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[BirthCountryRefId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ForeignCitizenData] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[UnknownCitizenData]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UnknownCitizenData]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UnknownCitizenData](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[CprNumber] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_UnknownCitizenData] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[CprData]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CprData]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CprData](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[CprNumber] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CprNumberValidity] [bit] NOT NULL,
	[NationalityCountryRefId] [uniqueidentifier] NULL,
	[NameAndAddressProtectionIndicator] [bit] NOT NULL,
	[TelephoneNumberProtection] [bit] NOT NULL,
	[ResearchProtection] [bit] NOT NULL,
	[AddressId] [uniqueidentifier] NULL,
	[AddressNote] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ChurchMember] [bit] NOT NULL,
 CONSTRAINT [PK_CprData] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[HealthInformation]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HealthInformation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HealthInformation](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[PhysicianName] [varchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PhysicianProviderNumber] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[HealthInsuranceGroupCode] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EffectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_HealthInformation] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[GeographicCoorditaneTuple]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeographicCoorditaneTuple]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GeographicCoorditaneTuple](
	[AddressId] [uniqueidentifier] NOT NULL,
	[Easting] [decimal](18, 4) NOT NULL,
	[Northing] [decimal](18, 4) NOT NULL,
	[Height] [decimal](18, 4) NULL,
 CONSTRAINT [PK_GeographicCoorditaneTuple] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[ForeignCitizenCountry]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ForeignCitizenCountry]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ForeignCitizenCountry](
	[ForeignCitizenCountryId] [uniqueidentifier] NOT NULL,
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[Ordinal] [int] NOT NULL,
	[IsNationality] [bit] NOT NULL,
	[CountryRefId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ForeignCitizenCountry] PRIMARY KEY CLUSTERED 
(
	[ForeignCitizenCountryId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF),
 CONSTRAINT [IX_ForeignCitizenCountry_Unique] UNIQUE NONCLUSTERED 
(
	[PersonRegistrationId] ASC,
	[IsNationality] ASC,
	[Ordinal] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[GreenlandicAddress]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GreenlandicAddress]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GreenlandicAddress](
	[AddressId] [uniqueidentifier] NOT NULL,
	[GreenlandBuildingIdentifierField] [varchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_GreenlandicAddress] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[ForeignAddress]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ForeignAddress]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ForeignAddress](
	[AddressId] [uniqueidentifier] NOT NULL,
	[FirstLine] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SecondLine] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ThirdLine] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FourthLine] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FifthLine] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LocationDescription] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CountryRefId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ForeignAddress] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonName]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonName]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonName](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MiddleName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LastName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_PersonName] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonState]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonState]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonState](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_PersonState] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonCivilState]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonCivilState]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonCivilState](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[CivilStatusCodeTypeId] [int] NOT NULL,
	[EffectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_PersonCivilState] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonLifeState]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonLifeState]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonLifeState](
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[LifeStatusCodeTypeId] [int] NOT NULL,
	[EffectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_PersonLifeState] PRIMARY KEY CLUSTERED 
(
	[PersonRegistrationId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Table [dbo].[PersonRelationship]    Script Date: 02/12/2011 19:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonRelationship]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonRelationship](
	[PersonRelationshipId] [uniqueidentifier] NOT NULL,
	[PersonRegistrationId] [uniqueidentifier] NOT NULL,
	[RelatedPersonUuid] [uniqueidentifier] NOT NULL,
	[RelationshipTypeId] [int] NOT NULL,
	[CommentText] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EffectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_PersonRelationship_1] PRIMARY KEY CLUSTERED 
(
	[PersonRelationshipId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF)
)
END
GO
/****** Object:  Default [DF_ActorRef_ActorRefId]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ActorRef_ActorRefId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ActorRef]'))
Begin
ALTER TABLE [dbo].[ActorRef] ADD  CONSTRAINT [DF_ActorRef_ActorRefId]  DEFAULT (newid()) FOR [ActorRefId]

End
GO
/****** Object:  Default [DF_Address_AddressId]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Address_AddressId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Address]'))
Begin
ALTER TABLE [dbo].[Address] ADD  CONSTRAINT [DF_Address_AddressId]  DEFAULT (newid()) FOR [AddressId]

End
GO
/****** Object:  Default [DF_Application_ApplicationId]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Application_ApplicationId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Application]'))
Begin
ALTER TABLE [dbo].[Application] ADD  CONSTRAINT [DF_Application_ApplicationId]  DEFAULT (newid()) FOR [ApplicationId]

End
GO
/****** Object:  Default [DF_Application_IsApproved]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Application_IsApproved]') AND parent_object_id = OBJECT_ID(N'[dbo].[Application]'))
Begin
ALTER TABLE [dbo].[Application] ADD  CONSTRAINT [DF_Application_IsApproved]  DEFAULT ((0)) FOR [IsApproved]

End
GO
/****** Object:  Default [DF_ContactChannel_ContactChannelId]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ContactChannel_ContactChannelId]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactChannel]'))
Begin
ALTER TABLE [dbo].[ContactChannel] ADD  CONSTRAINT [DF_ContactChannel_ContactChannelId]  DEFAULT (newid()) FOR [ContactChannelId]

End
GO
/****** Object:  Default [DF_CountryRef_CountryRefId]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_CountryRef_CountryRefId]') AND parent_object_id = OBJECT_ID(N'[dbo].[CountryRef]'))
Begin
ALTER TABLE [dbo].[CountryRef] ADD  CONSTRAINT [DF_CountryRef_CountryRefId]  DEFAULT (newid()) FOR [CountryRefId]

End
GO
/****** Object:  Default [DF_Person_UUID]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Person_UUID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person]'))
Begin
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_UUID]  DEFAULT (newid()) FOR [UUID]

End
GO
/****** Object:  Default [DF_PersonRegistration_PersonRegistrationId]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PersonRegistration_PersonRegistrationId]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
Begin
ALTER TABLE [dbo].[PersonRegistration] ADD  CONSTRAINT [DF_PersonRegistration_PersonRegistrationId]  DEFAULT (newid()) FOR [PersonRegistrationId]

End
GO
/****** Object:  Default [DF_PersonRelationship_PersonRelationshipId]    Script Date: 02/12/2011 19:13:15 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PersonRelationship_PersonRelationshipId]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
Begin
ALTER TABLE [dbo].[PersonRelationship] ADD  CONSTRAINT [DF_PersonRelationship_PersonRelationshipId]  DEFAULT (newid()) FOR [PersonRelationshipId]

End
GO
/****** Object:  ForeignKey [FK_AddressPoint_DanishAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AddressPoint_DanishAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[AddressPoint]'))
ALTER TABLE [dbo].[AddressPoint]  WITH CHECK ADD  CONSTRAINT [FK_AddressPoint_DanishAddress] FOREIGN KEY([AddressId])
REFERENCES [dbo].[DanishAddress] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AddressPoint] CHECK CONSTRAINT [FK_AddressPoint_DanishAddress]
GO
/****** Object:  ForeignKey [FK_AddressPointStatus_AddressPoint]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AddressPointStatus_AddressPoint]') AND parent_object_id = OBJECT_ID(N'[dbo].[AddressPointStatus]'))
ALTER TABLE [dbo].[AddressPointStatus]  WITH CHECK ADD  CONSTRAINT [FK_AddressPointStatus_AddressPoint] FOREIGN KEY([AddressId])
REFERENCES [dbo].[AddressPoint] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AddressPointStatus] CHECK CONSTRAINT [FK_AddressPointStatus_AddressPoint]
GO
/****** Object:  ForeignKey [FK_ContactChannel_ContactChannelType]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ContactChannel_ContactChannelType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ContactChannel]'))
ALTER TABLE [dbo].[ContactChannel]  WITH CHECK ADD  CONSTRAINT [FK_ContactChannel_ContactChannelType] FOREIGN KEY([ContactChannelTypeId])
REFERENCES [dbo].[ContactChannelType] ([ContactChannelTypeId])
GO
ALTER TABLE [dbo].[ContactChannel] CHECK CONSTRAINT [FK_ContactChannel_ContactChannelType]
GO
/****** Object:  ForeignKey [FK_CountryRef_CountrySchemeType]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CountryRef_CountrySchemeType]') AND parent_object_id = OBJECT_ID(N'[dbo].[CountryRef]'))
ALTER TABLE [dbo].[CountryRef]  WITH CHECK ADD  CONSTRAINT [FK_CountryRef_CountrySchemeType] FOREIGN KEY([CountrySchemeTypeId])
REFERENCES [dbo].[CountrySchemeType] ([Id])
GO
ALTER TABLE [dbo].[CountryRef] CHECK CONSTRAINT [FK_CountryRef_CountrySchemeType]
GO
/****** Object:  ForeignKey [FK_CprData_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CprData_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[CprData]'))
ALTER TABLE [dbo].[CprData]  WITH CHECK ADD  CONSTRAINT [FK_CprData_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
GO
ALTER TABLE [dbo].[CprData] CHECK CONSTRAINT [FK_CprData_Address]
GO
/****** Object:  ForeignKey [FK_CprData_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CprData_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[CprData]'))
ALTER TABLE [dbo].[CprData]  WITH CHECK ADD  CONSTRAINT [FK_CprData_CountryRef] FOREIGN KEY([NationalityCountryRefId])
REFERENCES [dbo].[CountryRef] ([CountryRefId])
GO
ALTER TABLE [dbo].[CprData] CHECK CONSTRAINT [FK_CprData_CountryRef]
GO
/****** Object:  ForeignKey [FK_CprData_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CprData_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[CprData]'))
ALTER TABLE [dbo].[CprData]  WITH CHECK ADD  CONSTRAINT [FK_CprData_PersonAttributes] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonAttributes] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CprData] CHECK CONSTRAINT [FK_CprData_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_DanishAddress_DenmarkAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DanishAddress_DenmarkAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[DanishAddress]'))
ALTER TABLE [dbo].[DanishAddress]  WITH CHECK ADD  CONSTRAINT [FK_DanishAddress_DenmarkAddress] FOREIGN KEY([AddressId])
REFERENCES [dbo].[DenmarkAddress] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DanishAddress] CHECK CONSTRAINT [FK_DanishAddress_DenmarkAddress]
GO
/****** Object:  ForeignKey [FK_DenmarkAddress_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DenmarkAddress_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[DenmarkAddress]'))
ALTER TABLE [dbo].[DenmarkAddress]  WITH CHECK ADD  CONSTRAINT [FK_DenmarkAddress_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DenmarkAddress] CHECK CONSTRAINT [FK_DenmarkAddress_Address]
GO
/****** Object:  ForeignKey [FK_DenmarkAddress_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DenmarkAddress_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[DenmarkAddress]'))
ALTER TABLE [dbo].[DenmarkAddress]  WITH CHECK ADD  CONSTRAINT [FK_DenmarkAddress_CountryRef] FOREIGN KEY([CountryRefId])
REFERENCES [dbo].[CountryRef] ([CountryRefId])
GO
ALTER TABLE [dbo].[DenmarkAddress] CHECK CONSTRAINT [FK_DenmarkAddress_CountryRef]
GO
/****** Object:  ForeignKey [FK_Effect_ActorRef]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Effect_ActorRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[Effect]'))
ALTER TABLE [dbo].[Effect]  WITH CHECK ADD  CONSTRAINT [FK_Effect_ActorRef] FOREIGN KEY([ActorRefId])
REFERENCES [dbo].[ActorRef] ([ActorRefId])
GO
ALTER TABLE [dbo].[Effect] CHECK CONSTRAINT [FK_Effect_ActorRef]
GO
/****** Object:  ForeignKey [FK_ForeignAddress_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignAddress_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignAddress]'))
ALTER TABLE [dbo].[ForeignAddress]  WITH CHECK ADD  CONSTRAINT [FK_ForeignAddress_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ForeignAddress] CHECK CONSTRAINT [FK_ForeignAddress_Address]
GO
/****** Object:  ForeignKey [FK_ForeignAddress_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignAddress_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignAddress]'))
ALTER TABLE [dbo].[ForeignAddress]  WITH CHECK ADD  CONSTRAINT [FK_ForeignAddress_CountryRef] FOREIGN KEY([CountryRefId])
REFERENCES [dbo].[CountryRef] ([CountryRefId])
GO
ALTER TABLE [dbo].[ForeignAddress] CHECK CONSTRAINT [FK_ForeignAddress_CountryRef]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenCountry_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenCountry_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenCountry]'))
ALTER TABLE [dbo].[ForeignCitizenCountry]  WITH CHECK ADD  CONSTRAINT [FK_ForeignCitizenCountry_CountryRef] FOREIGN KEY([CountryRefId])
REFERENCES [dbo].[CountryRef] ([CountryRefId])
GO
ALTER TABLE [dbo].[ForeignCitizenCountry] CHECK CONSTRAINT [FK_ForeignCitizenCountry_CountryRef]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenCountry_ForeignCitizenData]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenCountry_ForeignCitizenData]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenCountry]'))
ALTER TABLE [dbo].[ForeignCitizenCountry]  WITH CHECK ADD  CONSTRAINT [FK_ForeignCitizenCountry_ForeignCitizenData] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[ForeignCitizenData] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ForeignCitizenCountry] CHECK CONSTRAINT [FK_ForeignCitizenCountry_ForeignCitizenData]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenData_CountryRef]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenData_CountryRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenData]'))
ALTER TABLE [dbo].[ForeignCitizenData]  WITH CHECK ADD  CONSTRAINT [FK_ForeignCitizenData_CountryRef] FOREIGN KEY([BirthCountryRefId])
REFERENCES [dbo].[CountryRef] ([CountryRefId])
GO
ALTER TABLE [dbo].[ForeignCitizenData] CHECK CONSTRAINT [FK_ForeignCitizenData_CountryRef]
GO
/****** Object:  ForeignKey [FK_ForeignCitizenData_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ForeignCitizenData_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[ForeignCitizenData]'))
ALTER TABLE [dbo].[ForeignCitizenData]  WITH CHECK ADD  CONSTRAINT [FK_ForeignCitizenData_PersonAttributes] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonAttributes] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ForeignCitizenData] CHECK CONSTRAINT [FK_ForeignCitizenData_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_GeographicCoorditaneTuple_GeographicPointLocation]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GeographicCoorditaneTuple_GeographicPointLocation]') AND parent_object_id = OBJECT_ID(N'[dbo].[GeographicCoorditaneTuple]'))
ALTER TABLE [dbo].[GeographicCoorditaneTuple]  WITH CHECK ADD  CONSTRAINT [FK_GeographicCoorditaneTuple_GeographicPointLocation] FOREIGN KEY([AddressId])
REFERENCES [dbo].[GeographicPointLocation] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GeographicCoorditaneTuple] CHECK CONSTRAINT [FK_GeographicCoorditaneTuple_GeographicPointLocation]
GO
/****** Object:  ForeignKey [FK_GeographicPointLocation_AddressPoint]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GeographicPointLocation_AddressPoint]') AND parent_object_id = OBJECT_ID(N'[dbo].[GeographicPointLocation]'))
ALTER TABLE [dbo].[GeographicPointLocation]  WITH CHECK ADD  CONSTRAINT [FK_GeographicPointLocation_AddressPoint] FOREIGN KEY([AddressId])
REFERENCES [dbo].[AddressPoint] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GeographicPointLocation] CHECK CONSTRAINT [FK_GeographicPointLocation_AddressPoint]
GO
/****** Object:  ForeignKey [FK_GreenlandicAddress_DenmarkAddress]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GreenlandicAddress_DenmarkAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[GreenlandicAddress]'))
ALTER TABLE [dbo].[GreenlandicAddress]  WITH CHECK ADD  CONSTRAINT [FK_GreenlandicAddress_DenmarkAddress] FOREIGN KEY([AddressId])
REFERENCES [dbo].[DenmarkAddress] ([AddressId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GreenlandicAddress] CHECK CONSTRAINT [FK_GreenlandicAddress_DenmarkAddress]
GO
/****** Object:  ForeignKey [FK_HealthInformation_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HealthInformation_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[HealthInformation]'))
ALTER TABLE [dbo].[HealthInformation]  WITH CHECK ADD  CONSTRAINT [FK_HealthInformation_Effect] FOREIGN KEY([EffectId])
REFERENCES [dbo].[Effect] ([EffectId])
GO
ALTER TABLE [dbo].[HealthInformation] CHECK CONSTRAINT [FK_HealthInformation_Effect]
GO
/****** Object:  ForeignKey [FK_HealthInformation_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HealthInformation_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[HealthInformation]'))
ALTER TABLE [dbo].[HealthInformation]  WITH CHECK ADD  CONSTRAINT [FK_HealthInformation_PersonAttributes] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonAttributes] ([PersonRegistrationId])
GO
ALTER TABLE [dbo].[HealthInformation] CHECK CONSTRAINT [FK_HealthInformation_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_LogEntry_Application]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LogEntry_Application]') AND parent_object_id = OBJECT_ID(N'[dbo].[LogEntry]'))
ALTER TABLE [dbo].[LogEntry]  WITH NOCHECK ADD  CONSTRAINT [FK_LogEntry_Application] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[Application] ([ApplicationId])
GO
ALTER TABLE [dbo].[LogEntry] NOCHECK CONSTRAINT [FK_LogEntry_Application]
GO
/****** Object:  ForeignKey [FK_LogEntry_LogType]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LogEntry_LogType]') AND parent_object_id = OBJECT_ID(N'[dbo].[LogEntry]'))
ALTER TABLE [dbo].[LogEntry]  WITH CHECK ADD  CONSTRAINT [FK_LogEntry_LogType] FOREIGN KEY([LogTypeId])
REFERENCES [dbo].[LogType] ([LogTypeId])
GO
ALTER TABLE [dbo].[LogEntry] CHECK CONSTRAINT [FK_LogEntry_LogType]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonAttributes]'))
ALTER TABLE [dbo].[PersonAttributes]  WITH CHECK ADD  CONSTRAINT [FK_PersonAttributes_Effect] FOREIGN KEY([EffectId])
REFERENCES [dbo].[Effect] ([EffectId])
GO
ALTER TABLE [dbo].[PersonAttributes] CHECK CONSTRAINT [FK_PersonAttributes_Effect]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_PersonRegistration]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonAttributes]'))
ALTER TABLE [dbo].[PersonAttributes]  WITH CHECK ADD  CONSTRAINT [FK_PersonAttributes_PersonRegistration] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonRegistration] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonAttributes] CHECK CONSTRAINT [FK_PersonAttributes_PersonRegistration]
GO
/****** Object:  ForeignKey [FK_PersonCivilState_CivilStatusCodeType]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonCivilState_CivilStatusCodeType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonCivilState]'))
ALTER TABLE [dbo].[PersonCivilState]  WITH CHECK ADD  CONSTRAINT [FK_PersonCivilState_CivilStatusCodeType] FOREIGN KEY([CivilStatusCodeTypeId])
REFERENCES [dbo].[CivilStatusCodeType] ([CivilStatusCodeTypeId])
GO
ALTER TABLE [dbo].[PersonCivilState] CHECK CONSTRAINT [FK_PersonCivilState_CivilStatusCodeType]
GO
/****** Object:  ForeignKey [FK_PersonCivilState_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonCivilState_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonCivilState]'))
ALTER TABLE [dbo].[PersonCivilState]  WITH CHECK ADD  CONSTRAINT [FK_PersonCivilState_Effect] FOREIGN KEY([EffectId])
REFERENCES [dbo].[Effect] ([EffectId])
GO
ALTER TABLE [dbo].[PersonCivilState] CHECK CONSTRAINT [FK_PersonCivilState_Effect]
GO
/****** Object:  ForeignKey [FK_PersonCivilState_PersonState]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonCivilState_PersonState]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonCivilState]'))
ALTER TABLE [dbo].[PersonCivilState]  WITH CHECK ADD  CONSTRAINT [FK_PersonCivilState_PersonState] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonState] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonCivilState] CHECK CONSTRAINT [FK_PersonCivilState_PersonState]
GO
/****** Object:  ForeignKey [FK_PersonLifeState_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonLifeState_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonLifeState]'))
ALTER TABLE [dbo].[PersonLifeState]  WITH CHECK ADD  CONSTRAINT [FK_PersonLifeState_Effect] FOREIGN KEY([EffectId])
REFERENCES [dbo].[Effect] ([EffectId])
GO
ALTER TABLE [dbo].[PersonLifeState] CHECK CONSTRAINT [FK_PersonLifeState_Effect]
GO
/****** Object:  ForeignKey [FK_PersonLifeState_LifeStatusCodeType1]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonLifeState_LifeStatusCodeType1]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonLifeState]'))
ALTER TABLE [dbo].[PersonLifeState]  WITH CHECK ADD  CONSTRAINT [FK_PersonLifeState_LifeStatusCodeType1] FOREIGN KEY([LifeStatusCodeTypeId])
REFERENCES [dbo].[LifeStatusCodeType] ([LifeStatusCodeTypeId])
GO
ALTER TABLE [dbo].[PersonLifeState] CHECK CONSTRAINT [FK_PersonLifeState_LifeStatusCodeType1]
GO
/****** Object:  ForeignKey [FK_PersonLifeState_PersonState]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonLifeState_PersonState]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonLifeState]'))
ALTER TABLE [dbo].[PersonLifeState]  WITH CHECK ADD  CONSTRAINT [FK_PersonLifeState_PersonState] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonState] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonLifeState] CHECK CONSTRAINT [FK_PersonLifeState_PersonState]
GO
/****** Object:  ForeignKey [FK_PersonName_PersonProperties]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonName_PersonProperties]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonName]'))
ALTER TABLE [dbo].[PersonName]  WITH CHECK ADD  CONSTRAINT [FK_PersonName_PersonProperties] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonProperties] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonName] CHECK CONSTRAINT [FK_PersonName_PersonProperties]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_Address]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_Address]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties]  WITH CHECK ADD  CONSTRAINT [FK_PersonAttributes_Address] FOREIGN KEY([OtherAddressId])
REFERENCES [dbo].[Address] ([AddressId])
GO
ALTER TABLE [dbo].[PersonProperties] CHECK CONSTRAINT [FK_PersonAttributes_Address]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_ContactChannel]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_ContactChannel]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties]  WITH CHECK ADD  CONSTRAINT [FK_PersonAttributes_ContactChannel] FOREIGN KEY([ContactChannelId])
REFERENCES [dbo].[ContactChannel] ([ContactChannelId])
GO
ALTER TABLE [dbo].[PersonProperties] CHECK CONSTRAINT [FK_PersonAttributes_ContactChannel]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_ContactChannel1]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_ContactChannel1]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties]  WITH CHECK ADD  CONSTRAINT [FK_PersonAttributes_ContactChannel1] FOREIGN KEY([NextOfKinContactChannelId])
REFERENCES [dbo].[ContactChannel] ([ContactChannelId])
GO
ALTER TABLE [dbo].[PersonProperties] CHECK CONSTRAINT [FK_PersonAttributes_ContactChannel1]
GO
/****** Object:  ForeignKey [FK_PersonAttributes_Gender]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonAttributes_Gender]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties]  WITH CHECK ADD  CONSTRAINT [FK_PersonAttributes_Gender] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Gender] ([GenderId])
GO
ALTER TABLE [dbo].[PersonProperties] CHECK CONSTRAINT [FK_PersonAttributes_Gender]
GO
/****** Object:  ForeignKey [FK_PersonProperties_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonProperties_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties]  WITH CHECK ADD  CONSTRAINT [FK_PersonProperties_Effect] FOREIGN KEY([EffectId])
REFERENCES [dbo].[Effect] ([EffectId])
GO
ALTER TABLE [dbo].[PersonProperties] CHECK CONSTRAINT [FK_PersonProperties_Effect]
GO
/****** Object:  ForeignKey [FK_PersonProperties_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonProperties_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonProperties]'))
ALTER TABLE [dbo].[PersonProperties]  WITH CHECK ADD  CONSTRAINT [FK_PersonProperties_PersonAttributes] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonAttributes] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonProperties] CHECK CONSTRAINT [FK_PersonProperties_PersonAttributes]
GO
/****** Object:  ForeignKey [FK_PersonRegistration_ActorRef]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRegistration_ActorRef]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
ALTER TABLE [dbo].[PersonRegistration]  WITH CHECK ADD  CONSTRAINT [FK_PersonRegistration_ActorRef] FOREIGN KEY([ActorRefId])
REFERENCES [dbo].[ActorRef] ([ActorRefId])
GO
ALTER TABLE [dbo].[PersonRegistration] CHECK CONSTRAINT [FK_PersonRegistration_ActorRef]
GO
/****** Object:  ForeignKey [FK_PersonRegistration_LifecycleStatus]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRegistration_LifecycleStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
ALTER TABLE [dbo].[PersonRegistration]  WITH CHECK ADD  CONSTRAINT [FK_PersonRegistration_LifecycleStatus] FOREIGN KEY([LifecycleStatusId])
REFERENCES [dbo].[LifecycleStatus] ([LifecycleStatusId])
GO
ALTER TABLE [dbo].[PersonRegistration] CHECK CONSTRAINT [FK_PersonRegistration_LifecycleStatus]
GO
/****** Object:  ForeignKey [FK_PersonRegistration_Person]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRegistration_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRegistration]'))
ALTER TABLE [dbo].[PersonRegistration]  WITH CHECK ADD  CONSTRAINT [FK_PersonRegistration_Person] FOREIGN KEY([UUID])
REFERENCES [dbo].[Person] ([UUID])
GO
ALTER TABLE [dbo].[PersonRegistration] CHECK CONSTRAINT [FK_PersonRegistration_Person]
GO
/****** Object:  ForeignKey [FK_PersonRelationship_Effect]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRelationship_Effect]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
ALTER TABLE [dbo].[PersonRelationship]  WITH CHECK ADD  CONSTRAINT [FK_PersonRelationship_Effect] FOREIGN KEY([EffectId])
REFERENCES [dbo].[Effect] ([EffectId])
GO
ALTER TABLE [dbo].[PersonRelationship] CHECK CONSTRAINT [FK_PersonRelationship_Effect]
GO
/****** Object:  ForeignKey [FK_PersonRelationship_PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRelationship_PersonRegistration]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
ALTER TABLE [dbo].[PersonRelationship]  WITH CHECK ADD  CONSTRAINT [FK_PersonRelationship_PersonRegistration] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonRegistration] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonRelationship] CHECK CONSTRAINT [FK_PersonRelationship_PersonRegistration]
GO
/****** Object:  ForeignKey [FK_PersonRelationship_RelationshipType]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonRelationship_RelationshipType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonRelationship]'))
ALTER TABLE [dbo].[PersonRelationship]  WITH CHECK ADD  CONSTRAINT [FK_PersonRelationship_RelationshipType] FOREIGN KEY([RelationshipTypeId])
REFERENCES [dbo].[RelationshipType] ([RelationshipTypeId])
GO
ALTER TABLE [dbo].[PersonRelationship] CHECK CONSTRAINT [FK_PersonRelationship_RelationshipType]
GO
/****** Object:  ForeignKey [FK_PersonStates_PersonRegistration]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonStates_PersonRegistration]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonState]'))
ALTER TABLE [dbo].[PersonState]  WITH CHECK ADD  CONSTRAINT [FK_PersonStates_PersonRegistration] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonRegistration] ([PersonRegistrationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonState] CHECK CONSTRAINT [FK_PersonStates_PersonRegistration]
GO
/****** Object:  ForeignKey [FK_UnknownCitizenData_PersonAttributes]    Script Date: 02/12/2011 19:13:15 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UnknownCitizenData_PersonAttributes]') AND parent_object_id = OBJECT_ID(N'[dbo].[UnknownCitizenData]'))
ALTER TABLE [dbo].[UnknownCitizenData]  WITH CHECK ADD  CONSTRAINT [FK_UnknownCitizenData_PersonAttributes] FOREIGN KEY([PersonRegistrationId])
REFERENCES [dbo].[PersonAttributes] ([PersonRegistrationId])
GO
ALTER TABLE [dbo].[UnknownCitizenData] CHECK CONSTRAINT [FK_UnknownCitizenData_PersonAttributes]
GO
