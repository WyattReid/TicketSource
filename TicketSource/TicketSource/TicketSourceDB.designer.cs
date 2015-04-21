﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketSource
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TicketSourceDB")]
	public partial class TicketSourceDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAspNetUser(AspNetUser instance);
    partial void UpdateAspNetUser(AspNetUser instance);
    partial void DeleteAspNetUser(AspNetUser instance);
    partial void InsertTicket(Ticket instance);
    partial void UpdateTicket(Ticket instance);
    partial void DeleteTicket(Ticket instance);
    partial void InsertUserTicket(UserTicket instance);
    partial void UpdateUserTicket(UserTicket instance);
    partial void DeleteUserTicket(UserTicket instance);
    partial void InsertGame(Game instance);
    partial void UpdateGame(Game instance);
    partial void DeleteGame(Game instance);
    #endregion
		
		public TicketSourceDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TicketSourceDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketSourceDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketSourceDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketSourceDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AspNetUser> AspNetUsers
		{
			get
			{
				return this.GetTable<AspNetUser>();
			}
		}
		
		public System.Data.Linq.Table<Ticket> Tickets
		{
			get
			{
				return this.GetTable<Ticket>();
			}
		}
		
		public System.Data.Linq.Table<UserTicket> UserTickets
		{
			get
			{
				return this.GetTable<UserTicket>();
			}
		}
		
		public System.Data.Linq.Table<Game> Games
		{
			get
			{
				return this.GetTable<Game>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUsers")]
	public partial class AspNetUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private bool _IsStudent;
		
		private string _Email;
		
		private bool _EmailConfirmed;
		
		private string _PasswordHash;
		
		private string _SecurityStamp;
		
		private string _PhoneNumber;
		
		private bool _PhoneNumberConfirmed;
		
		private bool _TwoFactorEnabled;
		
		private System.Nullable<System.DateTime> _LockoutEndDateUtc;
		
		private bool _LockoutEnabled;
		
		private int _AccessFailedCount;
		
		private string _UserName;
		
		private string _StreetAddress;
		
		private string _City;
		
		private string _State;
		
		private string _ZipCode;
		
		private string _Url;
		
		private EntitySet<UserTicket> _UserTickets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnIsStudentChanging(bool value);
    partial void OnIsStudentChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnEmailConfirmedChanging(bool value);
    partial void OnEmailConfirmedChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnSecurityStampChanging(string value);
    partial void OnSecurityStampChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnPhoneNumberConfirmedChanging(bool value);
    partial void OnPhoneNumberConfirmedChanged();
    partial void OnTwoFactorEnabledChanging(bool value);
    partial void OnTwoFactorEnabledChanged();
    partial void OnLockoutEndDateUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnLockoutEndDateUtcChanged();
    partial void OnLockoutEnabledChanging(bool value);
    partial void OnLockoutEnabledChanged();
    partial void OnAccessFailedCountChanging(int value);
    partial void OnAccessFailedCountChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnStreetAddressChanging(string value);
    partial void OnStreetAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    #endregion
		
		public AspNetUser()
		{
			this._UserTickets = new EntitySet<UserTicket>(new Action<UserTicket>(this.attach_UserTickets), new Action<UserTicket>(this.detach_UserTickets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsStudent", DbType="Bit NOT NULL")]
		public bool IsStudent
		{
			get
			{
				return this._IsStudent;
			}
			set
			{
				if ((this._IsStudent != value))
				{
					this.OnIsStudentChanging(value);
					this.SendPropertyChanging();
					this._IsStudent = value;
					this.SendPropertyChanged("IsStudent");
					this.OnIsStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailConfirmed", DbType="Bit NOT NULL")]
		public bool EmailConfirmed
		{
			get
			{
				return this._EmailConfirmed;
			}
			set
			{
				if ((this._EmailConfirmed != value))
				{
					this.OnEmailConfirmedChanging(value);
					this.SendPropertyChanging();
					this._EmailConfirmed = value;
					this.SendPropertyChanged("EmailConfirmed");
					this.OnEmailConfirmedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="NVarChar(MAX)")]
		public string PasswordHash
		{
			get
			{
				return this._PasswordHash;
			}
			set
			{
				if ((this._PasswordHash != value))
				{
					this.OnPasswordHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordHash = value;
					this.SendPropertyChanged("PasswordHash");
					this.OnPasswordHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecurityStamp", DbType="NVarChar(MAX)")]
		public string SecurityStamp
		{
			get
			{
				return this._SecurityStamp;
			}
			set
			{
				if ((this._SecurityStamp != value))
				{
					this.OnSecurityStampChanging(value);
					this.SendPropertyChanging();
					this._SecurityStamp = value;
					this.SendPropertyChanged("SecurityStamp");
					this.OnSecurityStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(MAX)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumberConfirmed", DbType="Bit NOT NULL")]
		public bool PhoneNumberConfirmed
		{
			get
			{
				return this._PhoneNumberConfirmed;
			}
			set
			{
				if ((this._PhoneNumberConfirmed != value))
				{
					this.OnPhoneNumberConfirmedChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumberConfirmed = value;
					this.SendPropertyChanged("PhoneNumberConfirmed");
					this.OnPhoneNumberConfirmedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TwoFactorEnabled", DbType="Bit NOT NULL")]
		public bool TwoFactorEnabled
		{
			get
			{
				return this._TwoFactorEnabled;
			}
			set
			{
				if ((this._TwoFactorEnabled != value))
				{
					this.OnTwoFactorEnabledChanging(value);
					this.SendPropertyChanging();
					this._TwoFactorEnabled = value;
					this.SendPropertyChanged("TwoFactorEnabled");
					this.OnTwoFactorEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEndDateUtc", DbType="DateTime")]
		public System.Nullable<System.DateTime> LockoutEndDateUtc
		{
			get
			{
				return this._LockoutEndDateUtc;
			}
			set
			{
				if ((this._LockoutEndDateUtc != value))
				{
					this.OnLockoutEndDateUtcChanging(value);
					this.SendPropertyChanging();
					this._LockoutEndDateUtc = value;
					this.SendPropertyChanged("LockoutEndDateUtc");
					this.OnLockoutEndDateUtcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEnabled", DbType="Bit NOT NULL")]
		public bool LockoutEnabled
		{
			get
			{
				return this._LockoutEnabled;
			}
			set
			{
				if ((this._LockoutEnabled != value))
				{
					this.OnLockoutEnabledChanging(value);
					this.SendPropertyChanging();
					this._LockoutEnabled = value;
					this.SendPropertyChanged("LockoutEnabled");
					this.OnLockoutEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessFailedCount", DbType="Int NOT NULL")]
		public int AccessFailedCount
		{
			get
			{
				return this._AccessFailedCount;
			}
			set
			{
				if ((this._AccessFailedCount != value))
				{
					this.OnAccessFailedCountChanging(value);
					this.SendPropertyChanging();
					this._AccessFailedCount = value;
					this.SendPropertyChanged("AccessFailedCount");
					this.OnAccessFailedCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreetAddress", DbType="NVarChar(MAX)")]
		public string StreetAddress
		{
			get
			{
				return this._StreetAddress;
			}
			set
			{
				if ((this._StreetAddress != value))
				{
					this.OnStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._StreetAddress = value;
					this.SendPropertyChanged("StreetAddress");
					this.OnStreetAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(MAX)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(MAX)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="NVarChar(MAX)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX)")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_UserTicket", Storage="_UserTickets", ThisKey="Id", OtherKey="UserID")]
		public EntitySet<UserTicket> UserTickets
		{
			get
			{
				return this._UserTickets;
			}
			set
			{
				this._UserTickets.Assign(value);
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
		
		private void attach_UserTickets(UserTicket entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_UserTickets(UserTicket entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tickets")]
	public partial class Ticket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TicketID;
		
		private string _Row;
		
		private string _Seat;
		
		private decimal _PriceWanted;
		
		private string _Section;
		
		private string _SellerID;
		
		private string _Opponent;
		
		private bool _Active;
		
		private decimal _SellingPrice;
		
		private bool _Paid;
		
		private decimal _StudentPrice;
		
		private string _BuyerID;
		
		private EntityRef<UserTicket> _UserTicket;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTicketIDChanging(int value);
    partial void OnTicketIDChanged();
    partial void OnRowChanging(string value);
    partial void OnRowChanged();
    partial void OnSeatChanging(string value);
    partial void OnSeatChanged();
    partial void OnPriceWantedChanging(decimal value);
    partial void OnPriceWantedChanged();
    partial void OnSectionChanging(string value);
    partial void OnSectionChanged();
    partial void OnSellerIDChanging(string value);
    partial void OnSellerIDChanged();
    partial void OnOpponentChanging(string value);
    partial void OnOpponentChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    partial void OnSellingPriceChanging(decimal value);
    partial void OnSellingPriceChanged();
    partial void OnPaidChanging(bool value);
    partial void OnPaidChanged();
    partial void OnStudentPriceChanging(decimal value);
    partial void OnStudentPriceChanged();
    partial void OnBuyerIDChanging(string value);
    partial void OnBuyerIDChanged();
    #endregion
		
		public Ticket()
		{
			this._UserTicket = default(EntityRef<UserTicket>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TicketID
		{
			get
			{
				return this._TicketID;
			}
			set
			{
				if ((this._TicketID != value))
				{
					this.OnTicketIDChanging(value);
					this.SendPropertyChanging();
					this._TicketID = value;
					this.SendPropertyChanged("TicketID");
					this.OnTicketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Row", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string Row
		{
			get
			{
				return this._Row;
			}
			set
			{
				if ((this._Row != value))
				{
					this.OnRowChanging(value);
					this.SendPropertyChanging();
					this._Row = value;
					this.SendPropertyChanged("Row");
					this.OnRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seat", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string Seat
		{
			get
			{
				return this._Seat;
			}
			set
			{
				if ((this._Seat != value))
				{
					this.OnSeatChanging(value);
					this.SendPropertyChanging();
					this._Seat = value;
					this.SendPropertyChanged("Seat");
					this.OnSeatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceWanted", DbType="Decimal(18,0) NOT NULL")]
		public decimal PriceWanted
		{
			get
			{
				return this._PriceWanted;
			}
			set
			{
				if ((this._PriceWanted != value))
				{
					this.OnPriceWantedChanging(value);
					this.SendPropertyChanging();
					this._PriceWanted = value;
					this.SendPropertyChanged("PriceWanted");
					this.OnPriceWantedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Section", CanBeNull=false)]
		public string Section
		{
			get
			{
				return this._Section;
			}
			set
			{
				if ((this._Section != value))
				{
					this.OnSectionChanging(value);
					this.SendPropertyChanging();
					this._Section = value;
					this.SendPropertyChanged("Section");
					this.OnSectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellerID", CanBeNull=false)]
		public string SellerID
		{
			get
			{
				return this._SellerID;
			}
			set
			{
				if ((this._SellerID != value))
				{
					this.OnSellerIDChanging(value);
					this.SendPropertyChanging();
					this._SellerID = value;
					this.SendPropertyChanged("SellerID");
					this.OnSellerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opponent", CanBeNull=false)]
		public string Opponent
		{
			get
			{
				return this._Opponent;
			}
			set
			{
				if ((this._Opponent != value))
				{
					this.OnOpponentChanging(value);
					this.SendPropertyChanging();
					this._Opponent = value;
					this.SendPropertyChanged("Opponent");
					this.OnOpponentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellingPrice")]
		public decimal SellingPrice
		{
			get
			{
				return this._SellingPrice;
			}
			set
			{
				if ((this._SellingPrice != value))
				{
					this.OnSellingPriceChanging(value);
					this.SendPropertyChanging();
					this._SellingPrice = value;
					this.SendPropertyChanged("SellingPrice");
					this.OnSellingPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paid")]
		public bool Paid
		{
			get
			{
				return this._Paid;
			}
			set
			{
				if ((this._Paid != value))
				{
					this.OnPaidChanging(value);
					this.SendPropertyChanging();
					this._Paid = value;
					this.SendPropertyChanged("Paid");
					this.OnPaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentPrice")]
		public decimal StudentPrice
		{
			get
			{
				return this._StudentPrice;
			}
			set
			{
				if ((this._StudentPrice != value))
				{
					this.OnStudentPriceChanging(value);
					this.SendPropertyChanging();
					this._StudentPrice = value;
					this.SendPropertyChanged("StudentPrice");
					this.OnStudentPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyerID", CanBeNull=false)]
		public string BuyerID
		{
			get
			{
				return this._BuyerID;
			}
			set
			{
				if ((this._BuyerID != value))
				{
					this.OnBuyerIDChanging(value);
					this.SendPropertyChanging();
					this._BuyerID = value;
					this.SendPropertyChanged("BuyerID");
					this.OnBuyerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ticket_UserTicket", Storage="_UserTicket", ThisKey="TicketID", OtherKey="TicketID", IsUnique=true, IsForeignKey=false)]
		public UserTicket UserTicket
		{
			get
			{
				return this._UserTicket.Entity;
			}
			set
			{
				UserTicket previousValue = this._UserTicket.Entity;
				if (((previousValue != value) 
							|| (this._UserTicket.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserTicket.Entity = null;
						previousValue.Ticket = null;
					}
					this._UserTicket.Entity = value;
					if ((value != null))
					{
						value.Ticket = this;
					}
					this.SendPropertyChanged("UserTicket");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserTickets")]
	public partial class UserTicket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TicketID;
		
		private string _UserID;
		
		private EntityRef<Ticket> _Ticket;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTicketIDChanging(int value);
    partial void OnTicketIDChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    #endregion
		
		public UserTicket()
		{
			this._Ticket = default(EntityRef<Ticket>);
			this._AspNetUser = default(EntityRef<AspNetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TicketID
		{
			get
			{
				return this._TicketID;
			}
			set
			{
				if ((this._TicketID != value))
				{
					if (this._Ticket.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTicketIDChanging(value);
					this.SendPropertyChanging();
					this._TicketID = value;
					this.SendPropertyChanged("TicketID");
					this.OnTicketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ticket_UserTicket", Storage="_Ticket", ThisKey="TicketID", OtherKey="TicketID", IsForeignKey=true)]
		public Ticket Ticket
		{
			get
			{
				return this._Ticket.Entity;
			}
			set
			{
				Ticket previousValue = this._Ticket.Entity;
				if (((previousValue != value) 
							|| (this._Ticket.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ticket.Entity = null;
						previousValue.UserTicket = null;
					}
					this._Ticket.Entity = value;
					if ((value != null))
					{
						value.UserTicket = this;
						this._TicketID = value.TicketID;
					}
					else
					{
						this._TicketID = default(int);
					}
					this.SendPropertyChanged("Ticket");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_UserTicket", Storage="_AspNetUser", ThisKey="UserID", OtherKey="Id", IsForeignKey=true)]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.UserTickets.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.UserTickets.Add(this);
						this._UserID = value.Id;
					}
					else
					{
						this._UserID = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Games")]
	public partial class Game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Week;
		
		private string _Opponent;
		
		private System.DateTime _Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWeekChanging(int value);
    partial void OnWeekChanged();
    partial void OnOpponentChanging(string value);
    partial void OnOpponentChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Game()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Week", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Week
		{
			get
			{
				return this._Week;
			}
			set
			{
				if ((this._Week != value))
				{
					this.OnWeekChanging(value);
					this.SendPropertyChanging();
					this._Week = value;
					this.SendPropertyChanged("Week");
					this.OnWeekChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opponent", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Opponent
		{
			get
			{
				return this._Opponent;
			}
			set
			{
				if ((this._Opponent != value))
				{
					this.OnOpponentChanging(value);
					this.SendPropertyChanging();
					this._Opponent = value;
					this.SendPropertyChanged("Opponent");
					this.OnOpponentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
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
