CREATE TABLE Client(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(15) NULL,
	[LastName] VARCHAR(15) NULL,
	[Email] VARCHAR(50) NULL,
	[CreatedAt] DATETIME NULL,
	[IsActive] BIT NULL,
	PRIMARY KEY CLUSTERED
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

CREATE TABLE Product(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(100) NOT NULL,
	[Price] DECIMAL(18,2) NULL,
	[IsActive] BIT NULL,
	PRIMARY KEY CLUSTERED
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO