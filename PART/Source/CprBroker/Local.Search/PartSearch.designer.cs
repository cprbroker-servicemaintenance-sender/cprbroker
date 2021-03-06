﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CprBroker.Providers.Local.Search
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CprBroker000")]
	public partial class PartSearchDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPersonSearchCache(PersonSearchCache instance);
    partial void UpdatePersonSearchCache(PersonSearchCache instance);
    partial void DeletePersonSearchCache(PersonSearchCache instance);
    #endregion
		
		public PartSearchDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PartSearchDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PartSearchDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PartSearchDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PersonSearchCache> PersonSearchCaches
		{
			get
			{
				return this.GetTable<PersonSearchCache>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PersonSearchCache")]
	public partial class PersonSearchCache : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<System.Guid> _PersonRegistrationId;
		
		private System.Guid _UUID;
		
		private string _LivscyklusKode;
		
		private string _AddressingName;
		
		private string _NickName;
		
		private string _Note;
		
		private string _PersonGivenName;
		
		private string _PersonMiddleName;
		
		private string _PersonSurnameName;
		
		private string _PersonGenderCode;
		
		private System.Nullable<System.DateTime> _Birthdate;
		
		private string _FoedestedNavn;
		
		private string _FoedselsregistreringMyndighedNavn;
		
		private string _UserInterfaceKeyText;
		
		private string _PersonCivilRegistrationIdentifier;
		
		private System.Nullable<bool> _PersonNummerGyldighedStatusIndikator;
		
		private string _PersonNationalityCode;
		
		private System.Nullable<bool> _NavneAdresseBeskyttelseIndikator;
		
		private System.Nullable<bool> _TelefonNummerBeskyttelseIndikator;
		
		private System.Nullable<bool> _ForskerBeskyttelseIndikator;
		
		private string _AdresseNoteTekst;
		
		private System.Nullable<bool> _FolkekirkeMedlemIndikator;
		
		private System.Nullable<char> _AddressType;
		
		private string _NoteTekst_DanskAdresse;
		
		private System.Nullable<bool> _UkendtAdresseIndikator;
		
		private System.Nullable<bool> _SpecielVejkodeIndikator;
		
		private string _PostDistriktTekst;
		
		private string _MunicipalityCode;
		
		private string _StreetCode;
		
		private string _StreetBuildingIdentifier;
		
		private string _MailDeliverySublocationIdentifier;
		
		private string _StreetName;
		
		private string _StreetNameForAddressingName;
		
		private string _StreetBuildingIdentifier_Postal;
		
		private string _FloorIdentifier;
		
		private string _SuiteIdentifier;
		
		private string _DistrictSubdivisionIdentifier;
		
		private string _PostOfficeBoxIdentifier;
		
		private string _PostCodeIdentifier;
		
		private string _DistrictName;
		
		private string _CountryIdentificationCode;
		
		private string _GreenlandBuildingIdentifier;
		
		private string _LocationDescriptionText;
		
		private string _PostalAddressFirstLineText;
		
		private string _PostalAddressSecondLineText;
		
		private string _PostalAddressThirdLineText;
		
		private string _PostalAddressFourthLineText;
		
		private string _PostalAddressFifthLineText;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonRegistrationIdChanging(System.Nullable<System.Guid> value);
    partial void OnPersonRegistrationIdChanged();
    partial void OnUUIDChanging(System.Guid value);
    partial void OnUUIDChanged();
    partial void OnLivscyklusKodeChanging(string value);
    partial void OnLivscyklusKodeChanged();
    partial void OnAddressingNameChanging(string value);
    partial void OnAddressingNameChanged();
    partial void OnNickNameChanging(string value);
    partial void OnNickNameChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    partial void OnPersonGivenNameChanging(string value);
    partial void OnPersonGivenNameChanged();
    partial void OnPersonMiddleNameChanging(string value);
    partial void OnPersonMiddleNameChanged();
    partial void OnPersonSurnameNameChanging(string value);
    partial void OnPersonSurnameNameChanged();
    partial void OnPersonGenderCodeChanging(string value);
    partial void OnPersonGenderCodeChanged();
    partial void OnBirthdateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdateChanged();
    partial void OnFoedestedNavnChanging(string value);
    partial void OnFoedestedNavnChanged();
    partial void OnFoedselsregistreringMyndighedNavnChanging(string value);
    partial void OnFoedselsregistreringMyndighedNavnChanged();
    partial void OnUserInterfaceKeyTextChanging(string value);
    partial void OnUserInterfaceKeyTextChanged();
    partial void OnPersonCivilRegistrationIdentifierChanging(string value);
    partial void OnPersonCivilRegistrationIdentifierChanged();
    partial void OnPersonNummerGyldighedStatusIndikatorChanging(System.Nullable<bool> value);
    partial void OnPersonNummerGyldighedStatusIndikatorChanged();
    partial void OnPersonNationalityCodeChanging(string value);
    partial void OnPersonNationalityCodeChanged();
    partial void OnNavneAdresseBeskyttelseIndikatorChanging(System.Nullable<bool> value);
    partial void OnNavneAdresseBeskyttelseIndikatorChanged();
    partial void OnTelefonNummerBeskyttelseIndikatorChanging(System.Nullable<bool> value);
    partial void OnTelefonNummerBeskyttelseIndikatorChanged();
    partial void OnForskerBeskyttelseIndikatorChanging(System.Nullable<bool> value);
    partial void OnForskerBeskyttelseIndikatorChanged();
    partial void OnAdresseNoteTekstChanging(string value);
    partial void OnAdresseNoteTekstChanged();
    partial void OnFolkekirkeMedlemIndikatorChanging(System.Nullable<bool> value);
    partial void OnFolkekirkeMedlemIndikatorChanged();
    partial void OnAddressTypeChanging(System.Nullable<char> value);
    partial void OnAddressTypeChanged();
    partial void OnNoteTekst_DanskAdresseChanging(string value);
    partial void OnNoteTekst_DanskAdresseChanged();
    partial void OnUkendtAdresseIndikatorChanging(System.Nullable<bool> value);
    partial void OnUkendtAdresseIndikatorChanged();
    partial void OnSpecielVejkodeIndikatorChanging(System.Nullable<bool> value);
    partial void OnSpecielVejkodeIndikatorChanged();
    partial void OnPostDistriktTekstChanging(string value);
    partial void OnPostDistriktTekstChanged();
    partial void OnMunicipalityCodeChanging(string value);
    partial void OnMunicipalityCodeChanged();
    partial void OnStreetCodeChanging(string value);
    partial void OnStreetCodeChanged();
    partial void OnStreetBuildingIdentifierChanging(string value);
    partial void OnStreetBuildingIdentifierChanged();
    partial void OnMailDeliverySublocationIdentifierChanging(string value);
    partial void OnMailDeliverySublocationIdentifierChanged();
    partial void OnStreetNameChanging(string value);
    partial void OnStreetNameChanged();
    partial void OnStreetNameForAddressingNameChanging(string value);
    partial void OnStreetNameForAddressingNameChanged();
    partial void OnStreetBuildingIdentifier_PostalChanging(string value);
    partial void OnStreetBuildingIdentifier_PostalChanged();
    partial void OnFloorIdentifierChanging(string value);
    partial void OnFloorIdentifierChanged();
    partial void OnSuiteIdentifierChanging(string value);
    partial void OnSuiteIdentifierChanged();
    partial void OnDistrictSubdivisionIdentifierChanging(string value);
    partial void OnDistrictSubdivisionIdentifierChanged();
    partial void OnPostOfficeBoxIdentifierChanging(string value);
    partial void OnPostOfficeBoxIdentifierChanged();
    partial void OnPostCodeIdentifierChanging(string value);
    partial void OnPostCodeIdentifierChanged();
    partial void OnDistrictNameChanging(string value);
    partial void OnDistrictNameChanged();
    partial void OnCountryIdentificationCodeChanging(string value);
    partial void OnCountryIdentificationCodeChanged();
    partial void OnGreenlandBuildingIdentifierChanging(string value);
    partial void OnGreenlandBuildingIdentifierChanged();
    partial void OnLocationDescriptionTextChanging(string value);
    partial void OnLocationDescriptionTextChanged();
    partial void OnPostalAddressFirstLineTextChanging(string value);
    partial void OnPostalAddressFirstLineTextChanged();
    partial void OnPostalAddressSecondLineTextChanging(string value);
    partial void OnPostalAddressSecondLineTextChanged();
    partial void OnPostalAddressThirdLineTextChanging(string value);
    partial void OnPostalAddressThirdLineTextChanged();
    partial void OnPostalAddressFourthLineTextChanging(string value);
    partial void OnPostalAddressFourthLineTextChanged();
    partial void OnPostalAddressFifthLineTextChanging(string value);
    partial void OnPostalAddressFifthLineTextChanged();
    #endregion
		
		public PersonSearchCache()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonRegistrationId", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> PersonRegistrationId
		{
			get
			{
				return this._PersonRegistrationId;
			}
			set
			{
				if ((this._PersonRegistrationId != value))
				{
					this.OnPersonRegistrationIdChanging(value);
					this.SendPropertyChanging();
					this._PersonRegistrationId = value;
					this.SendPropertyChanged("PersonRegistrationId");
					this.OnPersonRegistrationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UUID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UUID
		{
			get
			{
				return this._UUID;
			}
			set
			{
				if ((this._UUID != value))
				{
					this.OnUUIDChanging(value);
					this.SendPropertyChanging();
					this._UUID = value;
					this.SendPropertyChanged("UUID");
					this.OnUUIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LivscyklusKode", DbType="NVarChar(MAX)")]
		public string LivscyklusKode
		{
			get
			{
				return this._LivscyklusKode;
			}
			set
			{
				if ((this._LivscyklusKode != value))
				{
					this.OnLivscyklusKodeChanging(value);
					this.SendPropertyChanging();
					this._LivscyklusKode = value;
					this.SendPropertyChanged("LivscyklusKode");
					this.OnLivscyklusKodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressingName", DbType="NVarChar(MAX)")]
		public string AddressingName
		{
			get
			{
				return this._AddressingName;
			}
			set
			{
				if ((this._AddressingName != value))
				{
					this.OnAddressingNameChanging(value);
					this.SendPropertyChanging();
					this._AddressingName = value;
					this.SendPropertyChanged("AddressingName");
					this.OnAddressingNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NickName", DbType="NVarChar(MAX)")]
		public string NickName
		{
			get
			{
				return this._NickName;
			}
			set
			{
				if ((this._NickName != value))
				{
					this.OnNickNameChanging(value);
					this.SendPropertyChanging();
					this._NickName = value;
					this.SendPropertyChanged("NickName");
					this.OnNickNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="NVarChar(MAX)")]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonGivenName", DbType="NVarChar(MAX)")]
		public string PersonGivenName
		{
			get
			{
				return this._PersonGivenName;
			}
			set
			{
				if ((this._PersonGivenName != value))
				{
					this.OnPersonGivenNameChanging(value);
					this.SendPropertyChanging();
					this._PersonGivenName = value;
					this.SendPropertyChanged("PersonGivenName");
					this.OnPersonGivenNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonMiddleName", DbType="NVarChar(MAX)")]
		public string PersonMiddleName
		{
			get
			{
				return this._PersonMiddleName;
			}
			set
			{
				if ((this._PersonMiddleName != value))
				{
					this.OnPersonMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._PersonMiddleName = value;
					this.SendPropertyChanged("PersonMiddleName");
					this.OnPersonMiddleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonSurnameName", DbType="NVarChar(MAX)")]
		public string PersonSurnameName
		{
			get
			{
				return this._PersonSurnameName;
			}
			set
			{
				if ((this._PersonSurnameName != value))
				{
					this.OnPersonSurnameNameChanging(value);
					this.SendPropertyChanging();
					this._PersonSurnameName = value;
					this.SendPropertyChanged("PersonSurnameName");
					this.OnPersonSurnameNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonGenderCode", DbType="NVarChar(MAX)")]
		public string PersonGenderCode
		{
			get
			{
				return this._PersonGenderCode;
			}
			set
			{
				if ((this._PersonGenderCode != value))
				{
					this.OnPersonGenderCodeChanging(value);
					this.SendPropertyChanging();
					this._PersonGenderCode = value;
					this.SendPropertyChanged("PersonGenderCode");
					this.OnPersonGenderCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="DateTime")]
		public System.Nullable<System.DateTime> Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this.OnBirthdateChanging(value);
					this.SendPropertyChanging();
					this._Birthdate = value;
					this.SendPropertyChanged("Birthdate");
					this.OnBirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FoedestedNavn", DbType="NVarChar(MAX)")]
		public string FoedestedNavn
		{
			get
			{
				return this._FoedestedNavn;
			}
			set
			{
				if ((this._FoedestedNavn != value))
				{
					this.OnFoedestedNavnChanging(value);
					this.SendPropertyChanging();
					this._FoedestedNavn = value;
					this.SendPropertyChanged("FoedestedNavn");
					this.OnFoedestedNavnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FoedselsregistreringMyndighedNavn", DbType="NVarChar(MAX)")]
		public string FoedselsregistreringMyndighedNavn
		{
			get
			{
				return this._FoedselsregistreringMyndighedNavn;
			}
			set
			{
				if ((this._FoedselsregistreringMyndighedNavn != value))
				{
					this.OnFoedselsregistreringMyndighedNavnChanging(value);
					this.SendPropertyChanging();
					this._FoedselsregistreringMyndighedNavn = value;
					this.SendPropertyChanged("FoedselsregistreringMyndighedNavn");
					this.OnFoedselsregistreringMyndighedNavnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserInterfaceKeyText", DbType="NVarChar(MAX)")]
		public string UserInterfaceKeyText
		{
			get
			{
				return this._UserInterfaceKeyText;
			}
			set
			{
				if ((this._UserInterfaceKeyText != value))
				{
					this.OnUserInterfaceKeyTextChanging(value);
					this.SendPropertyChanging();
					this._UserInterfaceKeyText = value;
					this.SendPropertyChanged("UserInterfaceKeyText");
					this.OnUserInterfaceKeyTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonCivilRegistrationIdentifier", DbType="NVarChar(MAX)")]
		public string PersonCivilRegistrationIdentifier
		{
			get
			{
				return this._PersonCivilRegistrationIdentifier;
			}
			set
			{
				if ((this._PersonCivilRegistrationIdentifier != value))
				{
					this.OnPersonCivilRegistrationIdentifierChanging(value);
					this.SendPropertyChanging();
					this._PersonCivilRegistrationIdentifier = value;
					this.SendPropertyChanged("PersonCivilRegistrationIdentifier");
					this.OnPersonCivilRegistrationIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonNummerGyldighedStatusIndikator", DbType="Bit")]
		public System.Nullable<bool> PersonNummerGyldighedStatusIndikator
		{
			get
			{
				return this._PersonNummerGyldighedStatusIndikator;
			}
			set
			{
				if ((this._PersonNummerGyldighedStatusIndikator != value))
				{
					this.OnPersonNummerGyldighedStatusIndikatorChanging(value);
					this.SendPropertyChanging();
					this._PersonNummerGyldighedStatusIndikator = value;
					this.SendPropertyChanged("PersonNummerGyldighedStatusIndikator");
					this.OnPersonNummerGyldighedStatusIndikatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonNationalityCode", DbType="NVarChar(MAX)")]
		public string PersonNationalityCode
		{
			get
			{
				return this._PersonNationalityCode;
			}
			set
			{
				if ((this._PersonNationalityCode != value))
				{
					this.OnPersonNationalityCodeChanging(value);
					this.SendPropertyChanging();
					this._PersonNationalityCode = value;
					this.SendPropertyChanged("PersonNationalityCode");
					this.OnPersonNationalityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NavneAdresseBeskyttelseIndikator", DbType="Bit")]
		public System.Nullable<bool> NavneAdresseBeskyttelseIndikator
		{
			get
			{
				return this._NavneAdresseBeskyttelseIndikator;
			}
			set
			{
				if ((this._NavneAdresseBeskyttelseIndikator != value))
				{
					this.OnNavneAdresseBeskyttelseIndikatorChanging(value);
					this.SendPropertyChanging();
					this._NavneAdresseBeskyttelseIndikator = value;
					this.SendPropertyChanged("NavneAdresseBeskyttelseIndikator");
					this.OnNavneAdresseBeskyttelseIndikatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelefonNummerBeskyttelseIndikator", DbType="Bit")]
		public System.Nullable<bool> TelefonNummerBeskyttelseIndikator
		{
			get
			{
				return this._TelefonNummerBeskyttelseIndikator;
			}
			set
			{
				if ((this._TelefonNummerBeskyttelseIndikator != value))
				{
					this.OnTelefonNummerBeskyttelseIndikatorChanging(value);
					this.SendPropertyChanging();
					this._TelefonNummerBeskyttelseIndikator = value;
					this.SendPropertyChanged("TelefonNummerBeskyttelseIndikator");
					this.OnTelefonNummerBeskyttelseIndikatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ForskerBeskyttelseIndikator", DbType="Bit")]
		public System.Nullable<bool> ForskerBeskyttelseIndikator
		{
			get
			{
				return this._ForskerBeskyttelseIndikator;
			}
			set
			{
				if ((this._ForskerBeskyttelseIndikator != value))
				{
					this.OnForskerBeskyttelseIndikatorChanging(value);
					this.SendPropertyChanging();
					this._ForskerBeskyttelseIndikator = value;
					this.SendPropertyChanged("ForskerBeskyttelseIndikator");
					this.OnForskerBeskyttelseIndikatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdresseNoteTekst", DbType="NVarChar(MAX)")]
		public string AdresseNoteTekst
		{
			get
			{
				return this._AdresseNoteTekst;
			}
			set
			{
				if ((this._AdresseNoteTekst != value))
				{
					this.OnAdresseNoteTekstChanging(value);
					this.SendPropertyChanging();
					this._AdresseNoteTekst = value;
					this.SendPropertyChanged("AdresseNoteTekst");
					this.OnAdresseNoteTekstChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FolkekirkeMedlemIndikator", DbType="Bit")]
		public System.Nullable<bool> FolkekirkeMedlemIndikator
		{
			get
			{
				return this._FolkekirkeMedlemIndikator;
			}
			set
			{
				if ((this._FolkekirkeMedlemIndikator != value))
				{
					this.OnFolkekirkeMedlemIndikatorChanging(value);
					this.SendPropertyChanging();
					this._FolkekirkeMedlemIndikator = value;
					this.SendPropertyChanged("FolkekirkeMedlemIndikator");
					this.OnFolkekirkeMedlemIndikatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressType", DbType="Char(1)")]
		public System.Nullable<char> AddressType
		{
			get
			{
				return this._AddressType;
			}
			set
			{
				if ((this._AddressType != value))
				{
					this.OnAddressTypeChanging(value);
					this.SendPropertyChanging();
					this._AddressType = value;
					this.SendPropertyChanged("AddressType");
					this.OnAddressTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoteTekst_DanskAdresse", DbType="NVarChar(MAX)")]
		public string NoteTekst_DanskAdresse
		{
			get
			{
				return this._NoteTekst_DanskAdresse;
			}
			set
			{
				if ((this._NoteTekst_DanskAdresse != value))
				{
					this.OnNoteTekst_DanskAdresseChanging(value);
					this.SendPropertyChanging();
					this._NoteTekst_DanskAdresse = value;
					this.SendPropertyChanged("NoteTekst_DanskAdresse");
					this.OnNoteTekst_DanskAdresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UkendtAdresseIndikator", DbType="Bit")]
		public System.Nullable<bool> UkendtAdresseIndikator
		{
			get
			{
				return this._UkendtAdresseIndikator;
			}
			set
			{
				if ((this._UkendtAdresseIndikator != value))
				{
					this.OnUkendtAdresseIndikatorChanging(value);
					this.SendPropertyChanging();
					this._UkendtAdresseIndikator = value;
					this.SendPropertyChanged("UkendtAdresseIndikator");
					this.OnUkendtAdresseIndikatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SpecielVejkodeIndikator", DbType="Bit")]
		public System.Nullable<bool> SpecielVejkodeIndikator
		{
			get
			{
				return this._SpecielVejkodeIndikator;
			}
			set
			{
				if ((this._SpecielVejkodeIndikator != value))
				{
					this.OnSpecielVejkodeIndikatorChanging(value);
					this.SendPropertyChanging();
					this._SpecielVejkodeIndikator = value;
					this.SendPropertyChanged("SpecielVejkodeIndikator");
					this.OnSpecielVejkodeIndikatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostDistriktTekst", DbType="NVarChar(MAX)")]
		public string PostDistriktTekst
		{
			get
			{
				return this._PostDistriktTekst;
			}
			set
			{
				if ((this._PostDistriktTekst != value))
				{
					this.OnPostDistriktTekstChanging(value);
					this.SendPropertyChanging();
					this._PostDistriktTekst = value;
					this.SendPropertyChanged("PostDistriktTekst");
					this.OnPostDistriktTekstChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MunicipalityCode", DbType="NVarChar(MAX)")]
		public string MunicipalityCode
		{
			get
			{
				return this._MunicipalityCode;
			}
			set
			{
				if ((this._MunicipalityCode != value))
				{
					this.OnMunicipalityCodeChanging(value);
					this.SendPropertyChanging();
					this._MunicipalityCode = value;
					this.SendPropertyChanged("MunicipalityCode");
					this.OnMunicipalityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetCode", DbType="NVarChar(MAX)")]
		public string StreetCode
		{
			get
			{
				return this._StreetCode;
			}
			set
			{
				if ((this._StreetCode != value))
				{
					this.OnStreetCodeChanging(value);
					this.SendPropertyChanging();
					this._StreetCode = value;
					this.SendPropertyChanged("StreetCode");
					this.OnStreetCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetBuildingIdentifier", DbType="NVarChar(MAX)")]
		public string StreetBuildingIdentifier
		{
			get
			{
				return this._StreetBuildingIdentifier;
			}
			set
			{
				if ((this._StreetBuildingIdentifier != value))
				{
					this.OnStreetBuildingIdentifierChanging(value);
					this.SendPropertyChanging();
					this._StreetBuildingIdentifier = value;
					this.SendPropertyChanged("StreetBuildingIdentifier");
					this.OnStreetBuildingIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailDeliverySublocationIdentifier", DbType="NVarChar(MAX)")]
		public string MailDeliverySublocationIdentifier
		{
			get
			{
				return this._MailDeliverySublocationIdentifier;
			}
			set
			{
				if ((this._MailDeliverySublocationIdentifier != value))
				{
					this.OnMailDeliverySublocationIdentifierChanging(value);
					this.SendPropertyChanging();
					this._MailDeliverySublocationIdentifier = value;
					this.SendPropertyChanged("MailDeliverySublocationIdentifier");
					this.OnMailDeliverySublocationIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetName", DbType="NVarChar(MAX)")]
		public string StreetName
		{
			get
			{
				return this._StreetName;
			}
			set
			{
				if ((this._StreetName != value))
				{
					this.OnStreetNameChanging(value);
					this.SendPropertyChanging();
					this._StreetName = value;
					this.SendPropertyChanged("StreetName");
					this.OnStreetNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetNameForAddressingName", DbType="NVarChar(MAX)")]
		public string StreetNameForAddressingName
		{
			get
			{
				return this._StreetNameForAddressingName;
			}
			set
			{
				if ((this._StreetNameForAddressingName != value))
				{
					this.OnStreetNameForAddressingNameChanging(value);
					this.SendPropertyChanging();
					this._StreetNameForAddressingName = value;
					this.SendPropertyChanged("StreetNameForAddressingName");
					this.OnStreetNameForAddressingNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetBuildingIdentifier_Postal", DbType="NVarChar(MAX)")]
		public string StreetBuildingIdentifier_Postal
		{
			get
			{
				return this._StreetBuildingIdentifier_Postal;
			}
			set
			{
				if ((this._StreetBuildingIdentifier_Postal != value))
				{
					this.OnStreetBuildingIdentifier_PostalChanging(value);
					this.SendPropertyChanging();
					this._StreetBuildingIdentifier_Postal = value;
					this.SendPropertyChanged("StreetBuildingIdentifier_Postal");
					this.OnStreetBuildingIdentifier_PostalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FloorIdentifier", DbType="NVarChar(MAX)")]
		public string FloorIdentifier
		{
			get
			{
				return this._FloorIdentifier;
			}
			set
			{
				if ((this._FloorIdentifier != value))
				{
					this.OnFloorIdentifierChanging(value);
					this.SendPropertyChanging();
					this._FloorIdentifier = value;
					this.SendPropertyChanged("FloorIdentifier");
					this.OnFloorIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuiteIdentifier", DbType="NVarChar(MAX)")]
		public string SuiteIdentifier
		{
			get
			{
				return this._SuiteIdentifier;
			}
			set
			{
				if ((this._SuiteIdentifier != value))
				{
					this.OnSuiteIdentifierChanging(value);
					this.SendPropertyChanging();
					this._SuiteIdentifier = value;
					this.SendPropertyChanged("SuiteIdentifier");
					this.OnSuiteIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DistrictSubdivisionIdentifier", DbType="NVarChar(MAX)")]
		public string DistrictSubdivisionIdentifier
		{
			get
			{
				return this._DistrictSubdivisionIdentifier;
			}
			set
			{
				if ((this._DistrictSubdivisionIdentifier != value))
				{
					this.OnDistrictSubdivisionIdentifierChanging(value);
					this.SendPropertyChanging();
					this._DistrictSubdivisionIdentifier = value;
					this.SendPropertyChanged("DistrictSubdivisionIdentifier");
					this.OnDistrictSubdivisionIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostOfficeBoxIdentifier", DbType="NVarChar(MAX)")]
		public string PostOfficeBoxIdentifier
		{
			get
			{
				return this._PostOfficeBoxIdentifier;
			}
			set
			{
				if ((this._PostOfficeBoxIdentifier != value))
				{
					this.OnPostOfficeBoxIdentifierChanging(value);
					this.SendPropertyChanging();
					this._PostOfficeBoxIdentifier = value;
					this.SendPropertyChanged("PostOfficeBoxIdentifier");
					this.OnPostOfficeBoxIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostCodeIdentifier", DbType="NVarChar(MAX)")]
		public string PostCodeIdentifier
		{
			get
			{
				return this._PostCodeIdentifier;
			}
			set
			{
				if ((this._PostCodeIdentifier != value))
				{
					this.OnPostCodeIdentifierChanging(value);
					this.SendPropertyChanging();
					this._PostCodeIdentifier = value;
					this.SendPropertyChanged("PostCodeIdentifier");
					this.OnPostCodeIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DistrictName", DbType="NVarChar(MAX)")]
		public string DistrictName
		{
			get
			{
				return this._DistrictName;
			}
			set
			{
				if ((this._DistrictName != value))
				{
					this.OnDistrictNameChanging(value);
					this.SendPropertyChanging();
					this._DistrictName = value;
					this.SendPropertyChanged("DistrictName");
					this.OnDistrictNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryIdentificationCode", DbType="NVarChar(MAX)")]
		public string CountryIdentificationCode
		{
			get
			{
				return this._CountryIdentificationCode;
			}
			set
			{
				if ((this._CountryIdentificationCode != value))
				{
					this.OnCountryIdentificationCodeChanging(value);
					this.SendPropertyChanging();
					this._CountryIdentificationCode = value;
					this.SendPropertyChanged("CountryIdentificationCode");
					this.OnCountryIdentificationCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GreenlandBuildingIdentifier", DbType="NVarChar(MAX)")]
		public string GreenlandBuildingIdentifier
		{
			get
			{
				return this._GreenlandBuildingIdentifier;
			}
			set
			{
				if ((this._GreenlandBuildingIdentifier != value))
				{
					this.OnGreenlandBuildingIdentifierChanging(value);
					this.SendPropertyChanging();
					this._GreenlandBuildingIdentifier = value;
					this.SendPropertyChanged("GreenlandBuildingIdentifier");
					this.OnGreenlandBuildingIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationDescriptionText", DbType="NVarChar(MAX)")]
		public string LocationDescriptionText
		{
			get
			{
				return this._LocationDescriptionText;
			}
			set
			{
				if ((this._LocationDescriptionText != value))
				{
					this.OnLocationDescriptionTextChanging(value);
					this.SendPropertyChanging();
					this._LocationDescriptionText = value;
					this.SendPropertyChanged("LocationDescriptionText");
					this.OnLocationDescriptionTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressFirstLineText", DbType="NVarChar(MAX)")]
		public string PostalAddressFirstLineText
		{
			get
			{
				return this._PostalAddressFirstLineText;
			}
			set
			{
				if ((this._PostalAddressFirstLineText != value))
				{
					this.OnPostalAddressFirstLineTextChanging(value);
					this.SendPropertyChanging();
					this._PostalAddressFirstLineText = value;
					this.SendPropertyChanged("PostalAddressFirstLineText");
					this.OnPostalAddressFirstLineTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressSecondLineText", DbType="NVarChar(MAX)")]
		public string PostalAddressSecondLineText
		{
			get
			{
				return this._PostalAddressSecondLineText;
			}
			set
			{
				if ((this._PostalAddressSecondLineText != value))
				{
					this.OnPostalAddressSecondLineTextChanging(value);
					this.SendPropertyChanging();
					this._PostalAddressSecondLineText = value;
					this.SendPropertyChanged("PostalAddressSecondLineText");
					this.OnPostalAddressSecondLineTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressThirdLineText", DbType="NVarChar(MAX)")]
		public string PostalAddressThirdLineText
		{
			get
			{
				return this._PostalAddressThirdLineText;
			}
			set
			{
				if ((this._PostalAddressThirdLineText != value))
				{
					this.OnPostalAddressThirdLineTextChanging(value);
					this.SendPropertyChanging();
					this._PostalAddressThirdLineText = value;
					this.SendPropertyChanged("PostalAddressThirdLineText");
					this.OnPostalAddressThirdLineTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressFourthLineText", DbType="NVarChar(MAX)")]
		public string PostalAddressFourthLineText
		{
			get
			{
				return this._PostalAddressFourthLineText;
			}
			set
			{
				if ((this._PostalAddressFourthLineText != value))
				{
					this.OnPostalAddressFourthLineTextChanging(value);
					this.SendPropertyChanging();
					this._PostalAddressFourthLineText = value;
					this.SendPropertyChanged("PostalAddressFourthLineText");
					this.OnPostalAddressFourthLineTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressFifthLineText", DbType="NVarChar(MAX)")]
		public string PostalAddressFifthLineText
		{
			get
			{
				return this._PostalAddressFifthLineText;
			}
			set
			{
				if ((this._PostalAddressFifthLineText != value))
				{
					this.OnPostalAddressFifthLineTextChanging(value);
					this.SendPropertyChanging();
					this._PostalAddressFifthLineText = value;
					this.SendPropertyChanged("PostalAddressFifthLineText");
					this.OnPostalAddressFifthLineTextChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
