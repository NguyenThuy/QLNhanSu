﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLNhanSu")]
	public partial class QLNhanSuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblBacLuong(tblBacLuong instance);
    partial void UpdatetblBacLuong(tblBacLuong instance);
    partial void DeletetblBacLuong(tblBacLuong instance);
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    partial void InserttblChucVu(tblChucVu instance);
    partial void UpdatetblChucVu(tblChucVu instance);
    partial void DeletetblChucVu(tblChucVu instance);
    partial void InserttblDeAn(tblDeAn instance);
    partial void UpdatetblDeAn(tblDeAn instance);
    partial void DeletetblDeAn(tblDeAn instance);
    partial void InserttblNhanVien(tblNhanVien instance);
    partial void UpdatetblNhanVien(tblNhanVien instance);
    partial void DeletetblNhanVien(tblNhanVien instance);
    partial void InserttblNhomNguoiDung(tblNhomNguoiDung instance);
    partial void UpdatetblNhomNguoiDung(tblNhomNguoiDung instance);
    partial void DeletetblNhomNguoiDung(tblNhomNguoiDung instance);
    partial void InserttblPhongBan(tblPhongBan instance);
    partial void UpdatetblPhongBan(tblPhongBan instance);
    partial void DeletetblPhongBan(tblPhongBan instance);
    partial void InserttblTrinhDo(tblTrinhDo instance);
    partial void UpdatetblTrinhDo(tblTrinhDo instance);
    partial void DeletetblTrinhDo(tblTrinhDo instance);
    #endregion
		
		public QLNhanSuDataContext() : 
				base(global::DAL.Properties.Settings.Default.QLNhanSuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLNhanSuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNhanSuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNhanSuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNhanSuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblBacLuong> tblBacLuongs
		{
			get
			{
				return this.GetTable<tblBacLuong>();
			}
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
		
		public System.Data.Linq.Table<tblChucVu> tblChucVus
		{
			get
			{
				return this.GetTable<tblChucVu>();
			}
		}
		
		public System.Data.Linq.Table<tblDeAn> tblDeAns
		{
			get
			{
				return this.GetTable<tblDeAn>();
			}
		}
		
		public System.Data.Linq.Table<tblNhanVien> tblNhanViens
		{
			get
			{
				return this.GetTable<tblNhanVien>();
			}
		}
		
		public System.Data.Linq.Table<tblNhanVien_DeAn> tblNhanVien_DeAns
		{
			get
			{
				return this.GetTable<tblNhanVien_DeAn>();
			}
		}
		
		public System.Data.Linq.Table<tblNhomNguoiDung> tblNhomNguoiDungs
		{
			get
			{
				return this.GetTable<tblNhomNguoiDung>();
			}
		}
		
		public System.Data.Linq.Table<tblPhongBan> tblPhongBans
		{
			get
			{
				return this.GetTable<tblPhongBan>();
			}
		}
		
		public System.Data.Linq.Table<tblTrinhDo> tblTrinhDos
		{
			get
			{
				return this.GetTable<tblTrinhDo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblBacLuong")]
	public partial class tblBacLuong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaBacLuong;
		
		private string _TenBacLuong;
		
		private System.Nullable<double> _HeSo;
		
		private EntitySet<tblNhanVien> _tblNhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBacLuongChanging(string value);
    partial void OnMaBacLuongChanged();
    partial void OnTenBacLuongChanging(string value);
    partial void OnTenBacLuongChanged();
    partial void OnHeSoChanging(System.Nullable<double> value);
    partial void OnHeSoChanged();
    #endregion
		
		public tblBacLuong()
		{
			this._tblNhanViens = new EntitySet<tblNhanVien>(new Action<tblNhanVien>(this.attach_tblNhanViens), new Action<tblNhanVien>(this.detach_tblNhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBacLuong", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaBacLuong
		{
			get
			{
				return this._MaBacLuong;
			}
			set
			{
				if ((this._MaBacLuong != value))
				{
					this.OnMaBacLuongChanging(value);
					this.SendPropertyChanging();
					this._MaBacLuong = value;
					this.SendPropertyChanged("MaBacLuong");
					this.OnMaBacLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBacLuong", DbType="NVarChar(30)")]
		public string TenBacLuong
		{
			get
			{
				return this._TenBacLuong;
			}
			set
			{
				if ((this._TenBacLuong != value))
				{
					this.OnTenBacLuongChanging(value);
					this.SendPropertyChanging();
					this._TenBacLuong = value;
					this.SendPropertyChanged("TenBacLuong");
					this.OnTenBacLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeSo", DbType="Float")]
		public System.Nullable<double> HeSo
		{
			get
			{
				return this._HeSo;
			}
			set
			{
				if ((this._HeSo != value))
				{
					this.OnHeSoChanging(value);
					this.SendPropertyChanging();
					this._HeSo = value;
					this.SendPropertyChanged("HeSo");
					this.OnHeSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblBacLuong_tblNhanVien", Storage="_tblNhanViens", ThisKey="MaBacLuong", OtherKey="MaBacLuong")]
		public EntitySet<tblNhanVien> tblNhanViens
		{
			get
			{
				return this._tblNhanViens;
			}
			set
			{
				this._tblNhanViens.Assign(value);
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
		
		private void attach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblBacLuong = this;
		}
		
		private void detach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblBacLuong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserName;
		
		private string _Pass;
		
		private string _MaNhom;
		
		private EntityRef<tblNhomNguoiDung> _tblNhomNguoiDung;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnMaNhomChanging(string value);
    partial void OnMaNhomChanged();
    #endregion
		
		public tblUser()
		{
			this._tblNhomNguoiDung = default(EntityRef<tblNhomNguoiDung>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="NVarChar(30)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhom", DbType="VarChar(10)")]
		public string MaNhom
		{
			get
			{
				return this._MaNhom;
			}
			set
			{
				if ((this._MaNhom != value))
				{
					if (this._tblNhomNguoiDung.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhomChanging(value);
					this.SendPropertyChanging();
					this._MaNhom = value;
					this.SendPropertyChanged("MaNhom");
					this.OnMaNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhomNguoiDung_tblUser", Storage="_tblNhomNguoiDung", ThisKey="MaNhom", OtherKey="MaNhom", IsForeignKey=true)]
		public tblNhomNguoiDung tblNhomNguoiDung
		{
			get
			{
				return this._tblNhomNguoiDung.Entity;
			}
			set
			{
				tblNhomNguoiDung previousValue = this._tblNhomNguoiDung.Entity;
				if (((previousValue != value) 
							|| (this._tblNhomNguoiDung.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblNhomNguoiDung.Entity = null;
						previousValue.tblUsers.Remove(this);
					}
					this._tblNhomNguoiDung.Entity = value;
					if ((value != null))
					{
						value.tblUsers.Add(this);
						this._MaNhom = value.MaNhom;
					}
					else
					{
						this._MaNhom = default(string);
					}
					this.SendPropertyChanged("tblNhomNguoiDung");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblChucVu")]
	public partial class tblChucVu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaCV;
		
		private string _TenCV;
		
		private EntitySet<tblNhanVien> _tblNhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaCVChanging(string value);
    partial void OnMaCVChanged();
    partial void OnTenCVChanging(string value);
    partial void OnTenCVChanged();
    #endregion
		
		public tblChucVu()
		{
			this._tblNhanViens = new EntitySet<tblNhanVien>(new Action<tblNhanVien>(this.attach_tblNhanViens), new Action<tblNhanVien>(this.detach_tblNhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaCV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaCV
		{
			get
			{
				return this._MaCV;
			}
			set
			{
				if ((this._MaCV != value))
				{
					this.OnMaCVChanging(value);
					this.SendPropertyChanging();
					this._MaCV = value;
					this.SendPropertyChanged("MaCV");
					this.OnMaCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenCV", DbType="NVarChar(30)")]
		public string TenCV
		{
			get
			{
				return this._TenCV;
			}
			set
			{
				if ((this._TenCV != value))
				{
					this.OnTenCVChanging(value);
					this.SendPropertyChanging();
					this._TenCV = value;
					this.SendPropertyChanged("TenCV");
					this.OnTenCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChucVu_tblNhanVien", Storage="_tblNhanViens", ThisKey="MaCV", OtherKey="MaCV")]
		public EntitySet<tblNhanVien> tblNhanViens
		{
			get
			{
				return this._tblNhanViens;
			}
			set
			{
				this._tblNhanViens.Assign(value);
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
		
		private void attach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblChucVu = this;
		}
		
		private void detach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblChucVu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblDeAn")]
	public partial class tblDeAn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDA;
		
		private string _TenDA;
		
		private string _MaPhong;
		
		private EntityRef<tblPhongBan> _tblPhongBan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDAChanging(string value);
    partial void OnMaDAChanged();
    partial void OnTenDAChanging(string value);
    partial void OnTenDAChanged();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    #endregion
		
		public tblDeAn()
		{
			this._tblPhongBan = default(EntityRef<tblPhongBan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDA", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDA
		{
			get
			{
				return this._MaDA;
			}
			set
			{
				if ((this._MaDA != value))
				{
					this.OnMaDAChanging(value);
					this.SendPropertyChanging();
					this._MaDA = value;
					this.SendPropertyChanged("MaDA");
					this.OnMaDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDA", DbType="NVarChar(30)")]
		public string TenDA
		{
			get
			{
				return this._TenDA;
			}
			set
			{
				if ((this._TenDA != value))
				{
					this.OnTenDAChanging(value);
					this.SendPropertyChanging();
					this._TenDA = value;
					this.SendPropertyChanged("TenDA");
					this.OnTenDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="VarChar(10)")]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					if (this._tblPhongBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblPhongBan_tblDeAn", Storage="_tblPhongBan", ThisKey="MaPhong", OtherKey="MaPhong", IsForeignKey=true)]
		public tblPhongBan tblPhongBan
		{
			get
			{
				return this._tblPhongBan.Entity;
			}
			set
			{
				tblPhongBan previousValue = this._tblPhongBan.Entity;
				if (((previousValue != value) 
							|| (this._tblPhongBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblPhongBan.Entity = null;
						previousValue.tblDeAns.Remove(this);
					}
					this._tblPhongBan.Entity = value;
					if ((value != null))
					{
						value.tblDeAns.Add(this);
						this._MaPhong = value.MaPhong;
					}
					else
					{
						this._MaPhong = default(string);
					}
					this.SendPropertyChanged("tblPhongBan");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblNhanVien")]
	public partial class tblNhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _HoDem;
		
		private string _TenNV;
		
		private System.Nullable<System.DateTime> _NS;
		
		private string _DiaChi;
		
		private string _GT;
		
		private string _MaBacLuong;
		
		private string _MaPhong;
		
		private string _MaCV;
		
		private string _MaTrinhDo;
		
		private EntityRef<tblBacLuong> _tblBacLuong;
		
		private EntityRef<tblChucVu> _tblChucVu;
		
		private EntityRef<tblPhongBan> _tblPhongBan;
		
		private EntityRef<tblTrinhDo> _tblTrinhDo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnHoDemChanging(string value);
    partial void OnHoDemChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnNSChanging(System.Nullable<System.DateTime> value);
    partial void OnNSChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnGTChanging(string value);
    partial void OnGTChanged();
    partial void OnMaBacLuongChanging(string value);
    partial void OnMaBacLuongChanged();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnMaCVChanging(string value);
    partial void OnMaCVChanged();
    partial void OnMaTrinhDoChanging(string value);
    partial void OnMaTrinhDoChanged();
    #endregion
		
		public tblNhanVien()
		{
			this._tblBacLuong = default(EntityRef<tblBacLuong>);
			this._tblChucVu = default(EntityRef<tblChucVu>);
			this._tblPhongBan = default(EntityRef<tblPhongBan>);
			this._tblTrinhDo = default(EntityRef<tblTrinhDo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoDem", DbType="NVarChar(30)")]
		public string HoDem
		{
			get
			{
				return this._HoDem;
			}
			set
			{
				if ((this._HoDem != value))
				{
					this.OnHoDemChanging(value);
					this.SendPropertyChanging();
					this._HoDem = value;
					this.SendPropertyChanged("HoDem");
					this.OnHoDemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(30)")]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NS", DbType="Date")]
		public System.Nullable<System.DateTime> NS
		{
			get
			{
				return this._NS;
			}
			set
			{
				if ((this._NS != value))
				{
					this.OnNSChanging(value);
					this.SendPropertyChanging();
					this._NS = value;
					this.SendPropertyChanged("NS");
					this.OnNSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(30)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GT", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string GT
		{
			get
			{
				return this._GT;
			}
			set
			{
				if ((this._GT != value))
				{
					this.OnGTChanging(value);
					this.SendPropertyChanging();
					this._GT = value;
					this.SendPropertyChanged("GT");
					this.OnGTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBacLuong", DbType="VarChar(10)")]
		public string MaBacLuong
		{
			get
			{
				return this._MaBacLuong;
			}
			set
			{
				if ((this._MaBacLuong != value))
				{
					if (this._tblBacLuong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaBacLuongChanging(value);
					this.SendPropertyChanging();
					this._MaBacLuong = value;
					this.SendPropertyChanged("MaBacLuong");
					this.OnMaBacLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="VarChar(10)")]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					if (this._tblPhongBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaCV", DbType="VarChar(10)")]
		public string MaCV
		{
			get
			{
				return this._MaCV;
			}
			set
			{
				if ((this._MaCV != value))
				{
					if (this._tblChucVu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaCVChanging(value);
					this.SendPropertyChanging();
					this._MaCV = value;
					this.SendPropertyChanged("MaCV");
					this.OnMaCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTrinhDo", DbType="VarChar(10)")]
		public string MaTrinhDo
		{
			get
			{
				return this._MaTrinhDo;
			}
			set
			{
				if ((this._MaTrinhDo != value))
				{
					if (this._tblTrinhDo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTrinhDoChanging(value);
					this.SendPropertyChanging();
					this._MaTrinhDo = value;
					this.SendPropertyChanged("MaTrinhDo");
					this.OnMaTrinhDoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblBacLuong_tblNhanVien", Storage="_tblBacLuong", ThisKey="MaBacLuong", OtherKey="MaBacLuong", IsForeignKey=true)]
		public tblBacLuong tblBacLuong
		{
			get
			{
				return this._tblBacLuong.Entity;
			}
			set
			{
				tblBacLuong previousValue = this._tblBacLuong.Entity;
				if (((previousValue != value) 
							|| (this._tblBacLuong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblBacLuong.Entity = null;
						previousValue.tblNhanViens.Remove(this);
					}
					this._tblBacLuong.Entity = value;
					if ((value != null))
					{
						value.tblNhanViens.Add(this);
						this._MaBacLuong = value.MaBacLuong;
					}
					else
					{
						this._MaBacLuong = default(string);
					}
					this.SendPropertyChanged("tblBacLuong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChucVu_tblNhanVien", Storage="_tblChucVu", ThisKey="MaCV", OtherKey="MaCV", IsForeignKey=true)]
		public tblChucVu tblChucVu
		{
			get
			{
				return this._tblChucVu.Entity;
			}
			set
			{
				tblChucVu previousValue = this._tblChucVu.Entity;
				if (((previousValue != value) 
							|| (this._tblChucVu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblChucVu.Entity = null;
						previousValue.tblNhanViens.Remove(this);
					}
					this._tblChucVu.Entity = value;
					if ((value != null))
					{
						value.tblNhanViens.Add(this);
						this._MaCV = value.MaCV;
					}
					else
					{
						this._MaCV = default(string);
					}
					this.SendPropertyChanged("tblChucVu");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblPhongBan_tblNhanVien", Storage="_tblPhongBan", ThisKey="MaPhong", OtherKey="MaPhong", IsForeignKey=true)]
		public tblPhongBan tblPhongBan
		{
			get
			{
				return this._tblPhongBan.Entity;
			}
			set
			{
				tblPhongBan previousValue = this._tblPhongBan.Entity;
				if (((previousValue != value) 
							|| (this._tblPhongBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblPhongBan.Entity = null;
						previousValue.tblNhanViens.Remove(this);
					}
					this._tblPhongBan.Entity = value;
					if ((value != null))
					{
						value.tblNhanViens.Add(this);
						this._MaPhong = value.MaPhong;
					}
					else
					{
						this._MaPhong = default(string);
					}
					this.SendPropertyChanged("tblPhongBan");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblTrinhDo_tblNhanVien", Storage="_tblTrinhDo", ThisKey="MaTrinhDo", OtherKey="MaTrinhDo", IsForeignKey=true)]
		public tblTrinhDo tblTrinhDo
		{
			get
			{
				return this._tblTrinhDo.Entity;
			}
			set
			{
				tblTrinhDo previousValue = this._tblTrinhDo.Entity;
				if (((previousValue != value) 
							|| (this._tblTrinhDo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblTrinhDo.Entity = null;
						previousValue.tblNhanViens.Remove(this);
					}
					this._tblTrinhDo.Entity = value;
					if ((value != null))
					{
						value.tblNhanViens.Add(this);
						this._MaTrinhDo = value.MaTrinhDo;
					}
					else
					{
						this._MaTrinhDo = default(string);
					}
					this.SendPropertyChanged("tblTrinhDo");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblNhanVien_DeAn")]
	public partial class tblNhanVien_DeAn
	{
		
		private string _MaNV;
		
		private string _MaDA;
		
		private System.Nullable<double> _SoGio;
		
		public tblNhanVien_DeAn()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="VarChar(10)")]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this._MaNV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDA", DbType="VarChar(10)")]
		public string MaDA
		{
			get
			{
				return this._MaDA;
			}
			set
			{
				if ((this._MaDA != value))
				{
					this._MaDA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoGio", DbType="Float")]
		public System.Nullable<double> SoGio
		{
			get
			{
				return this._SoGio;
			}
			set
			{
				if ((this._SoGio != value))
				{
					this._SoGio = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblNhomNguoiDung")]
	public partial class tblNhomNguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhom;
		
		private string _TenNhom;
		
		private EntitySet<tblUser> _tblUsers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhomChanging(string value);
    partial void OnMaNhomChanged();
    partial void OnTenNhomChanging(string value);
    partial void OnTenNhomChanged();
    #endregion
		
		public tblNhomNguoiDung()
		{
			this._tblUsers = new EntitySet<tblUser>(new Action<tblUser>(this.attach_tblUsers), new Action<tblUser>(this.detach_tblUsers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhom", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhom
		{
			get
			{
				return this._MaNhom;
			}
			set
			{
				if ((this._MaNhom != value))
				{
					this.OnMaNhomChanging(value);
					this.SendPropertyChanging();
					this._MaNhom = value;
					this.SendPropertyChanged("MaNhom");
					this.OnMaNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhom", DbType="NVarChar(30)")]
		public string TenNhom
		{
			get
			{
				return this._TenNhom;
			}
			set
			{
				if ((this._TenNhom != value))
				{
					this.OnTenNhomChanging(value);
					this.SendPropertyChanging();
					this._TenNhom = value;
					this.SendPropertyChanged("TenNhom");
					this.OnTenNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhomNguoiDung_tblUser", Storage="_tblUsers", ThisKey="MaNhom", OtherKey="MaNhom")]
		public EntitySet<tblUser> tblUsers
		{
			get
			{
				return this._tblUsers;
			}
			set
			{
				this._tblUsers.Assign(value);
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
		
		private void attach_tblUsers(tblUser entity)
		{
			this.SendPropertyChanging();
			entity.tblNhomNguoiDung = this;
		}
		
		private void detach_tblUsers(tblUser entity)
		{
			this.SendPropertyChanging();
			entity.tblNhomNguoiDung = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblPhongBan")]
	public partial class tblPhongBan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhong;
		
		private string _TenPhong;
		
		private EntitySet<tblDeAn> _tblDeAns;
		
		private EntitySet<tblNhanVien> _tblNhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnTenPhongChanging(string value);
    partial void OnTenPhongChanged();
    #endregion
		
		public tblPhongBan()
		{
			this._tblDeAns = new EntitySet<tblDeAn>(new Action<tblDeAn>(this.attach_tblDeAns), new Action<tblDeAn>(this.detach_tblDeAns));
			this._tblNhanViens = new EntitySet<tblNhanVien>(new Action<tblNhanVien>(this.attach_tblNhanViens), new Action<tblNhanVien>(this.detach_tblNhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPhong", DbType="NVarChar(30)")]
		public string TenPhong
		{
			get
			{
				return this._TenPhong;
			}
			set
			{
				if ((this._TenPhong != value))
				{
					this.OnTenPhongChanging(value);
					this.SendPropertyChanging();
					this._TenPhong = value;
					this.SendPropertyChanged("TenPhong");
					this.OnTenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblPhongBan_tblDeAn", Storage="_tblDeAns", ThisKey="MaPhong", OtherKey="MaPhong")]
		public EntitySet<tblDeAn> tblDeAns
		{
			get
			{
				return this._tblDeAns;
			}
			set
			{
				this._tblDeAns.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblPhongBan_tblNhanVien", Storage="_tblNhanViens", ThisKey="MaPhong", OtherKey="MaPhong")]
		public EntitySet<tblNhanVien> tblNhanViens
		{
			get
			{
				return this._tblNhanViens;
			}
			set
			{
				this._tblNhanViens.Assign(value);
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
		
		private void attach_tblDeAns(tblDeAn entity)
		{
			this.SendPropertyChanging();
			entity.tblPhongBan = this;
		}
		
		private void detach_tblDeAns(tblDeAn entity)
		{
			this.SendPropertyChanging();
			entity.tblPhongBan = null;
		}
		
		private void attach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblPhongBan = this;
		}
		
		private void detach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblPhongBan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblTrinhDo")]
	public partial class tblTrinhDo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaTrinhDo;
		
		private string _TenTrinhDo;
		
		private EntitySet<tblNhanVien> _tblNhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTrinhDoChanging(string value);
    partial void OnMaTrinhDoChanged();
    partial void OnTenTrinhDoChanging(string value);
    partial void OnTenTrinhDoChanged();
    #endregion
		
		public tblTrinhDo()
		{
			this._tblNhanViens = new EntitySet<tblNhanVien>(new Action<tblNhanVien>(this.attach_tblNhanViens), new Action<tblNhanVien>(this.detach_tblNhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTrinhDo", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTrinhDo
		{
			get
			{
				return this._MaTrinhDo;
			}
			set
			{
				if ((this._MaTrinhDo != value))
				{
					this.OnMaTrinhDoChanging(value);
					this.SendPropertyChanging();
					this._MaTrinhDo = value;
					this.SendPropertyChanged("MaTrinhDo");
					this.OnMaTrinhDoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTrinhDo", DbType="NVarChar(30)")]
		public string TenTrinhDo
		{
			get
			{
				return this._TenTrinhDo;
			}
			set
			{
				if ((this._TenTrinhDo != value))
				{
					this.OnTenTrinhDoChanging(value);
					this.SendPropertyChanging();
					this._TenTrinhDo = value;
					this.SendPropertyChanged("TenTrinhDo");
					this.OnTenTrinhDoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblTrinhDo_tblNhanVien", Storage="_tblNhanViens", ThisKey="MaTrinhDo", OtherKey="MaTrinhDo")]
		public EntitySet<tblNhanVien> tblNhanViens
		{
			get
			{
				return this._tblNhanViens;
			}
			set
			{
				this._tblNhanViens.Assign(value);
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
		
		private void attach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblTrinhDo = this;
		}
		
		private void detach_tblNhanViens(tblNhanVien entity)
		{
			this.SendPropertyChanging();
			entity.tblTrinhDo = null;
		}
	}
}
#pragma warning restore 1591
