﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyBookShop")]
public partial class MyBookShopDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void InsertBook(Book instance);
  partial void UpdateBook(Book instance);
  partial void DeleteBook(Book instance);
  partial void InsertCategory(Category instance);
  partial void UpdateCategory(Category instance);
  partial void DeleteCategory(Category instance);
  partial void InsertOrder(Order instance);
  partial void UpdateOrder(Order instance);
  partial void DeleteOrder(Order instance);
  partial void InsertPress(Press instance);
  partial void UpdatePress(Press instance);
  partial void DeletePress(Press instance);
  partial void InsertOrderItem(OrderItem instance);
  partial void UpdateOrderItem(OrderItem instance);
  partial void DeleteOrderItem(OrderItem instance);
  #endregion
	
	public MyBookShopDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyBookShopConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public MyBookShopDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MyBookShopDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MyBookShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MyBookShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Book> Book
	{
		get
		{
			return this.GetTable<Book>();
		}
	}
	
	public System.Data.Linq.Table<Category> Category
	{
		get
		{
			return this.GetTable<Category>();
		}
	}
	
	public System.Data.Linq.Table<Order> Order
	{
		get
		{
			return this.GetTable<Order>();
		}
	}
	
	public System.Data.Linq.Table<Press> Press
	{
		get
		{
			return this.GetTable<Press>();
		}
	}
	
	public System.Data.Linq.Table<OrderItem> OrderItem
	{
		get
		{
			return this.GetTable<OrderItem>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _BookId;
	
	private int _CategoryId;
	
	private System.Nullable<decimal> _ListPrice;
	
	private string _Author;
	
	private int _PressId;
	
	private string _Name;
	
	private string _Descn;
	
	private string _Image;
	
	private int _Qty;
	
	private EntityRef<Category> _Category;
	
	private EntityRef<Press> _Press;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookIdChanging(string value);
    partial void OnBookIdChanged();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnListPriceChanging(System.Nullable<decimal> value);
    partial void OnListPriceChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnPressIdChanging(int value);
    partial void OnPressIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescnChanging(string value);
    partial void OnDescnChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnQtyChanging(int value);
    partial void OnQtyChanged();
    #endregion
	
	public Book()
	{
		this._Category = default(EntityRef<Category>);
		this._Press = default(EntityRef<Press>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string BookId
	{
		get
		{
			return this._BookId;
		}
		set
		{
			if ((this._BookId != value))
			{
				this.OnBookIdChanging(value);
				this.SendPropertyChanging();
				this._BookId = value;
				this.SendPropertyChanged("BookId");
				this.OnBookIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", DbType="Int NOT NULL")]
	public int CategoryId
	{
		get
		{
			return this._CategoryId;
		}
		set
		{
			if ((this._CategoryId != value))
			{
				if (this._Category.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCategoryIdChanging(value);
				this.SendPropertyChanging();
				this._CategoryId = value;
				this.SendPropertyChanged("CategoryId");
				this.OnCategoryIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListPrice", DbType="Decimal(10,2)")]
	public System.Nullable<decimal> ListPrice
	{
		get
		{
			return this._ListPrice;
		}
		set
		{
			if ((this._ListPrice != value))
			{
				this.OnListPriceChanging(value);
				this.SendPropertyChanging();
				this._ListPrice = value;
				this.SendPropertyChanged("ListPrice");
				this.OnListPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="VarChar(50)")]
	public string Author
	{
		get
		{
			return this._Author;
		}
		set
		{
			if ((this._Author != value))
			{
				this.OnAuthorChanging(value);
				this.SendPropertyChanging();
				this._Author = value;
				this.SendPropertyChanged("Author");
				this.OnAuthorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressId", DbType="Int NOT NULL")]
	public int PressId
	{
		get
		{
			return this._PressId;
		}
		set
		{
			if ((this._PressId != value))
			{
				if (this._Press.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPressIdChanging(value);
				this.SendPropertyChanging();
				this._PressId = value;
				this.SendPropertyChanged("PressId");
				this.OnPressIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(80)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descn", DbType="VarChar(255)")]
	public string Descn
	{
		get
		{
			return this._Descn;
		}
		set
		{
			if ((this._Descn != value))
			{
				this.OnDescnChanging(value);
				this.SendPropertyChanging();
				this._Descn = value;
				this.SendPropertyChanged("Descn");
				this.OnDescnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(80)")]
	public string Image
	{
		get
		{
			return this._Image;
		}
		set
		{
			if ((this._Image != value))
			{
				this.OnImageChanging(value);
				this.SendPropertyChanging();
				this._Image = value;
				this.SendPropertyChanged("Image");
				this.OnImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qty", DbType="Int NOT NULL")]
	public int Qty
	{
		get
		{
			return this._Qty;
		}
		set
		{
			if ((this._Qty != value))
			{
				this.OnQtyChanging(value);
				this.SendPropertyChanging();
				this._Qty = value;
				this.SendPropertyChanged("Qty");
				this.OnQtyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Book", Storage="_Category", ThisKey="CategoryId", OtherKey="CategoryId", IsForeignKey=true)]
	public Category Category
	{
		get
		{
			return this._Category.Entity;
		}
		set
		{
			Category previousValue = this._Category.Entity;
			if (((previousValue != value) 
						|| (this._Category.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Category.Entity = null;
					previousValue.Book.Remove(this);
				}
				this._Category.Entity = value;
				if ((value != null))
				{
					value.Book.Add(this);
					this._CategoryId = value.CategoryId;
				}
				else
				{
					this._CategoryId = default(int);
				}
				this.SendPropertyChanged("Category");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Press_Book", Storage="_Press", ThisKey="PressId", OtherKey="PressId", IsForeignKey=true)]
	public Press Press
	{
		get
		{
			return this._Press.Entity;
		}
		set
		{
			Press previousValue = this._Press.Entity;
			if (((previousValue != value) 
						|| (this._Press.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Press.Entity = null;
					previousValue.Book.Remove(this);
				}
				this._Press.Entity = value;
				if ((value != null))
				{
					value.Book.Add(this);
					this._PressId = value.PressId;
				}
				else
				{
					this._PressId = default(int);
				}
				this.SendPropertyChanged("Press");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CategoryId;
	
	private string _Name;
	
	private string _Descn;
	
	private EntitySet<Book> _Book;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescnChanging(string value);
    partial void OnDescnChanged();
    #endregion
	
	public Category()
	{
		this._Book = new EntitySet<Book>(new Action<Book>(this.attach_Book), new Action<Book>(this.detach_Book));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int CategoryId
	{
		get
		{
			return this._CategoryId;
		}
		set
		{
			if ((this._CategoryId != value))
			{
				this.OnCategoryIdChanging(value);
				this.SendPropertyChanging();
				this._CategoryId = value;
				this.SendPropertyChanged("CategoryId");
				this.OnCategoryIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(80)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descn", DbType="VarChar(255)")]
	public string Descn
	{
		get
		{
			return this._Descn;
		}
		set
		{
			if ((this._Descn != value))
			{
				this.OnDescnChanging(value);
				this.SendPropertyChanging();
				this._Descn = value;
				this.SendPropertyChanged("Descn");
				this.OnDescnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Book", Storage="_Book", ThisKey="CategoryId", OtherKey="CategoryId")]
	public EntitySet<Book> Book
	{
		get
		{
			return this._Book;
		}
		set
		{
			this._Book.Assign(value);
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
	
	private void attach_Book(Book entity)
	{
		this.SendPropertyChanging();
		entity.Category = this;
	}
	
	private void detach_Book(Book entity)
	{
		this.SendPropertyChanging();
		entity.Category = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _OrderId;
	
	private string _UserName;
	
	private System.DateTime _OrderDate;
	
	private string _Addr;
	
	private string _City;
	
	private string _State;
	
	private string _Zip;
	
	private string _Phone;
	
	private string _Status;
	
	private EntitySet<OrderItem> _OrderItem;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnOrderDateChanging(System.DateTime value);
    partial void OnOrderDateChanged();
    partial void OnAddrChanging(string value);
    partial void OnAddrChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
	
	public Order()
	{
		this._OrderItem = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItem), new Action<OrderItem>(this.detach_OrderItem));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int OrderId
	{
		get
		{
			return this._OrderId;
		}
		set
		{
			if ((this._OrderId != value))
			{
				this.OnOrderIdChanging(value);
				this.SendPropertyChanging();
				this._OrderId = value;
				this.SendPropertyChanged("OrderId");
				this.OnOrderIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime NOT NULL")]
	public System.DateTime OrderDate
	{
		get
		{
			return this._OrderDate;
		}
		set
		{
			if ((this._OrderDate != value))
			{
				this.OnOrderDateChanging(value);
				this.SendPropertyChanging();
				this._OrderDate = value;
				this.SendPropertyChanged("OrderDate");
				this.OnOrderDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Addr", DbType="VarChar(80)")]
	public string Addr
	{
		get
		{
			return this._Addr;
		}
		set
		{
			if ((this._Addr != value))
			{
				this.OnAddrChanging(value);
				this.SendPropertyChanging();
				this._Addr = value;
				this.SendPropertyChanged("Addr");
				this.OnAddrChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(80)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(80)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(6)")]
	public string Zip
	{
		get
		{
			return this._Zip;
		}
		set
		{
			if ((this._Zip != value))
			{
				this.OnZipChanging(value);
				this.SendPropertyChanging();
				this._Zip = value;
				this.SendPropertyChanged("Zip");
				this.OnZipChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(40)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(10)")]
	public string Status
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
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_OrderItem", ThisKey="OrderId", OtherKey="OrderId")]
	public EntitySet<OrderItem> OrderItem
	{
		get
		{
			return this._OrderItem;
		}
		set
		{
			this._OrderItem.Assign(value);
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
	
	private void attach_OrderItem(OrderItem entity)
	{
		this.SendPropertyChanging();
		entity.Order = this;
	}
	
	private void detach_OrderItem(OrderItem entity)
	{
		this.SendPropertyChanging();
		entity.Order = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Press")]
public partial class Press : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PressId;
	
	private string _Name;
	
	private string _Addr;
	
	private string _Zip;
	
	private string _Phone;
	
	private EntitySet<Book> _Book;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPressIdChanging(int value);
    partial void OnPressIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddrChanging(string value);
    partial void OnAddrChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
	
	public Press()
	{
		this._Book = new EntitySet<Book>(new Action<Book>(this.attach_Book), new Action<Book>(this.detach_Book));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PressId
	{
		get
		{
			return this._PressId;
		}
		set
		{
			if ((this._PressId != value))
			{
				this.OnPressIdChanging(value);
				this.SendPropertyChanging();
				this._PressId = value;
				this.SendPropertyChanged("PressId");
				this.OnPressIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(80)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Addr", DbType="VarChar(100)")]
	public string Addr
	{
		get
		{
			return this._Addr;
		}
		set
		{
			if ((this._Addr != value))
			{
				this.OnAddrChanging(value);
				this.SendPropertyChanging();
				this._Addr = value;
				this.SendPropertyChanged("Addr");
				this.OnAddrChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(6)")]
	public string Zip
	{
		get
		{
			return this._Zip;
		}
		set
		{
			if ((this._Zip != value))
			{
				this.OnZipChanging(value);
				this.SendPropertyChanging();
				this._Zip = value;
				this.SendPropertyChanged("Zip");
				this.OnZipChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(40)")]
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
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Press_Book", Storage="_Book", ThisKey="PressId", OtherKey="PressId")]
	public EntitySet<Book> Book
	{
		get
		{
			return this._Book;
		}
		set
		{
			this._Book.Assign(value);
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
	
	private void attach_Book(Book entity)
	{
		this.SendPropertyChanging();
		entity.Press = this;
	}
	
	private void detach_Book(Book entity)
	{
		this.SendPropertyChanging();
		entity.Press = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderItem")]
public partial class OrderItem : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ItemId;
	
	private int _OrderId;
	
	private string _BookName;
	
	private System.Nullable<decimal> _ListPrice;
	
	private int _Qty;
	
	private System.Nullable<decimal> _TotalPrice;
	
	private EntityRef<Order> _Order;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIdChanging(int value);
    partial void OnItemIdChanged();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnListPriceChanging(System.Nullable<decimal> value);
    partial void OnListPriceChanged();
    partial void OnQtyChanging(int value);
    partial void OnQtyChanged();
    partial void OnTotalPriceChanging(System.Nullable<decimal> value);
    partial void OnTotalPriceChanged();
    #endregion
	
	public OrderItem()
	{
		this._Order = default(EntityRef<Order>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ItemId
	{
		get
		{
			return this._ItemId;
		}
		set
		{
			if ((this._ItemId != value))
			{
				this.OnItemIdChanging(value);
				this.SendPropertyChanging();
				this._ItemId = value;
				this.SendPropertyChanged("ItemId");
				this.OnItemIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int NOT NULL")]
	public int OrderId
	{
		get
		{
			return this._OrderId;
		}
		set
		{
			if ((this._OrderId != value))
			{
				if (this._Order.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnOrderIdChanging(value);
				this.SendPropertyChanging();
				this._OrderId = value;
				this.SendPropertyChanged("OrderId");
				this.OnOrderIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="NVarChar(80)")]
	public string BookName
	{
		get
		{
			return this._BookName;
		}
		set
		{
			if ((this._BookName != value))
			{
				this.OnBookNameChanging(value);
				this.SendPropertyChanging();
				this._BookName = value;
				this.SendPropertyChanged("BookName");
				this.OnBookNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListPrice", DbType="Decimal(10,2)")]
	public System.Nullable<decimal> ListPrice
	{
		get
		{
			return this._ListPrice;
		}
		set
		{
			if ((this._ListPrice != value))
			{
				this.OnListPriceChanging(value);
				this.SendPropertyChanging();
				this._ListPrice = value;
				this.SendPropertyChanged("ListPrice");
				this.OnListPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qty", DbType="Int NOT NULL")]
	public int Qty
	{
		get
		{
			return this._Qty;
		}
		set
		{
			if ((this._Qty != value))
			{
				this.OnQtyChanging(value);
				this.SendPropertyChanging();
				this._Qty = value;
				this.SendPropertyChanged("Qty");
				this.OnQtyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalPrice", DbType="Decimal(10,2)")]
	public System.Nullable<decimal> TotalPrice
	{
		get
		{
			return this._TotalPrice;
		}
		set
		{
			if ((this._TotalPrice != value))
			{
				this.OnTotalPriceChanging(value);
				this.SendPropertyChanging();
				this._TotalPrice = value;
				this.SendPropertyChanged("TotalPrice");
				this.OnTotalPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_Order", ThisKey="OrderId", OtherKey="OrderId", IsForeignKey=true)]
	public Order Order
	{
		get
		{
			return this._Order.Entity;
		}
		set
		{
			Order previousValue = this._Order.Entity;
			if (((previousValue != value) 
						|| (this._Order.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Order.Entity = null;
					previousValue.OrderItem.Remove(this);
				}
				this._Order.Entity = value;
				if ((value != null))
				{
					value.OrderItem.Add(this);
					this._OrderId = value.OrderId;
				}
				else
				{
					this._OrderId = default(int);
				}
				this.SendPropertyChanged("Order");
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
#pragma warning restore 1591
