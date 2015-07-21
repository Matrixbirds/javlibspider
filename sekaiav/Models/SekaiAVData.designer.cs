﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace sekaiav.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sekai_av")]
	public partial class SekaiAVDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertt_actress_video(t_actress_video instance);
    partial void Updatet_actress_video(t_actress_video instance);
    partial void Deletet_actress_video(t_actress_video instance);
    partial void Insertt_factory_video(t_factory_video instance);
    partial void Updatet_factory_video(t_factory_video instance);
    partial void Deletet_factory_video(t_factory_video instance);
    partial void Insertt_issuer_video(t_issuer_video instance);
    partial void Updatet_issuer_video(t_issuer_video instance);
    partial void Deletet_issuer_video(t_issuer_video instance);
    partial void Insertt_actress(t_actress instance);
    partial void Updatet_actress(t_actress instance);
    partial void Deletet_actress(t_actress instance);
    partial void Insertt_director(t_director instance);
    partial void Updatet_director(t_director instance);
    partial void Deletet_director(t_director instance);
    partial void Insertt_factory(t_factory instance);
    partial void Updatet_factory(t_factory instance);
    partial void Deletet_factory(t_factory instance);
    partial void Insertt_issuer(t_issuer instance);
    partial void Updatet_issuer(t_issuer instance);
    partial void Deletet_issuer(t_issuer instance);
    partial void Insertt_video(t_video instance);
    partial void Updatet_video(t_video instance);
    partial void Deletet_video(t_video instance);
    #endregion
		
		public SekaiAVDataDataContext() : 
				base(global::sekaiav.Properties.Settings.Default.sekai_avConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SekaiAVDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SekaiAVDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SekaiAVDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SekaiAVDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<t_actress_video> t_actress_video
		{
			get
			{
				return this.GetTable<t_actress_video>();
			}
		}
		
		public System.Data.Linq.Table<t_factory_video> t_factory_video
		{
			get
			{
				return this.GetTable<t_factory_video>();
			}
		}
		
		public System.Data.Linq.Table<t_issuer_video> t_issuer_video
		{
			get
			{
				return this.GetTable<t_issuer_video>();
			}
		}
		
		public System.Data.Linq.Table<v_video> v_video
		{
			get
			{
				return this.GetTable<v_video>();
			}
		}
		
		public System.Data.Linq.Table<t_actress> t_actress
		{
			get
			{
				return this.GetTable<t_actress>();
			}
		}
		
		public System.Data.Linq.Table<t_director> t_director
		{
			get
			{
				return this.GetTable<t_director>();
			}
		}
		
		public System.Data.Linq.Table<t_factory> t_factory
		{
			get
			{
				return this.GetTable<t_factory>();
			}
		}
		
		public System.Data.Linq.Table<t_issuer> t_issuer
		{
			get
			{
				return this.GetTable<t_issuer>();
			}
		}
		
		public System.Data.Linq.Table<t_video> t_video
		{
			get
			{
				return this.GetTable<t_video>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_actress_video")]
	public partial class t_actress_video : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _f_actress;
		
		private int _f_video;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onf_actressChanging(int value);
    partial void Onf_actressChanged();
    partial void Onf_videoChanging(int value);
    partial void Onf_videoChanged();
    #endregion
		
		public t_actress_video()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_actress", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int f_actress
		{
			get
			{
				return this._f_actress;
			}
			set
			{
				if ((this._f_actress != value))
				{
					this.Onf_actressChanging(value);
					this.SendPropertyChanging();
					this._f_actress = value;
					this.SendPropertyChanged("f_actress");
					this.Onf_actressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_video", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int f_video
		{
			get
			{
				return this._f_video;
			}
			set
			{
				if ((this._f_video != value))
				{
					this.Onf_videoChanging(value);
					this.SendPropertyChanging();
					this._f_video = value;
					this.SendPropertyChanged("f_video");
					this.Onf_videoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_factory_video")]
	public partial class t_factory_video : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _f_factory;
		
		private int _f_video;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onf_factoryChanging(int value);
    partial void Onf_factoryChanged();
    partial void Onf_videoChanging(int value);
    partial void Onf_videoChanged();
    #endregion
		
		public t_factory_video()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_factory", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int f_factory
		{
			get
			{
				return this._f_factory;
			}
			set
			{
				if ((this._f_factory != value))
				{
					this.Onf_factoryChanging(value);
					this.SendPropertyChanging();
					this._f_factory = value;
					this.SendPropertyChanged("f_factory");
					this.Onf_factoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_video", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int f_video
		{
			get
			{
				return this._f_video;
			}
			set
			{
				if ((this._f_video != value))
				{
					this.Onf_videoChanging(value);
					this.SendPropertyChanging();
					this._f_video = value;
					this.SendPropertyChanged("f_video");
					this.Onf_videoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_issuer_video")]
	public partial class t_issuer_video : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _t_issuer;
		
		private int _t_video;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ont_issuerChanging(int value);
    partial void Ont_issuerChanged();
    partial void Ont_videoChanging(int value);
    partial void Ont_videoChanged();
    #endregion
		
		public t_issuer_video()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_t_issuer", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int t_issuer
		{
			get
			{
				return this._t_issuer;
			}
			set
			{
				if ((this._t_issuer != value))
				{
					this.Ont_issuerChanging(value);
					this.SendPropertyChanging();
					this._t_issuer = value;
					this.SendPropertyChanged("t_issuer");
					this.Ont_issuerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_t_video", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int t_video
		{
			get
			{
				return this._t_video;
			}
			set
			{
				if ((this._t_video != value))
				{
					this.Ont_videoChanging(value);
					this.SendPropertyChanging();
					this._t_video = value;
					this.SendPropertyChanged("t_video");
					this.Ont_videoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.v_video")]
	public partial class v_video
	{
		
		private int _id;
		
		private string _f_javlib_id;
		
		private double _f_length;
		
		private System.DateTime _f_issuer_date;
		
		private string _f_code;
		
		private string _f_name;
		
		private System.DateTime _f_update;
		
		private string _f_director_name;
		
		private string _f_issuer_name;
		
		private System.Nullable<int> _f_director_id;
		
		private string _f_director_javlib_id;
		
		private int _f_issuer_id;
		
		private string _f_issuer_javlib_id;
		
		private int _f_factory_id;
		
		private string _f_factory_javlib_id;
		
		private string _f_factory_name;
		
		public v_video()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_javlib_id", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string f_javlib_id
		{
			get
			{
				return this._f_javlib_id;
			}
			set
			{
				if ((this._f_javlib_id != value))
				{
					this._f_javlib_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_length", DbType="Float NOT NULL")]
		public double f_length
		{
			get
			{
				return this._f_length;
			}
			set
			{
				if ((this._f_length != value))
				{
					this._f_length = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_issuer_date", DbType="Date NOT NULL")]
		public System.DateTime f_issuer_date
		{
			get
			{
				return this._f_issuer_date;
			}
			set
			{
				if ((this._f_issuer_date != value))
				{
					this._f_issuer_date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_code", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string f_code
		{
			get
			{
				return this._f_code;
			}
			set
			{
				if ((this._f_code != value))
				{
					this._f_code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string f_name
		{
			get
			{
				return this._f_name;
			}
			set
			{
				if ((this._f_name != value))
				{
					this._f_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_update", DbType="DateTime NOT NULL")]
		public System.DateTime f_update
		{
			get
			{
				return this._f_update;
			}
			set
			{
				if ((this._f_update != value))
				{
					this._f_update = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_director_name", DbType="NVarChar(50)")]
		public string f_director_name
		{
			get
			{
				return this._f_director_name;
			}
			set
			{
				if ((this._f_director_name != value))
				{
					this._f_director_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_issuer_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string f_issuer_name
		{
			get
			{
				return this._f_issuer_name;
			}
			set
			{
				if ((this._f_issuer_name != value))
				{
					this._f_issuer_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_director_id", DbType="Int")]
		public System.Nullable<int> f_director_id
		{
			get
			{
				return this._f_director_id;
			}
			set
			{
				if ((this._f_director_id != value))
				{
					this._f_director_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_director_javlib_id", DbType="NChar(10)")]
		public string f_director_javlib_id
		{
			get
			{
				return this._f_director_javlib_id;
			}
			set
			{
				if ((this._f_director_javlib_id != value))
				{
					this._f_director_javlib_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_issuer_id", DbType="Int NOT NULL")]
		public int f_issuer_id
		{
			get
			{
				return this._f_issuer_id;
			}
			set
			{
				if ((this._f_issuer_id != value))
				{
					this._f_issuer_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_issuer_javlib_id", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string f_issuer_javlib_id
		{
			get
			{
				return this._f_issuer_javlib_id;
			}
			set
			{
				if ((this._f_issuer_javlib_id != value))
				{
					this._f_issuer_javlib_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_factory_id", DbType="Int NOT NULL")]
		public int f_factory_id
		{
			get
			{
				return this._f_factory_id;
			}
			set
			{
				if ((this._f_factory_id != value))
				{
					this._f_factory_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_factory_javlib_id", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string f_factory_javlib_id
		{
			get
			{
				return this._f_factory_javlib_id;
			}
			set
			{
				if ((this._f_factory_javlib_id != value))
				{
					this._f_factory_javlib_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_factory_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string f_factory_name
		{
			get
			{
				return this._f_factory_name;
			}
			set
			{
				if ((this._f_factory_name != value))
				{
					this._f_factory_name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_actress")]
	public partial class t_actress : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _f_javlib_id;
		
		private string _f_name;
		
		private System.DateTime _f_update;
		
		private string _f_prefix;
		
		private string _f_version;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onf_javlib_idChanging(string value);
    partial void Onf_javlib_idChanged();
    partial void Onf_nameChanging(string value);
    partial void Onf_nameChanged();
    partial void Onf_updateChanging(System.DateTime value);
    partial void Onf_updateChanged();
    partial void Onf_prefixChanging(string value);
    partial void Onf_prefixChanged();
    partial void Onf_versionChanging(string value);
    partial void Onf_versionChanged();
    #endregion
		
		public t_actress()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_javlib_id", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string f_javlib_id
		{
			get
			{
				return this._f_javlib_id;
			}
			set
			{
				if ((this._f_javlib_id != value))
				{
					this.Onf_javlib_idChanging(value);
					this.SendPropertyChanging();
					this._f_javlib_id = value;
					this.SendPropertyChanged("f_javlib_id");
					this.Onf_javlib_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string f_name
		{
			get
			{
				return this._f_name;
			}
			set
			{
				if ((this._f_name != value))
				{
					this.Onf_nameChanging(value);
					this.SendPropertyChanging();
					this._f_name = value;
					this.SendPropertyChanged("f_name");
					this.Onf_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_update", DbType="DateTime NOT NULL")]
		public System.DateTime f_update
		{
			get
			{
				return this._f_update;
			}
			set
			{
				if ((this._f_update != value))
				{
					this.Onf_updateChanging(value);
					this.SendPropertyChanging();
					this._f_update = value;
					this.SendPropertyChanged("f_update");
					this.Onf_updateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_prefix", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string f_prefix
		{
			get
			{
				return this._f_prefix;
			}
			set
			{
				if ((this._f_prefix != value))
				{
					this.Onf_prefixChanging(value);
					this.SendPropertyChanging();
					this._f_prefix = value;
					this.SendPropertyChanged("f_prefix");
					this.Onf_prefixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_version", DbType="NChar(32) NOT NULL", CanBeNull=false)]
		public string f_version
		{
			get
			{
				return this._f_version;
			}
			set
			{
				if ((this._f_version != value))
				{
					this.Onf_versionChanging(value);
					this.SendPropertyChanging();
					this._f_version = value;
					this.SendPropertyChanged("f_version");
					this.Onf_versionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_director")]
	public partial class t_director : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _f_javlib_id;
		
		private string _f_name;
		
		private System.DateTime _f_update;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onf_javlib_idChanging(string value);
    partial void Onf_javlib_idChanged();
    partial void Onf_nameChanging(string value);
    partial void Onf_nameChanged();
    partial void Onf_updateChanging(System.DateTime value);
    partial void Onf_updateChanged();
    #endregion
		
		public t_director()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_javlib_id", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string f_javlib_id
		{
			get
			{
				return this._f_javlib_id;
			}
			set
			{
				if ((this._f_javlib_id != value))
				{
					this.Onf_javlib_idChanging(value);
					this.SendPropertyChanging();
					this._f_javlib_id = value;
					this.SendPropertyChanged("f_javlib_id");
					this.Onf_javlib_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string f_name
		{
			get
			{
				return this._f_name;
			}
			set
			{
				if ((this._f_name != value))
				{
					this.Onf_nameChanging(value);
					this.SendPropertyChanging();
					this._f_name = value;
					this.SendPropertyChanged("f_name");
					this.Onf_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_update", DbType="DateTime NOT NULL")]
		public System.DateTime f_update
		{
			get
			{
				return this._f_update;
			}
			set
			{
				if ((this._f_update != value))
				{
					this.Onf_updateChanging(value);
					this.SendPropertyChanging();
					this._f_update = value;
					this.SendPropertyChanged("f_update");
					this.Onf_updateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_factory")]
	public partial class t_factory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _f_javlib_id;
		
		private string _f_name;
		
		private System.DateTime _f_update;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onf_javlib_idChanging(string value);
    partial void Onf_javlib_idChanged();
    partial void Onf_nameChanging(string value);
    partial void Onf_nameChanged();
    partial void Onf_updateChanging(System.DateTime value);
    partial void Onf_updateChanged();
    #endregion
		
		public t_factory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_javlib_id", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string f_javlib_id
		{
			get
			{
				return this._f_javlib_id;
			}
			set
			{
				if ((this._f_javlib_id != value))
				{
					this.Onf_javlib_idChanging(value);
					this.SendPropertyChanging();
					this._f_javlib_id = value;
					this.SendPropertyChanged("f_javlib_id");
					this.Onf_javlib_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string f_name
		{
			get
			{
				return this._f_name;
			}
			set
			{
				if ((this._f_name != value))
				{
					this.Onf_nameChanging(value);
					this.SendPropertyChanging();
					this._f_name = value;
					this.SendPropertyChanged("f_name");
					this.Onf_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_update", DbType="DateTime NOT NULL")]
		public System.DateTime f_update
		{
			get
			{
				return this._f_update;
			}
			set
			{
				if ((this._f_update != value))
				{
					this.Onf_updateChanging(value);
					this.SendPropertyChanging();
					this._f_update = value;
					this.SendPropertyChanged("f_update");
					this.Onf_updateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_issuer")]
	public partial class t_issuer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _f_javlib_id;
		
		private string _f_name;
		
		private System.DateTime _f_update;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onf_javlib_idChanging(string value);
    partial void Onf_javlib_idChanged();
    partial void Onf_nameChanging(string value);
    partial void Onf_nameChanged();
    partial void Onf_updateChanging(System.DateTime value);
    partial void Onf_updateChanged();
    #endregion
		
		public t_issuer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_javlib_id", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string f_javlib_id
		{
			get
			{
				return this._f_javlib_id;
			}
			set
			{
				if ((this._f_javlib_id != value))
				{
					this.Onf_javlib_idChanging(value);
					this.SendPropertyChanging();
					this._f_javlib_id = value;
					this.SendPropertyChanged("f_javlib_id");
					this.Onf_javlib_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string f_name
		{
			get
			{
				return this._f_name;
			}
			set
			{
				if ((this._f_name != value))
				{
					this.Onf_nameChanging(value);
					this.SendPropertyChanging();
					this._f_name = value;
					this.SendPropertyChanged("f_name");
					this.Onf_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_update", DbType="DateTime NOT NULL")]
		public System.DateTime f_update
		{
			get
			{
				return this._f_update;
			}
			set
			{
				if ((this._f_update != value))
				{
					this.Onf_updateChanging(value);
					this.SendPropertyChanging();
					this._f_update = value;
					this.SendPropertyChanged("f_update");
					this.Onf_updateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_video")]
	public partial class t_video : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _f_javlib_id;
		
		private System.Nullable<int> _f_director;
		
		private double _f_length;
		
		private System.DateTime _f_issuer_date;
		
		private int _f_issuer;
		
		private string _f_code;
		
		private string _f_name;
		
		private int _f_factory;
		
		private System.DateTime _f_update;
		
		private string _f_version;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onf_javlib_idChanging(string value);
    partial void Onf_javlib_idChanged();
    partial void Onf_directorChanging(System.Nullable<int> value);
    partial void Onf_directorChanged();
    partial void Onf_lengthChanging(double value);
    partial void Onf_lengthChanged();
    partial void Onf_issuer_dateChanging(System.DateTime value);
    partial void Onf_issuer_dateChanged();
    partial void Onf_issuerChanging(int value);
    partial void Onf_issuerChanged();
    partial void Onf_codeChanging(string value);
    partial void Onf_codeChanged();
    partial void Onf_nameChanging(string value);
    partial void Onf_nameChanged();
    partial void Onf_factoryChanging(int value);
    partial void Onf_factoryChanged();
    partial void Onf_updateChanging(System.DateTime value);
    partial void Onf_updateChanged();
    partial void Onf_versionChanging(string value);
    partial void Onf_versionChanged();
    #endregion
		
		public t_video()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_javlib_id", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string f_javlib_id
		{
			get
			{
				return this._f_javlib_id;
			}
			set
			{
				if ((this._f_javlib_id != value))
				{
					this.Onf_javlib_idChanging(value);
					this.SendPropertyChanging();
					this._f_javlib_id = value;
					this.SendPropertyChanged("f_javlib_id");
					this.Onf_javlib_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_director", DbType="Int")]
		public System.Nullable<int> f_director
		{
			get
			{
				return this._f_director;
			}
			set
			{
				if ((this._f_director != value))
				{
					this.Onf_directorChanging(value);
					this.SendPropertyChanging();
					this._f_director = value;
					this.SendPropertyChanged("f_director");
					this.Onf_directorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_length", DbType="Float NOT NULL")]
		public double f_length
		{
			get
			{
				return this._f_length;
			}
			set
			{
				if ((this._f_length != value))
				{
					this.Onf_lengthChanging(value);
					this.SendPropertyChanging();
					this._f_length = value;
					this.SendPropertyChanged("f_length");
					this.Onf_lengthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_issuer_date", DbType="Date NOT NULL")]
		public System.DateTime f_issuer_date
		{
			get
			{
				return this._f_issuer_date;
			}
			set
			{
				if ((this._f_issuer_date != value))
				{
					this.Onf_issuer_dateChanging(value);
					this.SendPropertyChanging();
					this._f_issuer_date = value;
					this.SendPropertyChanged("f_issuer_date");
					this.Onf_issuer_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_issuer", DbType="Int NOT NULL")]
		public int f_issuer
		{
			get
			{
				return this._f_issuer;
			}
			set
			{
				if ((this._f_issuer != value))
				{
					this.Onf_issuerChanging(value);
					this.SendPropertyChanging();
					this._f_issuer = value;
					this.SendPropertyChanged("f_issuer");
					this.Onf_issuerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_code", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string f_code
		{
			get
			{
				return this._f_code;
			}
			set
			{
				if ((this._f_code != value))
				{
					this.Onf_codeChanging(value);
					this.SendPropertyChanging();
					this._f_code = value;
					this.SendPropertyChanged("f_code");
					this.Onf_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string f_name
		{
			get
			{
				return this._f_name;
			}
			set
			{
				if ((this._f_name != value))
				{
					this.Onf_nameChanging(value);
					this.SendPropertyChanging();
					this._f_name = value;
					this.SendPropertyChanged("f_name");
					this.Onf_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_factory", DbType="Int NOT NULL")]
		public int f_factory
		{
			get
			{
				return this._f_factory;
			}
			set
			{
				if ((this._f_factory != value))
				{
					this.Onf_factoryChanging(value);
					this.SendPropertyChanging();
					this._f_factory = value;
					this.SendPropertyChanged("f_factory");
					this.Onf_factoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_update", DbType="DateTime NOT NULL")]
		public System.DateTime f_update
		{
			get
			{
				return this._f_update;
			}
			set
			{
				if ((this._f_update != value))
				{
					this.Onf_updateChanging(value);
					this.SendPropertyChanging();
					this._f_update = value;
					this.SendPropertyChanged("f_update");
					this.Onf_updateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_version", DbType="NChar(32) NOT NULL", CanBeNull=false)]
		public string f_version
		{
			get
			{
				return this._f_version;
			}
			set
			{
				if ((this._f_version != value))
				{
					this.Onf_versionChanging(value);
					this.SendPropertyChanging();
					this._f_version = value;
					this.SendPropertyChanged("f_version");
					this.Onf_versionChanged();
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
