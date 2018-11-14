USE [Calculator]
GO
CREATE TABLE [dbo].[Users](
	[Id] uniqueidentifier NOT NULL,
	[IPAddress] bigint NOT NULL,
	CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED([Id] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Expressions](
	[Id] uniqueidentifier NOT NULL,
	[Expression] nvarchar(1000) NOT NULL,
	CONSTRAINT [PK_Expressions] PRIMARY KEY CLUSTERED([Id] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Calculations](
	[Id] uniqueidentifier NOT NULL,
	[IPAddressId] uniqueidentifier NOT NULL,
    [ExpressionId] uniqueidentifier NOT NULL,
	[Date] DATETIME NOT NULL,
	CONSTRAINT [PK_Calculations] PRIMARY KEY NONCLUSTERED([Id] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO

--CREATE CLUSTERED INDEX [Users_Index] ON [dbo].[Users] 
--(
--	[IPAddress] ASC
--)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
--GO

--CREATE CLUSTERED INDEX [Expressions_Index] ON [dbo].[Expressions] 
--(
--	[Expression] ASC
--)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
--GO

CREATE CLUSTERED INDEX [Calculations_Index] ON [dbo].[Calculations] 
(
	[Date] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Calculations]  WITH CHECK ADD  CONSTRAINT [FK_Calculations_Users] FOREIGN KEY([IPAddressId])
REFERENCES [dbo].[Users] ([Id])
GO

ALTER TABLE [dbo].[Calculations]  WITH CHECK ADD  CONSTRAINT [FK_Calculations_Expressions] FOREIGN KEY([ExpressionId])
REFERENCES [dbo].[Expressions] ([Id])
GO