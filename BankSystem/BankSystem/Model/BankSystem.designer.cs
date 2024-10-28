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

namespace BankSystem.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BankSystem")]
	public partial class BankSystemDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertBankTransaction(BankTransaction instance);
    partial void UpdateBankTransaction(BankTransaction instance);
    partial void DeleteBankTransaction(BankTransaction instance);
    partial void InsertBranch(Branch instance);
    partial void UpdateBranch(Branch instance);
    partial void DeleteBranch(Branch instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public BankSystemDataContext() : 
				base(global::BankSystem.Properties.Settings.Default.BankSystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BankSystemDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankSystemDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankSystemDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankSystemDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<BankTransaction> BankTransactions
		{
			get
			{
				return this.GetTable<BankTransaction>();
			}
		}
		
		public System.Data.Linq.Table<Branch> Branches
		{
			get
			{
				return this.GetTable<Branch>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CustomerId;
		
		private System.Nullable<System.DateTime> _DateOpened;
		
		private System.Nullable<double> _Balance;
		
		private EntitySet<BankTransaction> _BankTransactions;
		
		private EntitySet<BankTransaction> _BankTransactions1;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCustomerIdChanging(string value);
    partial void OnCustomerIdChanged();
    partial void OnDateOpenedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOpenedChanged();
    partial void OnBalanceChanging(System.Nullable<double> value);
    partial void OnBalanceChanged();
    #endregion
		
		public Account()
		{
			this._BankTransactions = new EntitySet<BankTransaction>(new Action<BankTransaction>(this.attach_BankTransactions), new Action<BankTransaction>(this.detach_BankTransactions));
			this._BankTransactions1 = new EntitySet<BankTransaction>(new Action<BankTransaction>(this.attach_BankTransactions1), new Action<BankTransaction>(this.detach_BankTransactions1));
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="VarChar(255)")]
		public string CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOpened", DbType="Date")]
		public System.Nullable<System.DateTime> DateOpened
		{
			get
			{
				return this._DateOpened;
			}
			set
			{
				if ((this._DateOpened != value))
				{
					this.OnDateOpenedChanging(value);
					this.SendPropertyChanging();
					this._DateOpened = value;
					this.SendPropertyChanged("DateOpened");
					this.OnDateOpenedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Float")]
		public System.Nullable<double> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_BankTransaction", Storage="_BankTransactions", ThisKey="Id", OtherKey="AccountFromId")]
		public EntitySet<BankTransaction> BankTransactions
		{
			get
			{
				return this._BankTransactions;
			}
			set
			{
				this._BankTransactions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_BankTransaction1", Storage="_BankTransactions1", ThisKey="Id", OtherKey="AccountToId")]
		public EntitySet<BankTransaction> BankTransactions1
		{
			get
			{
				return this._BankTransactions1;
			}
			set
			{
				this._BankTransactions1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Account", Storage="_Customer", ThisKey="CustomerId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Accounts.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Accounts.Add(this);
						this._CustomerId = value.Id;
					}
					else
					{
						this._CustomerId = default(string);
					}
					this.SendPropertyChanged("Customer");
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
		
		private void attach_BankTransactions(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_BankTransactions(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
		
		private void attach_BankTransactions1(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Account1 = this;
		}
		
		private void detach_BankTransactions1(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Account1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private string _Password;
		
		private string _Role;
		
		private EntitySet<BankTransaction> _BankTransactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRoleChanging(string value);
    partial void OnRoleChanged();
    #endregion
		
		public Employee()
		{
			this._BankTransactions = new EntitySet<BankTransaction>(new Action<BankTransaction>(this.attach_BankTransactions), new Action<BankTransaction>(this.detach_BankTransactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_BankTransaction", Storage="_BankTransactions", ThisKey="Id", OtherKey="EmployeeId")]
		public EntitySet<BankTransaction> BankTransactions
		{
			get
			{
				return this._BankTransactions;
			}
			set
			{
				this._BankTransactions.Assign(value);
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
		
		private void attach_BankTransactions(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_BankTransactions(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BankTransaction")]
	public partial class BankTransaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private System.Nullable<int> _AccountFromId;
		
		private System.Nullable<int> _AccountToId;
		
		private double _Amount;
		
		private System.DateTime _DateOfTrans;
		
		private string _EmployeeId;
		
		private string _BranchId;
		
		private string _Description;
		
		private string _Pin;
		
		private EntityRef<Account> _Account;
		
		private EntityRef<Account> _Account1;
		
		private EntityRef<Employee> _Employee;
		
		private EntityRef<Branch> _Branch;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnAccountFromIdChanging(System.Nullable<int> value);
    partial void OnAccountFromIdChanged();
    partial void OnAccountToIdChanging(System.Nullable<int> value);
    partial void OnAccountToIdChanged();
    partial void OnAmountChanging(double value);
    partial void OnAmountChanged();
    partial void OnDateOfTransChanging(System.DateTime value);
    partial void OnDateOfTransChanged();
    partial void OnEmployeeIdChanging(string value);
    partial void OnEmployeeIdChanged();
    partial void OnBranchIdChanging(string value);
    partial void OnBranchIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPinChanging(string value);
    partial void OnPinChanged();
    #endregion
		
		public BankTransaction()
		{
			this._Account = default(EntityRef<Account>);
			this._Account1 = default(EntityRef<Account>);
			this._Employee = default(EntityRef<Employee>);
			this._Branch = default(EntityRef<Branch>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountFromId", DbType="Int")]
		public System.Nullable<int> AccountFromId
		{
			get
			{
				return this._AccountFromId;
			}
			set
			{
				if ((this._AccountFromId != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccountFromIdChanging(value);
					this.SendPropertyChanging();
					this._AccountFromId = value;
					this.SendPropertyChanged("AccountFromId");
					this.OnAccountFromIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountToId", DbType="Int")]
		public System.Nullable<int> AccountToId
		{
			get
			{
				return this._AccountToId;
			}
			set
			{
				if ((this._AccountToId != value))
				{
					if (this._Account1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccountToIdChanging(value);
					this.SendPropertyChanging();
					this._AccountToId = value;
					this.SendPropertyChanged("AccountToId");
					this.OnAccountToIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float NOT NULL")]
		public double Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfTrans", DbType="DateTime NOT NULL")]
		public System.DateTime DateOfTrans
		{
			get
			{
				return this._DateOfTrans;
			}
			set
			{
				if ((this._DateOfTrans != value))
				{
					this.OnDateOfTransChanging(value);
					this.SendPropertyChanging();
					this._DateOfTrans = value;
					this.SendPropertyChanged("DateOfTrans");
					this.OnDateOfTransChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="VarChar(255)")]
		public string EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BranchId", DbType="VarChar(255)")]
		public string BranchId
		{
			get
			{
				return this._BranchId;
			}
			set
			{
				if ((this._BranchId != value))
				{
					if (this._Branch.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBranchIdChanging(value);
					this.SendPropertyChanging();
					this._BranchId = value;
					this.SendPropertyChanged("BranchId");
					this.OnBranchIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pin", DbType="NVarChar(255)")]
		public string Pin
		{
			get
			{
				return this._Pin;
			}
			set
			{
				if ((this._Pin != value))
				{
					this.OnPinChanging(value);
					this.SendPropertyChanging();
					this._Pin = value;
					this.SendPropertyChanged("Pin");
					this.OnPinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_BankTransaction", Storage="_Account", ThisKey="AccountFromId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.BankTransactions.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.BankTransactions.Add(this);
						this._AccountFromId = value.Id;
					}
					else
					{
						this._AccountFromId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Account");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_BankTransaction1", Storage="_Account1", ThisKey="AccountToId", OtherKey="Id", IsForeignKey=true)]
		public Account Account1
		{
			get
			{
				return this._Account1.Entity;
			}
			set
			{
				Account previousValue = this._Account1.Entity;
				if (((previousValue != value) 
							|| (this._Account1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account1.Entity = null;
						previousValue.BankTransactions1.Remove(this);
					}
					this._Account1.Entity = value;
					if ((value != null))
					{
						value.BankTransactions1.Add(this);
						this._AccountToId = value.Id;
					}
					else
					{
						this._AccountToId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Account1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_BankTransaction", Storage="_Employee", ThisKey="EmployeeId", OtherKey="Id", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.BankTransactions.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.BankTransactions.Add(this);
						this._EmployeeId = value.Id;
					}
					else
					{
						this._EmployeeId = default(string);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Branch_BankTransaction", Storage="_Branch", ThisKey="BranchId", OtherKey="Id", IsForeignKey=true)]
		public Branch Branch
		{
			get
			{
				return this._Branch.Entity;
			}
			set
			{
				Branch previousValue = this._Branch.Entity;
				if (((previousValue != value) 
							|| (this._Branch.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Branch.Entity = null;
						previousValue.BankTransactions.Remove(this);
					}
					this._Branch.Entity = value;
					if ((value != null))
					{
						value.BankTransactions.Add(this);
						this._BranchId = value.Id;
					}
					else
					{
						this._BranchId = default(string);
					}
					this.SendPropertyChanged("Branch");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Branch")]
	public partial class Branch : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private string _HouseNo;
		
		private string _City;
		
		private EntitySet<BankTransaction> _BankTransactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnHouseNoChanging(string value);
    partial void OnHouseNoChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    #endregion
		
		public Branch()
		{
			this._BankTransactions = new EntitySet<BankTransaction>(new Action<BankTransaction>(this.attach_BankTransactions), new Action<BankTransaction>(this.detach_BankTransactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HouseNo", DbType="NVarChar(255)")]
		public string HouseNo
		{
			get
			{
				return this._HouseNo;
			}
			set
			{
				if ((this._HouseNo != value))
				{
					this.OnHouseNoChanging(value);
					this.SendPropertyChanging();
					this._HouseNo = value;
					this.SendPropertyChanged("HouseNo");
					this.OnHouseNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Branch_BankTransaction", Storage="_BankTransactions", ThisKey="Id", OtherKey="BranchId")]
		public EntitySet<BankTransaction> BankTransactions
		{
			get
			{
				return this._BankTransactions;
			}
			set
			{
				this._BankTransactions.Assign(value);
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
		
		private void attach_BankTransactions(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Branch = this;
		}
		
		private void detach_BankTransactions(BankTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Branch = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private string _Phone;
		
		private string _Email;
		
		private string _HouseNo;
		
		private string _City;
		
		private string _Pin;
		
		private EntitySet<Account> _Accounts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnHouseNoChanging(string value);
    partial void OnHouseNoChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnPinChanging(string value);
    partial void OnPinChanged();
    #endregion
		
		public Customer()
		{
			this._Accounts = new EntitySet<Account>(new Action<Account>(this.attach_Accounts), new Action<Account>(this.detach_Accounts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HouseNo", DbType="NVarChar(255)")]
		public string HouseNo
		{
			get
			{
				return this._HouseNo;
			}
			set
			{
				if ((this._HouseNo != value))
				{
					this.OnHouseNoChanging(value);
					this.SendPropertyChanging();
					this._HouseNo = value;
					this.SendPropertyChanged("HouseNo");
					this.OnHouseNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pin", DbType="NVarChar(255)")]
		public string Pin
		{
			get
			{
				return this._Pin;
			}
			set
			{
				if ((this._Pin != value))
				{
					this.OnPinChanging(value);
					this.SendPropertyChanging();
					this._Pin = value;
					this.SendPropertyChanged("Pin");
					this.OnPinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Account", Storage="_Accounts", ThisKey="Id", OtherKey="CustomerId")]
		public EntitySet<Account> Accounts
		{
			get
			{
				return this._Accounts;
			}
			set
			{
				this._Accounts.Assign(value);
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
		
		private void attach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
}
#pragma warning restore 1591