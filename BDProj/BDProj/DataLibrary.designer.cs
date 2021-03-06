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

namespace BDProj
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Library")]
	public partial class DataLibraryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBorrowing(Borrowing instance);
    partial void UpdateBorrowing(Borrowing instance);
    partial void DeleteBorrowing(Borrowing instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);

    partial void InsertAuthorList(AuthorList instance);
    partial void UpdateAuthorList(AuthorList instance);
    partial void DeleteAuthorList(AuthorList instance);
    #endregion
		
		public DataLibraryDataContext() : 
				base(global::BDProj.Properties.Settings.Default.LibraryConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataLibraryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLibraryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLibraryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLibraryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<Borrowing> Borrowings
		{
			get
			{
				return this.GetTable<Borrowing>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Spoznieni> Spoznienis
		{
			get
			{
				return this.GetTable<Spoznieni>();
			}
		}
		
		public System.Data.Linq.Table<wypozyczenia> wypozyczenias
		{
			get
			{
				return this.GetTable<wypozyczenia>();
			}
		}
		

		public System.Data.Linq.Table<AuthorList> AuthorLists
		{
			get
			{
				return this.GetTable<AuthorList>();

			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Author")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Firstname;
		
		private string _Lastname;
		
		private EntitySet<AuthorList> _AuthorLists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstnameChanging(string value);
    partial void OnFirstnameChanged();
    partial void OnLastnameChanging(string value);
    partial void OnLastnameChanged();
    #endregion
		
		public Author()
		{
			this._AuthorLists = new EntitySet<AuthorList>(new Action<AuthorList>(this.attach_AuthorLists), new Action<AuthorList>(this.detach_AuthorLists));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this.OnFirstnameChanging(value);
					this.SendPropertyChanging();
					this._Firstname = value;
					this.SendPropertyChanged("Firstname");
					this.OnFirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this.OnLastnameChanging(value);
					this.SendPropertyChanging();
					this._Lastname = value;
					this.SendPropertyChanged("Lastname");
					this.OnLastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_AuthorList", Storage="_AuthorLists", ThisKey="Id", OtherKey="AuthorId")]
		public EntitySet<AuthorList> AuthorLists
		{
			get
			{
				return this._AuthorLists;
			}
			set
			{
				this._AuthorLists.Assign(value);
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
		
		private void attach_AuthorLists(AuthorList entity)
		{
			this.SendPropertyChanging();
			entity.Author = this;
		}
		
		private void detach_AuthorLists(AuthorList entity)
		{
			this.SendPropertyChanging();
			entity.Author = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _ISBN;
		
		private string _Genre;
		
		private System.DateTime _DateOfAdd;
		
		private EntitySet<Copy> _Copies;
		
		private EntitySet<AuthorList> _AuthorLists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnISBNChanging(string value);
    partial void OnISBNChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnDateOfAddChanging(System.DateTime value);
    partial void OnDateOfAddChanged();
    #endregion
		
		public Book()
		{
			this._Copies = new EntitySet<Copy>(new Action<Copy>(this.attach_Copies), new Action<Copy>(this.detach_Copies));
			this._AuthorLists = new EntitySet<AuthorList>(new Action<AuthorList>(this.attach_AuthorLists), new Action<AuthorList>(this.detach_AuthorLists));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISBN", DbType="NVarChar(15)")]
		public string ISBN
		{
			get
			{
				return this._ISBN;
			}
			set
			{
				if ((this._ISBN != value))
				{
					this.OnISBNChanging(value);
					this.SendPropertyChanging();
					this._ISBN = value;
					this.SendPropertyChanged("ISBN");
					this.OnISBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(31)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfAdd", DbType="Date NOT NULL")]
		public System.DateTime DateOfAdd
		{
			get
			{
				return this._DateOfAdd;
			}
			set
			{
				if ((this._DateOfAdd != value))
				{
					this.OnDateOfAddChanging(value);
					this.SendPropertyChanging();
					this._DateOfAdd = value;
					this.SendPropertyChanged("DateOfAdd");
					this.OnDateOfAddChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Copy", Storage="_Copies", ThisKey="Id", OtherKey="BookId")]
		public EntitySet<Copy> Copies
		{
			get
			{
				return this._Copies;
			}
			set
			{
				this._Copies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_AuthorList", Storage="_AuthorLists", ThisKey="Id", OtherKey="BookId")]
		public EntitySet<AuthorList> AuthorLists
		{
			get
			{
				return this._AuthorLists;
			}
			set
			{
				this._AuthorLists.Assign(value);
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
		
		private void attach_Copies(Copy entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_Copies(Copy entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
		
		private void attach_AuthorLists(AuthorList entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_AuthorLists(AuthorList entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Borrowings")]
	public partial class Borrowing : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _CopyId;
		
		private int _UserId;
		
		private System.DateTime _BorrowDate;
		
		private int _BorrowDays;
		
		private System.DateTime _ReturnDate;
		
		private EntityRef<User> _User;
		
		private EntityRef<Copy> _Copy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCopyIdChanging(int value);
    partial void OnCopyIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnBorrowDateChanging(System.DateTime value);
    partial void OnBorrowDateChanged();
    partial void OnBorrowDaysChanging(int value);
    partial void OnBorrowDaysChanged();
    partial void OnReturnDateChanging(System.DateTime value);
    partial void OnReturnDateChanged();
    #endregion
		
		public Borrowing()
		{
			this._User = default(EntityRef<User>);
			this._Copy = default(EntityRef<Copy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CopyId", DbType="Int NOT NULL")]
		public int CopyId
		{
			get
			{
				return this._CopyId;
			}
			set
			{
				if ((this._CopyId != value))
				{
					if (this._Copy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCopyIdChanging(value);
					this.SendPropertyChanging();
					this._CopyId = value;
					this.SendPropertyChanged("CopyId");
					this.OnCopyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BorrowDate", DbType="Date NOT NULL")]
		public System.DateTime BorrowDate
		{
			get
			{
				return this._BorrowDate;
			}
			set
			{
				if ((this._BorrowDate != value))
				{
					this.OnBorrowDateChanging(value);
					this.SendPropertyChanging();
					this._BorrowDate = value;
					this.SendPropertyChanged("BorrowDate");
					this.OnBorrowDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BorrowDays", DbType="Int NOT NULL")]
		public int BorrowDays
		{
			get
			{
				return this._BorrowDays;
			}
			set
			{
				if ((this._BorrowDays != value))
				{
					this.OnBorrowDaysChanging(value);
					this.SendPropertyChanging();
					this._BorrowDays = value;
					this.SendPropertyChanged("BorrowDays");
					this.OnBorrowDaysChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="Date NOT NULL")]
		public System.DateTime ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this.OnReturnDateChanging(value);
					this.SendPropertyChanging();
					this._ReturnDate = value;
					this.SendPropertyChanged("ReturnDate");
					this.OnReturnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Borrowing", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Borrowings.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Borrowings.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Copy_Borrowing", Storage="_Copy", ThisKey="CopyId", OtherKey="Id", IsForeignKey=true)]
		public Copy Copy
		{
			get
			{
				return this._Copy.Entity;
			}
			set
			{
				Copy previousValue = this._Copy.Entity;
				if (((previousValue != value) 
							|| (this._Copy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Copy.Entity = null;
						previousValue.Borrowings.Remove(this);
					}
					this._Copy.Entity = value;
					if ((value != null))
					{
						value.Borrowings.Add(this);
						this._CopyId = value.Id;
					}
					else
					{
						this._CopyId = default(int);
					}
					this.SendPropertyChanged("Copy");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Firstname;
		
		private string _Lastname;
		
		private string _Email;
		
		private string _Phone;
		
		private string _Address;
		
		private string _City;
		
		private string _Country;
		
		private string _ZipCode;
		
		private char _Status;
		
		private string _Password;
		
		private EntitySet<Borrowing> _Borrowings;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstnameChanging(string value);
    partial void OnFirstnameChanged();
    partial void OnLastnameChanging(string value);
    partial void OnLastnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnStatusChanging(char value);
    partial void OnStatusChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			this._Borrowings = new EntitySet<Borrowing>(new Action<Borrowing>(this.attach_Borrowings), new Action<Borrowing>(this.detach_Borrowings));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this.OnFirstnameChanging(value);
					this.SendPropertyChanging();
					this._Firstname = value;
					this.SendPropertyChanged("Firstname");
					this.OnFirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this.OnLastnameChanging(value);
					this.SendPropertyChanging();
					this._Lastname = value;
					this.SendPropertyChanged("Lastname");
					this.OnLastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(31) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="NVarChar(7) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Char(1) NOT NULL")]
		public char Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Borrowing", Storage="_Borrowings", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Borrowing> Borrowings
		{
			get
			{
				return this._Borrowings;
			}
			set
			{
				this._Borrowings.Assign(value);
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
		
		private void attach_Borrowings(Borrowing entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Borrowings(Borrowing entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Spoznieni")]
	public partial class Spoznieni
	{
		
		private string _Firstname;
		
		private string _Lastname;
		
		private int _CopyId;
		
		private System.DateTime _ReturnDate;
		
		private string _Name;
		
		public Spoznieni()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this._Firstname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this._Lastname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CopyId", DbType="Int NOT NULL")]
		public int CopyId
		{
			get
			{
				return this._CopyId;
			}
			set
			{
				if ((this._CopyId != value))
				{
					this._CopyId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="Date NOT NULL")]
		public System.DateTime ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this._ReturnDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.wypozyczenia")]
	public partial class wypozyczenia
	{
		
		private string _Firstname;
		
		private string _Lastname;
		
		private int _CopyId;
		
		private System.DateTime _ReturnDate;
		
		private string _Name;
		
		public wypozyczenia()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this._Firstname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this._Lastname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CopyId", DbType="Int NOT NULL")]
		public int CopyId
		{
			get
			{
				return this._CopyId;
			}
			set
			{
				if ((this._CopyId != value))
				{
					this._CopyId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="Date NOT NULL")]
		public System.DateTime ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this._ReturnDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(63) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	

	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AuthorList")]
	public partial class AuthorList : INotifyPropertyChanging, INotifyPropertyChanged

	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		private int _AuthorId;
		
		private int _BookId;
		
		private int _Id;
		
		private EntityRef<Author> _Author;

		
		private EntityRef<Book> _Book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();

    partial void OnAuthorIdChanging(int value);
    partial void OnAuthorIdChanged();
    partial void OnBookIdChanging(int value);
    partial void OnBookIdChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    #endregion
		
		public AuthorList()
		{
			this._Author = default(EntityRef<Author>);

			this._Book = default(EntityRef<Book>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorId", DbType="Int NOT NULL")]
		public int AuthorId
		{
			get
			{
				return this._AuthorId;
			}
			set
			{
				if ((this._AuthorId != value))
				{
					if (this._Author.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorIdChanging(value);
					this.SendPropertyChanging();
					this._AuthorId = value;
					this.SendPropertyChanged("AuthorId");
					this.OnAuthorIdChanged();

				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", DbType="Int NOT NULL")]
		public int BookId
		{
			get
			{
				return this._BookId;
			}
			set
			{
				if ((this._BookId != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookIdChanging(value);
					this.SendPropertyChanging();
					this._BookId = value;
					this.SendPropertyChanged("BookId");
					this.OnBookIdChanged();
				}
			}
		}
		

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_AuthorList", Storage="_Author", ThisKey="AuthorId", OtherKey="Id", IsForeignKey=true)]
		public Author Author
		{
			get
			{
				return this._Author.Entity;
			}
			set
			{
				Author previousValue = this._Author.Entity;
				if (((previousValue != value) 
							|| (this._Author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Author.Entity = null;
						previousValue.AuthorLists.Remove(this);
					}
					this._Author.Entity = value;
					if ((value != null))
					{
						value.AuthorLists.Add(this);
						this._AuthorId = value.Id;
					}
					else
					{
						this._AuthorId = default(int);
					}
					this.SendPropertyChanged("Author");

				}
			}
		}
		

		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_AuthorList", Storage="_Book", ThisKey="BookId", OtherKey="Id", IsForeignKey=true)]

		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;

						previousValue.AuthorLists.Remove(this);

					}
					this._Book.Entity = value;
					if ((value != null))
					{

						value.AuthorLists.Add(this);

						this._BookId = value.Id;
					}
					else
					{
						this._BookId = default(int);
					}
					this.SendPropertyChanged("Book");
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
