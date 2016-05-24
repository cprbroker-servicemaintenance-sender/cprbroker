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

namespace CprBroker.Providers.CPRDirect
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PART")]
	public partial class ExtractDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertExtract(Extract instance);
    partial void UpdateExtract(Extract instance);
    partial void DeleteExtract(Extract instance);
    partial void InsertExtractItem(ExtractItem instance);
    partial void UpdateExtractItem(ExtractItem instance);
    partial void DeleteExtractItem(ExtractItem instance);
    partial void InsertExtractPersonStaging(ExtractPersonStaging instance);
    partial void UpdateExtractPersonStaging(ExtractPersonStaging instance);
    partial void DeleteExtractPersonStaging(ExtractPersonStaging instance);
    partial void InsertExtractError(ExtractError instance);
    partial void UpdateExtractError(ExtractError instance);
    partial void DeleteExtractError(ExtractError instance);
    #endregion
		
		public ExtractDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ExtractDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ExtractDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ExtractDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Extract> Extracts
		{
			get
			{
				return this.GetTable<Extract>();
			}
		}
		
		public System.Data.Linq.Table<ExtractItem> ExtractItems
		{
			get
			{
				return this.GetTable<ExtractItem>();
			}
		}
		
		public System.Data.Linq.Table<ExtractPersonStaging> ExtractPersonStagings
		{
			get
			{
				return this.GetTable<ExtractPersonStaging>();
			}
		}
		
		public System.Data.Linq.Table<ExtractError> ExtractErrors
		{
			get
			{
				return this.GetTable<ExtractError>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Extract")]
	public partial class Extract : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ExtractId;
		
		private string _Filename;
		
		private System.DateTime _ExtractDate;
		
		private System.DateTime _ImportDate;
		
		private string _StartRecord;
		
		private string _EndRecord;
		
		private bool _Ready;
		
		private System.Nullable<long> _ProcessedLines;
		
		private System.Nullable<System.Guid> _SemaphoreId;
		
		private EntitySet<ExtractItem> _ExtractItems;
		
		private EntitySet<ExtractPersonStaging> _ExtractPersonStagings;
		
		private EntitySet<ExtractError> _ExtractErrors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExtractIdChanging(System.Guid value);
    partial void OnExtractIdChanged();
    partial void OnFilenameChanging(string value);
    partial void OnFilenameChanged();
    partial void OnExtractDateChanging(System.DateTime value);
    partial void OnExtractDateChanged();
    partial void OnImportDateChanging(System.DateTime value);
    partial void OnImportDateChanged();
    partial void OnStartRecordChanging(string value);
    partial void OnStartRecordChanged();
    partial void OnEndRecordChanging(string value);
    partial void OnEndRecordChanged();
    partial void OnReadyChanging(bool value);
    partial void OnReadyChanged();
    partial void OnProcessedLinesChanging(System.Nullable<long> value);
    partial void OnProcessedLinesChanged();
    partial void OnSemaphoreIdChanging(System.Nullable<System.Guid> value);
    partial void OnSemaphoreIdChanged();
    #endregion
		
		public Extract()
		{
			this._ExtractItems = new EntitySet<ExtractItem>(new Action<ExtractItem>(this.attach_ExtractItems), new Action<ExtractItem>(this.detach_ExtractItems));
			this._ExtractPersonStagings = new EntitySet<ExtractPersonStaging>(new Action<ExtractPersonStaging>(this.attach_ExtractPersonStagings), new Action<ExtractPersonStaging>(this.detach_ExtractPersonStagings));
			this._ExtractErrors = new EntitySet<ExtractError>(new Action<ExtractError>(this.attach_ExtractErrors), new Action<ExtractError>(this.detach_ExtractErrors));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ExtractId
		{
			get
			{
				return this._ExtractId;
			}
			set
			{
				if ((this._ExtractId != value))
				{
					this.OnExtractIdChanging(value);
					this.SendPropertyChanging();
					this._ExtractId = value;
					this.SendPropertyChanged("ExtractId");
					this.OnExtractIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Filename", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Filename
		{
			get
			{
				return this._Filename;
			}
			set
			{
				if ((this._Filename != value))
				{
					this.OnFilenameChanging(value);
					this.SendPropertyChanging();
					this._Filename = value;
					this.SendPropertyChanged("Filename");
					this.OnFilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractDate", DbType="DateTime NOT NULL")]
		public System.DateTime ExtractDate
		{
			get
			{
				return this._ExtractDate;
			}
			set
			{
				if ((this._ExtractDate != value))
				{
					this.OnExtractDateChanging(value);
					this.SendPropertyChanging();
					this._ExtractDate = value;
					this.SendPropertyChanged("ExtractDate");
					this.OnExtractDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImportDate", DbType="DateTime NOT NULL")]
		public System.DateTime ImportDate
		{
			get
			{
				return this._ImportDate;
			}
			set
			{
				if ((this._ImportDate != value))
				{
					this.OnImportDateChanging(value);
					this.SendPropertyChanging();
					this._ImportDate = value;
					this.SendPropertyChanged("ImportDate");
					this.OnImportDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartRecord", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string StartRecord
		{
			get
			{
				return this._StartRecord;
			}
			set
			{
				if ((this._StartRecord != value))
				{
					this.OnStartRecordChanging(value);
					this.SendPropertyChanging();
					this._StartRecord = value;
					this.SendPropertyChanged("StartRecord");
					this.OnStartRecordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndRecord", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string EndRecord
		{
			get
			{
				return this._EndRecord;
			}
			set
			{
				if ((this._EndRecord != value))
				{
					this.OnEndRecordChanging(value);
					this.SendPropertyChanging();
					this._EndRecord = value;
					this.SendPropertyChanged("EndRecord");
					this.OnEndRecordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ready", DbType="BIT")]
		public bool Ready
		{
			get
			{
				return this._Ready;
			}
			set
			{
				if ((this._Ready != value))
				{
					this.OnReadyChanging(value);
					this.SendPropertyChanging();
					this._Ready = value;
					this.SendPropertyChanged("Ready");
					this.OnReadyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProcessedLines", DbType="BIGINT NULL")]
		public System.Nullable<long> ProcessedLines
		{
			get
			{
				return this._ProcessedLines;
			}
			set
			{
				if ((this._ProcessedLines != value))
				{
					this.OnProcessedLinesChanging(value);
					this.SendPropertyChanging();
					this._ProcessedLines = value;
					this.SendPropertyChanged("ProcessedLines");
					this.OnProcessedLinesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SemaphoreId", DbType="UNIQUEIDENTIFIER NULL")]
		public System.Nullable<System.Guid> SemaphoreId
		{
			get
			{
				return this._SemaphoreId;
			}
			set
			{
				if ((this._SemaphoreId != value))
				{
					this.OnSemaphoreIdChanging(value);
					this.SendPropertyChanging();
					this._SemaphoreId = value;
					this.SendPropertyChanged("SemaphoreId");
					this.OnSemaphoreIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Extract_ExtractItem", Storage="_ExtractItems", ThisKey="ExtractId", OtherKey="ExtractId")]
		public EntitySet<ExtractItem> ExtractItems
		{
			get
			{
				return this._ExtractItems;
			}
			set
			{
				this._ExtractItems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Extract_ExtractPersonStaging", Storage="_ExtractPersonStagings", ThisKey="ExtractId", OtherKey="ExtractId")]
		public EntitySet<ExtractPersonStaging> ExtractPersonStagings
		{
			get
			{
				return this._ExtractPersonStagings;
			}
			set
			{
				this._ExtractPersonStagings.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Extract_ExtractError", Storage="_ExtractErrors", ThisKey="ExtractId", OtherKey="ExtractId")]
		public EntitySet<ExtractError> ExtractErrors
		{
			get
			{
				return this._ExtractErrors;
			}
			set
			{
				this._ExtractErrors.Assign(value);
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
		
		private void attach_ExtractItems(ExtractItem entity)
		{
			this.SendPropertyChanging();
			entity.Extract = this;
		}
		
		private void detach_ExtractItems(ExtractItem entity)
		{
			this.SendPropertyChanging();
			entity.Extract = null;
		}
		
		private void attach_ExtractPersonStagings(ExtractPersonStaging entity)
		{
			this.SendPropertyChanging();
			entity.Extract = this;
		}
		
		private void detach_ExtractPersonStagings(ExtractPersonStaging entity)
		{
			this.SendPropertyChanging();
			entity.Extract = null;
		}
		
		private void attach_ExtractErrors(ExtractError entity)
		{
			this.SendPropertyChanging();
			entity.Extract = this;
		}
		
		private void detach_ExtractErrors(ExtractError entity)
		{
			this.SendPropertyChanging();
			entity.Extract = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExtractItem")]
	public partial class ExtractItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ExtractItemId;
		
		private System.Guid _ExtractId;
		
		private string _PNR;
		
		private string _RelationPNR;
		
		private string _RelationPNR2;
		
		private string _DataTypeCode;
		
		private string _Contents;
		
		private EntityRef<Extract> _Extract;
		
		private EntityRef<ExtractPersonStaging> _ExtractPersonStaging;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExtractItemIdChanging(System.Guid value);
    partial void OnExtractItemIdChanged();
    partial void OnExtractIdChanging(System.Guid value);
    partial void OnExtractIdChanged();
    partial void OnPNRChanging(string value);
    partial void OnPNRChanged();
    partial void OnRelationPNRChanging(string value);
    partial void OnRelationPNRChanged();
    partial void OnRelationPNR2Changing(string value);
    partial void OnRelationPNR2Changed();
    partial void OnDataTypeCodeChanging(string value);
    partial void OnDataTypeCodeChanged();
    partial void OnContentsChanging(string value);
    partial void OnContentsChanged();
    #endregion
		
		public ExtractItem()
		{
			this._Extract = default(EntityRef<Extract>);
			this._ExtractPersonStaging = default(EntityRef<ExtractPersonStaging>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractItemId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ExtractItemId
		{
			get
			{
				return this._ExtractItemId;
			}
			set
			{
				if ((this._ExtractItemId != value))
				{
					this.OnExtractItemIdChanging(value);
					this.SendPropertyChanging();
					this._ExtractItemId = value;
					this.SendPropertyChanged("ExtractItemId");
					this.OnExtractItemIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ExtractId
		{
			get
			{
				return this._ExtractId;
			}
			set
			{
				if ((this._ExtractId != value))
				{
					if ((this._Extract.HasLoadedOrAssignedValue || this._ExtractPersonStaging.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExtractIdChanging(value);
					this.SendPropertyChanging();
					this._ExtractId = value;
					this.SendPropertyChanged("ExtractId");
					this.OnExtractIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PNR", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string PNR
		{
			get
			{
				return this._PNR;
			}
			set
			{
				if ((this._PNR != value))
				{
					if (this._ExtractPersonStaging.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPNRChanging(value);
					this.SendPropertyChanging();
					this._PNR = value;
					this.SendPropertyChanged("PNR");
					this.OnPNRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelationPNR", DbType="VarChar(10)")]
		public string RelationPNR
		{
			get
			{
				return this._RelationPNR;
			}
			set
			{
				if ((this._RelationPNR != value))
				{
					this.OnRelationPNRChanging(value);
					this.SendPropertyChanging();
					this._RelationPNR = value;
					this.SendPropertyChanged("RelationPNR");
					this.OnRelationPNRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelationPNR2", DbType="VarChar(10)")]
		public string RelationPNR2
		{
			get
			{
				return this._RelationPNR2;
			}
			set
			{
				if ((this._RelationPNR2 != value))
				{
					this.OnRelationPNR2Changing(value);
					this.SendPropertyChanging();
					this._RelationPNR2 = value;
					this.SendPropertyChanged("RelationPNR2");
					this.OnRelationPNR2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataTypeCode", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string DataTypeCode
		{
			get
			{
				return this._DataTypeCode;
			}
			set
			{
				if ((this._DataTypeCode != value))
				{
					this.OnDataTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._DataTypeCode = value;
					this.SendPropertyChanged("DataTypeCode");
					this.OnDataTypeCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contents", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Contents
		{
			get
			{
				return this._Contents;
			}
			set
			{
				if ((this._Contents != value))
				{
					this.OnContentsChanging(value);
					this.SendPropertyChanging();
					this._Contents = value;
					this.SendPropertyChanged("Contents");
					this.OnContentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Extract_ExtractItem", Storage="_Extract", ThisKey="ExtractId", OtherKey="ExtractId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Extract Extract
		{
			get
			{
				return this._Extract.Entity;
			}
			set
			{
				Extract previousValue = this._Extract.Entity;
				if (((previousValue != value) 
							|| (this._Extract.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Extract.Entity = null;
						previousValue.ExtractItems.Remove(this);
					}
					this._Extract.Entity = value;
					if ((value != null))
					{
						value.ExtractItems.Add(this);
						this._ExtractId = value.ExtractId;
					}
					else
					{
						this._ExtractId = default(System.Guid);
					}
					this.SendPropertyChanged("Extract");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ExtractPersonStaging_ExtractItem", Storage="_ExtractPersonStaging", ThisKey="ExtractId,PNR", OtherKey="ExtractId,PNR", IsForeignKey=true)]
		public ExtractPersonStaging ExtractPersonStaging
		{
			get
			{
				return this._ExtractPersonStaging.Entity;
			}
			set
			{
				ExtractPersonStaging previousValue = this._ExtractPersonStaging.Entity;
				if (((previousValue != value) 
							|| (this._ExtractPersonStaging.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ExtractPersonStaging.Entity = null;
						previousValue.ExtractItems.Remove(this);
					}
					this._ExtractPersonStaging.Entity = value;
					if ((value != null))
					{
						value.ExtractItems.Add(this);
						this._ExtractId = value.ExtractId;
						this._PNR = value.PNR;
					}
					else
					{
						this._ExtractId = default(System.Guid);
						this._PNR = default(string);
					}
					this.SendPropertyChanged("ExtractPersonStaging");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExtractPersonStaging")]
	public partial class ExtractPersonStaging : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ExtractPersonStagingId;
		
		private System.Guid _ExtractId;
		
		private string _PNR;
		
		private EntitySet<ExtractItem> _ExtractItems;
		
		private EntityRef<Extract> _Extract;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExtractPersonStagingIdChanging(System.Guid value);
    partial void OnExtractPersonStagingIdChanged();
    partial void OnExtractIdChanging(System.Guid value);
    partial void OnExtractIdChanged();
    partial void OnPNRChanging(string value);
    partial void OnPNRChanged();
    #endregion
		
		public ExtractPersonStaging()
		{
			this._ExtractItems = new EntitySet<ExtractItem>(new Action<ExtractItem>(this.attach_ExtractItems), new Action<ExtractItem>(this.detach_ExtractItems));
			this._Extract = default(EntityRef<Extract>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractPersonStagingId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ExtractPersonStagingId
		{
			get
			{
				return this._ExtractPersonStagingId;
			}
			set
			{
				if ((this._ExtractPersonStagingId != value))
				{
					this.OnExtractPersonStagingIdChanging(value);
					this.SendPropertyChanging();
					this._ExtractPersonStagingId = value;
					this.SendPropertyChanged("ExtractPersonStagingId");
					this.OnExtractPersonStagingIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ExtractId
		{
			get
			{
				return this._ExtractId;
			}
			set
			{
				if ((this._ExtractId != value))
				{
					if (this._Extract.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExtractIdChanging(value);
					this.SendPropertyChanging();
					this._ExtractId = value;
					this.SendPropertyChanged("ExtractId");
					this.OnExtractIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PNR", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string PNR
		{
			get
			{
				return this._PNR;
			}
			set
			{
				if ((this._PNR != value))
				{
					this.OnPNRChanging(value);
					this.SendPropertyChanging();
					this._PNR = value;
					this.SendPropertyChanged("PNR");
					this.OnPNRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ExtractPersonStaging_ExtractItem", Storage="_ExtractItems", ThisKey="ExtractId,PNR", OtherKey="ExtractId,PNR")]
		public EntitySet<ExtractItem> ExtractItems
		{
			get
			{
				return this._ExtractItems;
			}
			set
			{
				this._ExtractItems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Extract_ExtractPersonStaging", Storage="_Extract", ThisKey="ExtractId", OtherKey="ExtractId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Extract Extract
		{
			get
			{
				return this._Extract.Entity;
			}
			set
			{
				Extract previousValue = this._Extract.Entity;
				if (((previousValue != value) 
							|| (this._Extract.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Extract.Entity = null;
						previousValue.ExtractPersonStagings.Remove(this);
					}
					this._Extract.Entity = value;
					if ((value != null))
					{
						value.ExtractPersonStagings.Add(this);
						this._ExtractId = value.ExtractId;
					}
					else
					{
						this._ExtractId = default(System.Guid);
					}
					this.SendPropertyChanged("Extract");
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
		
		private void attach_ExtractItems(ExtractItem entity)
		{
			this.SendPropertyChanging();
			entity.ExtractPersonStaging = this;
		}
		
		private void detach_ExtractItems(ExtractItem entity)
		{
			this.SendPropertyChanging();
			entity.ExtractPersonStaging = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExtractError")]
	public partial class ExtractError : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ExtractErrorId;
		
		private System.Guid _ExtractId;
		
		private string _Contents;
		
		private EntityRef<Extract> _Extract;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExtractErrorIdChanging(System.Guid value);
    partial void OnExtractErrorIdChanged();
    partial void OnExtractIdChanging(System.Guid value);
    partial void OnExtractIdChanged();
    partial void OnContentsChanging(string value);
    partial void OnContentsChanged();
    #endregion
		
		public ExtractError()
		{
			this._Extract = default(EntityRef<Extract>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractErrorId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ExtractErrorId
		{
			get
			{
				return this._ExtractErrorId;
			}
			set
			{
				if ((this._ExtractErrorId != value))
				{
					this.OnExtractErrorIdChanging(value);
					this.SendPropertyChanging();
					this._ExtractErrorId = value;
					this.SendPropertyChanged("ExtractErrorId");
					this.OnExtractErrorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtractId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ExtractId
		{
			get
			{
				return this._ExtractId;
			}
			set
			{
				if ((this._ExtractId != value))
				{
					if (this._Extract.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExtractIdChanging(value);
					this.SendPropertyChanging();
					this._ExtractId = value;
					this.SendPropertyChanged("ExtractId");
					this.OnExtractIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contents", DbType="NVarChar(157) NOT NULL", CanBeNull=false)]
		public string Contents
		{
			get
			{
				return this._Contents;
			}
			set
			{
				if ((this._Contents != value))
				{
					this.OnContentsChanging(value);
					this.SendPropertyChanging();
					this._Contents = value;
					this.SendPropertyChanged("Contents");
					this.OnContentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Extract_ExtractError", Storage="_Extract", ThisKey="ExtractId", OtherKey="ExtractId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Extract Extract
		{
			get
			{
				return this._Extract.Entity;
			}
			set
			{
				Extract previousValue = this._Extract.Entity;
				if (((previousValue != value) 
							|| (this._Extract.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Extract.Entity = null;
						previousValue.ExtractErrors.Remove(this);
					}
					this._Extract.Entity = value;
					if ((value != null))
					{
						value.ExtractErrors.Add(this);
						this._ExtractId = value.ExtractId;
					}
					else
					{
						this._ExtractId = default(System.Guid);
					}
					this.SendPropertyChanged("Extract");
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
