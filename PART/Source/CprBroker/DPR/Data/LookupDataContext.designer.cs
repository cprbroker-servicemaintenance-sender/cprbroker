﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CprBroker.Providers.DPR
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DPR")]
	public partial class LookupDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LookupDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LookupDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LookupDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LookupDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PostDistrict> PostDistricts
		{
			get
			{
				return this.GetTable<PostDistrict>();
			}
		}
		
		public System.Data.Linq.Table<Street> Streets
		{
			get
			{
				return this.GetTable<Street>();
			}
		}
		
		public System.Data.Linq.Table<City> Cities
		{
			get
			{
				return this.GetTable<City>();
			}
		}
		
		public System.Data.Linq.Table<AreaRestorationDistrict> AreaRestorationDistricts
		{
			get
			{
				return this.GetTable<AreaRestorationDistrict>();
			}
		}
		
		public System.Data.Linq.Table<DiverseDistrict> DiverseDistricts
		{
			get
			{
				return this.GetTable<DiverseDistrict>();
			}
		}
		
		public System.Data.Linq.Table<ChurchAdministrationDistrict> ChurchAdministrationDistricts
		{
			get
			{
				return this.GetTable<ChurchAdministrationDistrict>();
			}
		}
		
		public System.Data.Linq.Table<PopulationDistrict> PopulationDistricts
		{
			get
			{
				return this.GetTable<PopulationDistrict>();
			}
		}
		
		public System.Data.Linq.Table<EvacuationDistrict> EvacuationDistricts
		{
			get
			{
				return this.GetTable<EvacuationDistrict>();
			}
		}
		
		public System.Data.Linq.Table<SchoolDistrict> SchoolDistricts
		{
			get
			{
				return this.GetTable<SchoolDistrict>();
			}
		}
		
		public System.Data.Linq.Table<SocialDistrict> SocialDistricts
		{
			get
			{
				return this.GetTable<SocialDistrict>();
			}
		}
		
		public System.Data.Linq.Table<ChurchDistrict> ChurchDistricts
		{
			get
			{
				return this.GetTable<ChurchDistrict>();
			}
		}
		
		public System.Data.Linq.Table<ElectionDistrict> ElectionDistricts
		{
			get
			{
				return this.GetTable<ElectionDistrict>();
			}
		}
		
		public System.Data.Linq.Table<HeatingDistrict> HeatingDistricts
		{
			get
			{
				return this.GetTable<HeatingDistrict>();
			}
		}
		
		public System.Data.Linq.Table<PostNumber> PostNumbers
		{
			get
			{
				return this.GetTable<PostNumber>();
			}
		}
		
		public System.Data.Linq.Table<Council> Councils
		{
			get
			{
				return this.GetTable<Council>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTPOSTDIST")]
	public partial class PostDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _POSTNR;
		
		private string _DISTTXT;
		
		public PostDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_POSTNR", DbType="Decimal(4,0) NOT NULL")]
		public decimal POSTNR
		{
			get
			{
				return this._POSTNR;
			}
			set
			{
				if ((this._POSTNR != value))
				{
					this._POSTNR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTAKTVEJ")]
	public partial class Street
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _VEJADNVN;
		
		private string _SVEJADRNVN;
		
		public Street()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJADNVN", DbType="VarChar(20)")]
		public string VEJADNVN
		{
			get
			{
				return this._VEJADNVN;
			}
			set
			{
				if ((this._VEJADNVN != value))
				{
					this._VEJADNVN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SVEJADRNVN", DbType="Char(20)")]
		public string SVEJADRNVN
		{
			get
			{
				return this._SVEJADRNVN;
			}
			set
			{
				if ((this._SVEJADRNVN != value))
				{
					this._SVEJADRNVN = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTBYNAVN")]
	public partial class City
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private string _BYNVN;
		
		public City()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BYNVN", DbType="VarChar(34) NOT NULL", CanBeNull=false)]
		public string BYNVN
		{
			get
			{
				return this._BYNVN;
			}
			set
			{
				if ((this._BYNVN != value))
				{
					this._BYNVN = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTBYFORNYDIST")]
	public partial class AreaRestorationDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private string _BYFORNYKOD;
		
		private string _DISTTXT;
		
		public AreaRestorationDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BYFORNYKOD", DbType="Char(6) NOT NULL", CanBeNull=false)]
		public string BYFORNYKOD
		{
			get
			{
				return this._BYFORNYKOD;
			}
			set
			{
				if ((this._BYFORNYKOD != value))
				{
					this._BYFORNYKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTDIVDIST")]
	public partial class DiverseDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _DISTTYP;
		
		private string _DIVDISTKOD;
		
		private string _DISTTXT;
		
		public DiverseDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTYP", DbType="Decimal(2,0) NOT NULL")]
		public decimal DISTTYP
		{
			get
			{
				return this._DISTTYP;
			}
			set
			{
				if ((this._DISTTYP != value))
				{
					this._DISTTYP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIVDISTKOD", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string DIVDISTKOD
		{
			get
			{
				return this._DIVDISTKOD;
			}
			set
			{
				if ((this._DIVDISTKOD != value))
				{
					this._DIVDISTKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTSOGNEDIST")]
	public partial class ChurchAdministrationDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _MYNKOD;
		
		public ChurchAdministrationDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MYNKOD", DbType="Decimal(4,0) NOT NULL")]
		public decimal MYNKOD
		{
			get
			{
				return this._MYNKOD;
			}
			set
			{
				if ((this._MYNKOD != value))
				{
					this._MYNKOD = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTBEFOLKDIST")]
	public partial class PopulationDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private string _BEFOLKKOD;
		
		private string _DISTTXT;
		
		public PopulationDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BEFOLKKOD", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string BEFOLKKOD
		{
			get
			{
				return this._BEFOLKKOD;
			}
			set
			{
				if ((this._BEFOLKKOD != value))
				{
					this._BEFOLKKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTEVAKUERDIST")]
	public partial class EvacuationDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _EVAKUERKOD;
		
		private string _DISTTXT;
		
		public EvacuationDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVAKUERKOD", DbType="Decimal(1,0) NOT NULL")]
		public decimal EVAKUERKOD
		{
			get
			{
				return this._EVAKUERKOD;
			}
			set
			{
				if ((this._EVAKUERKOD != value))
				{
					this._EVAKUERKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTSKOLEDIST")]
	public partial class SchoolDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _SKOLEKOD;
		
		private string _DISTTXT;
		
		public SchoolDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKOLEKOD", DbType="Decimal(2,0) NOT NULL")]
		public decimal SKOLEKOD
		{
			get
			{
				return this._SKOLEKOD;
			}
			set
			{
				if ((this._SKOLEKOD != value))
				{
					this._SKOLEKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTSOCIALDIST")]
	public partial class SocialDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _SOCIALKOD;
		
		private string _DISTTXT;
		
		public SocialDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOCIALKOD", DbType="Decimal(2,0) NOT NULL")]
		public decimal SOCIALKOD
		{
			get
			{
				return this._SOCIALKOD;
			}
			set
			{
				if ((this._SOCIALKOD != value))
				{
					this._SOCIALKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTKIRKEDIST")]
	public partial class ChurchDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _KIRKEKOD;
		
		private string _DISTTXT;
		
		public ChurchDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KIRKEKOD", DbType="Decimal(2,0) NOT NULL")]
		public decimal KIRKEKOD
		{
			get
			{
				return this._KIRKEKOD;
			}
			set
			{
				if ((this._KIRKEKOD != value))
				{
					this._KIRKEKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTVALGDIST")]
	public partial class ElectionDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _VALGKOD;
		
		private string _DISTTXT;
		
		public ElectionDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VALGKOD", DbType="Decimal(2,0) NOT NULL")]
		public decimal VALGKOD
		{
			get
			{
				return this._VALGKOD;
			}
			set
			{
				if ((this._VALGKOD != value))
				{
					this._VALGKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTVARMEDIST")]
	public partial class HeatingDistrict
	{
		
		private decimal _KOMKOD;
		
		private decimal _VEJKOD;
		
		private string _HUSNRFRA;
		
		private string _HUSNRTIL;
		
		private char _LIGEULIGE;
		
		private decimal _AJFDTO;
		
		private decimal _VARMEKOD;
		
		private string _DISTTXT;
		
		public HeatingDistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOMKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal KOMKOD
		{
			get
			{
				return this._KOMKOD;
			}
			set
			{
				if ((this._KOMKOD != value))
				{
					this._KOMKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEJKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal VEJKOD
		{
			get
			{
				return this._VEJKOD;
			}
			set
			{
				if ((this._VEJKOD != value))
				{
					this._VEJKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRFRA", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRFRA
		{
			get
			{
				return this._HUSNRFRA;
			}
			set
			{
				if ((this._HUSNRFRA != value))
				{
					this._HUSNRFRA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HUSNRTIL", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string HUSNRTIL
		{
			get
			{
				return this._HUSNRTIL;
			}
			set
			{
				if ((this._HUSNRTIL != value))
				{
					this._HUSNRTIL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LIGEULIGE", DbType="Char(1) NOT NULL")]
		public char LIGEULIGE
		{
			get
			{
				return this._LIGEULIGE;
			}
			set
			{
				if ((this._LIGEULIGE != value))
				{
					this._LIGEULIGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AJFDTO", DbType="Decimal(13,0) NOT NULL")]
		public decimal AJFDTO
		{
			get
			{
				return this._AJFDTO;
			}
			set
			{
				if ((this._AJFDTO != value))
				{
					this._AJFDTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VARMEKOD", DbType="Decimal(4,0) NOT NULL")]
		public decimal VARMEKOD
		{
			get
			{
				return this._VARMEKOD;
			}
			set
			{
				if ((this._VARMEKOD != value))
				{
					this._VARMEKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISTTXT", DbType="VarChar(30)")]
		public string DISTTXT
		{
			get
			{
				return this._DISTTXT;
			}
			set
			{
				if ((this._DISTTXT != value))
				{
					this._DISTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTPOSTNR")]
	public partial class PostNumber
	{
		
		private decimal _POSTNR;
		
		private string _POSTTXT;
		
		public PostNumber()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_POSTNR", DbType="Decimal(5,0) NOT NULL")]
		public decimal POSTNR
		{
			get
			{
				return this._POSTNR;
			}
			set
			{
				if ((this._POSTNR != value))
				{
					this._POSTNR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_POSTTXT", DbType="VarChar(20)")]
		public string POSTTXT
		{
			get
			{
				return this._POSTTXT;
			}
			set
			{
				if ((this._POSTTXT != value))
				{
					this._POSTTXT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DTMYN")]
	public partial class Council
	{
		
		private decimal _MYNKOD;
		
		private decimal _MYNTYP;
		
		private decimal _MYNGRP;
		
		private string _MYNNVN;
		
		public Council()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MYNKOD", DbType="Decimal(5,0) NOT NULL")]
		public decimal MYNKOD
		{
			get
			{
				return this._MYNKOD;
			}
			set
			{
				if ((this._MYNKOD != value))
				{
					this._MYNKOD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MYNTYP", DbType="Decimal(3,0) NOT NULL")]
		public decimal MYNTYP
		{
			get
			{
				return this._MYNTYP;
			}
			set
			{
				if ((this._MYNTYP != value))
				{
					this._MYNTYP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MYNGRP", DbType="Decimal(1,0) NOT NULL")]
		public decimal MYNGRP
		{
			get
			{
				return this._MYNGRP;
			}
			set
			{
				if ((this._MYNGRP != value))
				{
					this._MYNGRP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MYNNVN", DbType="VarChar(20)")]
		public string MYNNVN
		{
			get
			{
				return this._MYNNVN;
			}
			set
			{
				if ((this._MYNNVN != value))
				{
					this._MYNNVN = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
