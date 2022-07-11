create  database ShopDb;
go

create table ShopDb.dbo.Users
(
	Id int not null identity,
	UserName nvarchar(200) not null unique,


	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go


create table ShopDb.dbo.Corporations
(
	Id int not null identity,
	Title nvarchar(200) not null,
	[Address] nvarchar(1000) null,
	Telephone nvarchar(21) null,
	Fax nvarchar(21) null,
	[Description] nvarchar(1000) null,
	

	IsDeleted bit not null ,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.FinancialYears
(
	Id int not null identity,
	CorporationId int not null references dbo.Corporations(Id),
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,
	StartDate datetime not null,
	FinishDate datetime not null,
	IsClosed bit not null,
	CloseDate datetime null,
	ClosedByUserId int null references dbo.Users(Id),


	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.ProductUnits
(
	Id int not null identity,
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go


create table ShopDb.dbo.Inventories
(
	Id int not null identity,
	CorporationId int not null references dbo.Corporations(Id),
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.ProductCategories
(
	Id int not null identity,
	InventoryId int not null references dbo.Inventories(Id),
	ParentCategoryId int null references dbo.ProductCategories(Id),
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.Products
(
	Id int not null identity,
	ProductCategoryId int not null references dbo.ProductCategories(Id),
	ProductUnitId int null references dbo.ProductUnits(Id),
	Code varchar(10) not null unique,
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.ProductParameters
(
	Id int not null identity,
	ProductCategoryId int not null references dbo.ProductCategories(Id),
	[Key] varchar(100) not null unique,
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,
	[Data] nvarchar(max) null,
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.ProductParameterValues
(
	ProductId int not null references dbo.Products(Id),
	ProductParameterId int not null references dbo.ProductParameters(Id),
	[Value] nvarchar(max) null,

	primary key(ProductId,ProductParameterId)
);
go

create table ShopDb.dbo.ProductPrices
(
	Id int not null identity,
	ProductId int not null references dbo.Products(Id),
	[Date] datetime not null default(getdate()),
	Price decimal not null,

	primary key(Id)
);
go

create table ShopDb.dbo.InventoryInsType
(
	Id int not null identity,
	Title nvarchar(200) not null unique,
	[Description] nvarchar(1000) null,
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.InventoryInsHeaders
(
	Id bigint not null identity,
	InventoryId int not null references dbo.Inventories(Id),
	TypeId int not null references dbo.InventoryInsType(Id),
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,
	[Date] datetime not null,
	Accepted bit not null,
	AcceptDate datetime null,
	AcceptedByUserId int null references dbo.Users(Id),
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go


create table ShopDb.dbo.InventoryInsDetails
(
	InventoryInsHeaderId bigint not null references dbo.InventoryInsHeaders(Id),
	ProductId int not null references dbo.Products(Id),
	Amount decimal not null,
	TotalPrice decimal not null,

	primary key(ProductId,InventoryInsHeaderId)
);
go

create table ShopDb.dbo.InventoryOutsType
(
	Id int not null identity,
	Title nvarchar(200) not null unique,
	[Description] nvarchar(1000) null,
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go

create table ShopDb.dbo.InventoryOutsHeaders
(
	Id bigint not null identity,
	InventoryId int not null references dbo.Inventories(Id),
	TypeId int not null references dbo.InventoryOutsType(Id),
	Title nvarchar(200) not null,
	[Description] nvarchar(1000) null,
	[Date] datetime not null,
	Accepted bit not null,
	AcceptDate datetime null,
	AcceptedByUserId int null references dbo.Users(Id),
	

	IsDeleted bit not null,
	DeleteDate datetime  null default(getdate()),
	DeleteByUserId int null references dbo.Users(Id),
	primary key(Id)
);
go


create table ShopDb.dbo.InventoryOutsDetails
(
	InventoryOutsHeaderId bigint not null references dbo.InventoryOutsHeaders(Id),
	ProductId int not null references dbo.Products(Id),
	Amount decimal not null,
	TotalPrice decimal not null,

	primary key(ProductId,InventoryOutsHeaderId)
);
go