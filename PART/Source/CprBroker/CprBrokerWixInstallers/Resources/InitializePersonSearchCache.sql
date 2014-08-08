﻿-- =============================================
-- Procedure:   InitializePersonSearchCache
-- Author:		Beemen Beshara
-- Create date: 24-Jan-2014
-- Description:	Initializes the cashed version of persons' searchable fields
-- =============================================
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'InitializePersonSearchCache')
    DROP PROCEDURE dbo.InitializePersonSearchCache
GO

CREATE PROCEDURE [dbo].[InitializePersonSearchCache]
    @UUID UNIQUEIDENTIFIER, 
    @PersonRegistrationId UNIQUEIDENTIFIER, 
    @RegistrationDate DATETIME, 
    @Contents XML
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Determine if this is the latest registration
    -- If not, quit
    IF EXISTS (
        SELECT PersonRegistrationId 
        FROM PersonRegistration 
        WHERE 
            UUID = @UUID 
            AND RegistrationDate > @RegistrationDate
        )
    BEGIN
        RETURN
    END
        
    -------------------
    -- Root variables
    -------------------
    DECLARE @ContentsTable Table (X XML)
    DECLARE @LivscyklusKode VARCHAR(MAX);
    DECLARE @EgenskabNode XML, @RegisterOplysningNode XML;
    
    INSERT INTO @ContentsTable SELECT @Contents;

    WITH XMLNAMESPACES(
        'urn:oio:sagdok:person:1.0.0' as ns0,
        'urn:oio:sagdok:2.0.0' as ns1 )
    SELECT 
        @EgenskabNode = X.query('(/ns0:Registrering/ns0:AttributListe/ns0:Egenskab[ns1:Virkning/ns1:TilTidspunkt/ns1:GraenseIndikator])'),
        @RegisterOplysningNode = X.query('(/ns0:Registrering/ns0:AttributListe/ns0:RegisterOplysning[ns1:Virkning/ns1:TilTidspunkt/ns1:GraenseIndikator])'),
        @LivscyklusKode = X.value('(/ns0:Registrering/ns1:LivscyklusKode)[last()]','varchar(max)')
    FROM 
        @ContentsTable

    --------------
    -- Egenskab --
    --------------
    DECLARE @AddressingName VARCHAR(MAX), @NickName VARCHAR(MAX), @Note VARCHAR(MAX), 
        @PersonGivenName VARCHAR(MAX), @PersonMiddleName VARCHAR(MAX), @PersonSurnameName VARCHAR(MAX), 
        @PersonGenderCode VARCHAR(MAX), @Birthdate VARCHAR(MAX)

    IF LEN (CAST (@EgenskabNode AS VARCHAR(MAX))) > 0
    BEGIN	
        DECLARE @EgenskabTable TABLE (X XML);
        INSERT INTO @EgenskabTable SELECT @EgenskabNode;
    
        WITH XMLNAMESPACES (
            'urn:oio:sagdok:person:1.0.0' as ns0,
            'http://rep.oio.dk/itst.dk/xml/schemas/2005/02/22/' as ns1,
            'urn:oio:sagdok:2.0.0' as ns2,
            'http://rep.oio.dk/itst.dk/xml/schemas/2006/01/17/' as ns3,
            'http://rep.oio.dk/ebxml/xml/schemas/dkcc/2003/02/13/' as ns4,
            'http://rep.oio.dk/ebxml/xml/schemas/dkcc/2006/01/23/' as ns5,
            'http://rep.oio.dk/ebxml/xml/schemas/dkcc/2005/03/15/' as ns6) 
        SELECT 
            @AddressingName = X.value('(/ns0:Egenskab/ns0:NavnStruktur/ns1:PersonNameForAddressingName)[last()]','varchar(max)'),
            @NickName = X.value('(/ns0:Egenskab/ns0:NavnStruktur/ns2:KaldenavnTekst)[last()]','varchar(max)'),
            @Note = X.value('(/ns0:Egenskab/ns0:NavnStruktur/ns2:NoteTekst)[last()]','varchar(max)'),		
            @PersonGivenName = X.value('(/ns0:Egenskab/ns0:NavnStruktur/ns3:PersonNameStructure/ns4:PersonGivenName)[last()]','varchar(max)'),
            @PersonMiddleName = X.value('(/ns0:Egenskab/ns0:NavnStruktur/ns3:PersonNameStructure/ns4:PersonMiddleName)[last()]','varchar(max)'),
            @PersonSurnameName = X.value('(/ns0:Egenskab/ns0:NavnStruktur/ns3:PersonNameStructure/ns4:PersonSurnameName)[last()]','varchar(max)'),
            @PersonGenderCode = X.value('(/ns0:Egenskab/ns5:PersonGenderCode)[last()]','varchar(max)'),
            @Birthdate = X.value('(/ns0:Egenskab/ns6:BirthDate)[last()]','varchar(max)')
        FROM 
            @EgenskabTable
    END

    -----------------------
    -- RegisterOplysning --
    -----------------------

    -- CprBorger fields
    DECLARE @UserInterfaceKeyText VARCHAR(MAX), @PersonCivilRegistrationIdentifier VARCHAR(max),
        @PersonNummerGyldighedStatusIndikator VARCHAR(MAX), @PersonNationalityCode VARCHAR(MAX),
        @NavneAdresseBeskyttelseIndikator VARCHAR(MAX),@TelefonNummerBeskyttelseIndikator VARCHAR(MAX), @ForskerBeskyttelseIndikator VARCHAR(MAX);
        
    -- FolkeregisterAdresse fields
    DECLARE @NoteTekst_DanskAdresse VARCHAR(MAX), @UkendtAdresseIndikator VARCHAR(MAX), 
        @SpecielVejkodeIndikator VARCHAR(MAX), @PostDistriktTekst VARCHAR(MAX);
    
    -- AddressAccess fields
    DECLARE @MunicipalityCode VARCHAR(MAX), @StreetCode VARCHAR(MAX), @StreetBuildingIdentifier VARCHAR(MAX);
    
    -- AddressPostal fields
    DECLARE @MailDeliverySublocationIdentifier VARCHAR(MAX),
        @StreetName VARCHAR(MAX), @StreetNameForAddressingName VARCHAR(MAX), 
        @StreetBuildingIdentifier_Postal VARCHAR(MAX), @FloorIdentifier VARCHAR(MAX), @SuiteIdentifier VARCHAR(MAX), 
        @DistrictSubdivisionIdentifier VARCHAR(MAX), @PostOfficeBoxIdentifier VARCHAR(MAX), 
        @PostCodeIdentifier VARCHAR(MAX), @DistrictName VARCHAR(MAX), 
        @CountryIdentificationCode VARCHAR(MAX);
        
    -- CprBorger fields - after address
    DECLARE @AdresseNoteTekst VARCHAR(MAX), @FolkekirkeMedlemIndikator VARCHAR(MAX); 

    IF LEN (CAST (@RegisterOplysningNode AS VARCHAR(MAX))) > 0
    BEGIN	
        DECLARE @RegisterOplysningTable TABLE (X XML);
        INSERT INTO @RegisterOplysningTable SELECT @RegisterOplysningNode;
    
        WITH XMLNAMESPACES (
            'urn:oio:sagdok:person:1.0.0' as ns0,
            'http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/03/18/' as ns1,
            'http://rep.oio.dk/ebxml/xml/schemas/dkcc/2006/01/03/' as ns2)
        SELECT
            @UserInterfaceKeyText = X.value('(/ns0:RegisterOplysning/ns0:CprBorger/ns1:PersonCivilRegistrationIdentifier)[last()]','varchar(max)'),
            @PersonCivilRegistrationIdentifier = X.value('(/ns0:RegisterOplysning/ns0:CprBorger/ns1:PersonCivilRegistrationIdentifier)[last()]','varchar(max)'),
            @PersonNummerGyldighedStatusIndikator = X.value('(/ns0:RegisterOplysning/ns0:CprBorger/ns1:PersonCivilRegistrationIdentifier)[last()]','varchar(max)'),
            @PersonNationalityCode = X.value('(/ns0:RegisterOplysning/ns0:CprBorger/ns2:PersonNationalityCode)[last()]','varchar(max)'),
            @NavneAdresseBeskyttelseIndikator = X.value('(/ns0:RegisterOplysning/ns0:CprBorger/ns0:NavneAdresseBeskyttelseIndikator)[last()]','varchar(max)'),
            @TelefonNummerBeskyttelseIndikator = X.value('(/ns0:RegisterOplysning/ns0:CprBorger/ns0:TelefonNummerBeskyttelseIndikator)[last()]','varchar(max)'),
            @ForskerBeskyttelseIndikator = X.value('(/ns0:RegisterOplysning/ns0:CprBorger/ns0:ForskerBeskyttelseIndikator)[last()]','varchar(max)')
        FROM @RegisterOplysningTable;
        
        DECLARE @DanskAdresseTable TABLE(X XML);
        WITH XMLNAMESPACES ('urn:oio:sagdok:person:1.0.0' as ns0)
        INSERT INTO @DanskAdresseTable SELECT X.query('/ns0:RegisterOplysning/ns0:CprBorger/ns0:FolkeregisterAdresse/ns0:DanskAdresse') FROM @RegisterOplysningTable;
        
        WITH XMLNAMESPACES (
            'urn:oio:sagdok:person:1.0.0' as ns0,
            'urn:oio:sagdok:2.0.0' AS ns1)
        SELECT 
            @NoteTekst_DanskAdresse  = X.value('(/ns0:DanskAdresse/ns1:NoteTekst)[last()]'               , 'varchar(max)'),
            @UkendtAdresseIndikator  = X.value('(/ns0:DanskAdresse/ns0:UkendtAdresseIndikator)[last()]'  , 'varchar(max)'),
            @SpecielVejkodeIndikator = X.value('(/ns0:DanskAdresse/ns0:SpecielVejkodeIndikator)[last()]' , 'varchar(max)'),
            @PostDistriktTekst       = X.value('(/ns0:DanskAdresse/ns0:PostDistriktTekst)[last()]'       , 'varchar(max)')
        FROM @DanskAdresseTable;
        
        -- AddressAccess
        WITH XMLNAMESPACES (
            'urn:oio:sagdok:person:1.0.0' as ns0,
            'http://rep.oio.dk/xkom.dk/xml/schemas/2006/01/06/' AS ns1,
            'http://rep.oio.dk/xkom.dk/xml/schemas/2005/03/15/' as ns2,
            'http://rep.oio.dk/cpr.dk/xml/schemas/core/2005/03/18/' as ns3,            
            'http://rep.oio.dk/ebxml/xml/schemas/dkcc/2003/02/13/' as ns4 )
        SELECT
            @MunicipalityCode         = X.value('(/ns2:AddressAccess/ns3:MunicipalityCode)[last()]'         , 'varchar(max)'),
            @StreetCode               = X.value('(/ns2:AddressAccess/ns3:StreetCode)[last()]'               , 'varchar(max)'),
            @StreetBuildingIdentifier = X.value('(/ns2:AddressAccess/ns4:StreetBuildingIdentifier)[last()]' , 'varchar(max)')
        FROM 
            (SELECT X.query('/ns0:DanskAdresse/ns1:AddressComplete/ns2:AddressAccess') FROM @DanskAdresseTable) AS tmp_AddressPostalTable(X)
       
    END
    

    -----------------------------
    -- INSERT OR UPDATE RECORD --
    -----------------------------
    IF EXISTS (SELECT UUID FROM PersonSearchCache WHERE UUID = @UUID)
    BEGIN			
        UPDATE PersonSearchCache 
        SET PersonRegistrationId = @PersonRegistrationId, LivscyklusKode = @LivscyklusKode,	
            AddressingName = @AddressingName, NickName = @NickName, Note = @Note, 
            PersonGivenName = @PersonGivenName, PersonMiddleName = @PersonMiddleName, PersonSurnameName = @PersonSurnameName, 
            PersonGenderCode = @PersonGenderCode, Birthdate = @Birthdate,
            UserInterfaceKeyText = @UserInterfaceKeyText
        WHERE 
            UUID = @UUID
    END
    ELSE
    BEGIN
        INSERT INTO PersonSearchCache (
            UUID, PersonRegistrationId, LivscyklusKode, 
            AddressingName, NickName, Note, 
            PersonGivenName, PersonMiddleName, PersonSurnameName, 
            PersonGenderCode, Birthdate, 
            UserInterfaceKeyText)
        VALUES (@UUID, @PersonRegistrationId, @LivscyklusKode, 
            @AddressingName, @NickName, @Note, 
            @PersonGivenName, @PersonMiddleName, @PersonSurnameName, 
            @PersonGenderCode, @Birthdate, 
            @UserInterfaceKeyText)	    	        
    END
END
GO