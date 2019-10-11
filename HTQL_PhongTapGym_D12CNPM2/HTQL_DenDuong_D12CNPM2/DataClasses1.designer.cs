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

namespace HTQL_DenDuong_D12CNPM2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HTQL")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTHANHVIEN(THANHVIEN instance);
    partial void UpdateTHANHVIEN(THANHVIEN instance);
    partial void DeleteTHANHVIEN(THANHVIEN instance);
    partial void InsertQUANLY(QUANLY instance);
    partial void UpdateQUANLY(QUANLY instance);
    partial void DeleteQUANLY(QUANLY instance);
    partial void InsertTHE(THE instance);
    partial void UpdateTHE(THE instance);
    partial void DeleteTHE(THE instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::HTQL_DenDuong_D12CNPM2.Properties.Settings.Default.HTQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<THANHVIEN> THANHVIENs
		{
			get
			{
				return this.GetTable<THANHVIEN>();
			}
		}
		
		public System.Data.Linq.Table<QUANLY> QUANLies
		{
			get
			{
				return this.GetTable<QUANLY>();
			}
		}
		
		public System.Data.Linq.Table<THE> THEs
		{
			get
			{
				return this.GetTable<THE>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THANHVIEN")]
	public partial class THANHVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MATV;
		
		private string _TENTV;
		
		private System.Nullable<System.DateTime> _NAMSINH;
		
		private string _DIACHI;
		
		private System.Nullable<int> _SDT;
		
		private string _GIOI_TINH;
		
		private System.Nullable<int> _DIEM;
		
		private string _XEPHANG;
		
		private EntitySet<QUANLY> _QUANLies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATVChanging(string value);
    partial void OnMATVChanged();
    partial void OnTENTVChanging(string value);
    partial void OnTENTVChanged();
    partial void OnNAMSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNAMSINHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(System.Nullable<int> value);
    partial void OnSDTChanged();
    partial void OnGIOI_TINHChanging(string value);
    partial void OnGIOI_TINHChanged();
    partial void OnDIEMChanging(System.Nullable<int> value);
    partial void OnDIEMChanged();
    partial void OnXEPHANGChanging(string value);
    partial void OnXEPHANGChanged();
    #endregion
		
		public THANHVIEN()
		{
			this._QUANLies = new EntitySet<QUANLY>(new Action<QUANLY>(this.attach_QUANLies), new Action<QUANLY>(this.detach_QUANLies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATV", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MATV
		{
			get
			{
				return this._MATV;
			}
			set
			{
				if ((this._MATV != value))
				{
					this.OnMATVChanging(value);
					this.SendPropertyChanging();
					this._MATV = value;
					this.SendPropertyChanged("MATV");
					this.OnMATVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENTV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENTV
		{
			get
			{
				return this._TENTV;
			}
			set
			{
				if ((this._TENTV != value))
				{
					this.OnTENTVChanging(value);
					this.SendPropertyChanging();
					this._TENTV = value;
					this.SendPropertyChanged("TENTV");
					this.OnTENTVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMSINH", DbType="Date")]
		public System.Nullable<System.DateTime> NAMSINH
		{
			get
			{
				return this._NAMSINH;
			}
			set
			{
				if ((this._NAMSINH != value))
				{
					this.OnNAMSINHChanging(value);
					this.SendPropertyChanging();
					this._NAMSINH = value;
					this.SendPropertyChanged("NAMSINH");
					this.OnNAMSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(50)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Int")]
		public System.Nullable<int> SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIOI_TINH", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string GIOI_TINH
		{
			get
			{
				return this._GIOI_TINH;
			}
			set
			{
				if ((this._GIOI_TINH != value))
				{
					this.OnGIOI_TINHChanging(value);
					this.SendPropertyChanging();
					this._GIOI_TINH = value;
					this.SendPropertyChanged("GIOI_TINH");
					this.OnGIOI_TINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIEM", DbType="Int")]
		public System.Nullable<int> DIEM
		{
			get
			{
				return this._DIEM;
			}
			set
			{
				if ((this._DIEM != value))
				{
					this.OnDIEMChanging(value);
					this.SendPropertyChanging();
					this._DIEM = value;
					this.SendPropertyChanged("DIEM");
					this.OnDIEMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XEPHANG", DbType="NVarChar(50)")]
		public string XEPHANG
		{
			get
			{
				return this._XEPHANG;
			}
			set
			{
				if ((this._XEPHANG != value))
				{
					this.OnXEPHANGChanging(value);
					this.SendPropertyChanging();
					this._XEPHANG = value;
					this.SendPropertyChanged("XEPHANG");
					this.OnXEPHANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THANHVIEN_QUANLY", Storage="_QUANLies", ThisKey="MATV", OtherKey="MATV")]
		public EntitySet<QUANLY> QUANLies
		{
			get
			{
				return this._QUANLies;
			}
			set
			{
				this._QUANLies.Assign(value);
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
		
		private void attach_QUANLies(QUANLY entity)
		{
			this.SendPropertyChanging();
			entity.THANHVIEN = this;
		}
		
		private void detach_QUANLies(QUANLY entity)
		{
			this.SendPropertyChanging();
			entity.THANHVIEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QUANLY")]
	public partial class QUANLY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHD;
		
		private string _MATV;
		
		private string _MAHLV;
		
		private string _MATHE;
		
		private EntityRef<THANHVIEN> _THANHVIEN;
		
		private EntityRef<THE> _THE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHDChanging(string value);
    partial void OnMAHDChanged();
    partial void OnMATVChanging(string value);
    partial void OnMATVChanged();
    partial void OnMAHLVChanging(string value);
    partial void OnMAHLVChanged();
    partial void OnMATHEChanging(string value);
    partial void OnMATHEChanged();
    #endregion
		
		public QUANLY()
		{
			this._THANHVIEN = default(EntityRef<THANHVIEN>);
			this._THE = default(EntityRef<THE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHD", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHD
		{
			get
			{
				return this._MAHD;
			}
			set
			{
				if ((this._MAHD != value))
				{
					this.OnMAHDChanging(value);
					this.SendPropertyChanging();
					this._MAHD = value;
					this.SendPropertyChanged("MAHD");
					this.OnMAHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATV", DbType="NVarChar(50)")]
		public string MATV
		{
			get
			{
				return this._MATV;
			}
			set
			{
				if ((this._MATV != value))
				{
					if (this._THANHVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMATVChanging(value);
					this.SendPropertyChanging();
					this._MATV = value;
					this.SendPropertyChanged("MATV");
					this.OnMATVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHLV", DbType="NVarChar(50)")]
		public string MAHLV
		{
			get
			{
				return this._MAHLV;
			}
			set
			{
				if ((this._MAHLV != value))
				{
					this.OnMAHLVChanging(value);
					this.SendPropertyChanging();
					this._MAHLV = value;
					this.SendPropertyChanged("MAHLV");
					this.OnMAHLVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATHE", DbType="NVarChar(50)")]
		public string MATHE
		{
			get
			{
				return this._MATHE;
			}
			set
			{
				if ((this._MATHE != value))
				{
					if (this._THE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMATHEChanging(value);
					this.SendPropertyChanging();
					this._MATHE = value;
					this.SendPropertyChanged("MATHE");
					this.OnMATHEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THANHVIEN_QUANLY", Storage="_THANHVIEN", ThisKey="MATV", OtherKey="MATV", IsForeignKey=true, DeleteRule="CASCADE")]
		public THANHVIEN THANHVIEN
		{
			get
			{
				return this._THANHVIEN.Entity;
			}
			set
			{
				THANHVIEN previousValue = this._THANHVIEN.Entity;
				if (((previousValue != value) 
							|| (this._THANHVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._THANHVIEN.Entity = null;
						previousValue.QUANLies.Remove(this);
					}
					this._THANHVIEN.Entity = value;
					if ((value != null))
					{
						value.QUANLies.Add(this);
						this._MATV = value.MATV;
					}
					else
					{
						this._MATV = default(string);
					}
					this.SendPropertyChanged("THANHVIEN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THE_QUANLY", Storage="_THE", ThisKey="MATHE", OtherKey="MATHE", IsForeignKey=true, DeleteRule="CASCADE")]
		public THE THE
		{
			get
			{
				return this._THE.Entity;
			}
			set
			{
				THE previousValue = this._THE.Entity;
				if (((previousValue != value) 
							|| (this._THE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._THE.Entity = null;
						previousValue.QUANLies.Remove(this);
					}
					this._THE.Entity = value;
					if ((value != null))
					{
						value.QUANLies.Add(this);
						this._MATHE = value.MATHE;
					}
					else
					{
						this._MATHE = default(string);
					}
					this.SendPropertyChanged("THE");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THE")]
	public partial class THE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MATHE;
		
		private string _TENTHE;
		
		private System.Nullable<System.DateTime> _NGAY_KICH_HOAT;
		
		private System.Nullable<System.DateTime> _NGAY_HET_HAN;
		
		private EntitySet<QUANLY> _QUANLies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATHEChanging(string value);
    partial void OnMATHEChanged();
    partial void OnTENTHEChanging(string value);
    partial void OnTENTHEChanged();
    partial void OnNGAY_KICH_HOATChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAY_KICH_HOATChanged();
    partial void OnNGAY_HET_HANChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAY_HET_HANChanged();
    #endregion
		
		public THE()
		{
			this._QUANLies = new EntitySet<QUANLY>(new Action<QUANLY>(this.attach_QUANLies), new Action<QUANLY>(this.detach_QUANLies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATHE", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MATHE
		{
			get
			{
				return this._MATHE;
			}
			set
			{
				if ((this._MATHE != value))
				{
					this.OnMATHEChanging(value);
					this.SendPropertyChanging();
					this._MATHE = value;
					this.SendPropertyChanged("MATHE");
					this.OnMATHEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENTHE", DbType="NVarChar(50)")]
		public string TENTHE
		{
			get
			{
				return this._TENTHE;
			}
			set
			{
				if ((this._TENTHE != value))
				{
					this.OnTENTHEChanging(value);
					this.SendPropertyChanging();
					this._TENTHE = value;
					this.SendPropertyChanged("TENTHE");
					this.OnTENTHEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_KICH_HOAT", DbType="Date")]
		public System.Nullable<System.DateTime> NGAY_KICH_HOAT
		{
			get
			{
				return this._NGAY_KICH_HOAT;
			}
			set
			{
				if ((this._NGAY_KICH_HOAT != value))
				{
					this.OnNGAY_KICH_HOATChanging(value);
					this.SendPropertyChanging();
					this._NGAY_KICH_HOAT = value;
					this.SendPropertyChanged("NGAY_KICH_HOAT");
					this.OnNGAY_KICH_HOATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAY_HET_HAN", DbType="Date")]
		public System.Nullable<System.DateTime> NGAY_HET_HAN
		{
			get
			{
				return this._NGAY_HET_HAN;
			}
			set
			{
				if ((this._NGAY_HET_HAN != value))
				{
					this.OnNGAY_HET_HANChanging(value);
					this.SendPropertyChanging();
					this._NGAY_HET_HAN = value;
					this.SendPropertyChanged("NGAY_HET_HAN");
					this.OnNGAY_HET_HANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THE_QUANLY", Storage="_QUANLies", ThisKey="MATHE", OtherKey="MATHE")]
		public EntitySet<QUANLY> QUANLies
		{
			get
			{
				return this._QUANLies;
			}
			set
			{
				this._QUANLies.Assign(value);
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
		
		private void attach_QUANLies(QUANLY entity)
		{
			this.SendPropertyChanging();
			entity.THE = this;
		}
		
		private void detach_QUANLies(QUANLY entity)
		{
			this.SendPropertyChanging();
			entity.THE = null;
		}
	}
}
#pragma warning restore 1591