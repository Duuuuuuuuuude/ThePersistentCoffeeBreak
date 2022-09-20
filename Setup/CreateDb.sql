USE [TheCoffeeBreak]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 20-09-2022 17:01:46 ******/

CREATE TABLE [Orders](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Date] [datetime] NOT NULL,
	[Status] [nvarchar](50) DEFAULT (N'New') NOT NULL,
	[Discount] [int] DEFAULT ((0)) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
)
GO

/****** Object:  Table [dbo].[Products]    Script Date: 20-09-2022 17:01:46 ******/

CREATE TABLE [Products](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NULL,
)

/****** Object:  Table [dbo].[OrderLines]    Script Date: 20-09-2022 17:01:46 ******/

CREATE TABLE [OrderLines](
	[OrderId] [int] FOREIGN KEY REFERENCES [Orders]([Id]) NOT NULL,
	[ProductId] [int] FOREIGN KEY REFERENCES [Products]([Id]) NOT NULL,
	[Quantity] [int] NOT NULL,
    CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED 
	(
		[OrderId] ASC,
		[ProductId] ASC
	)
) 
GO

INSERT INTO [Products]
VALUES ('Americano', 'Espresso shots topped with hot water create a light layer of crema culminating in this wonderfully rich cup with depth and nuance.	', 22.50)
GO

INSERT INTO [Products]
VALUES ('Dark Roast Coffee', 'This full-bodied dark roast coffee with bold, robust flavors showcases our roasting and blending artistry—an essential blend of balanced and lingering flavors.	', 32.50)
GO

INSERT INTO [Products]
VALUES ('Misto', 'A one-to-one combination of fresh-brewed coffee and steamed milk add up to one distinctly delicious coffee drink remarkably mixed.	', 32.50)
GO

INSERT INTO [Products]
VALUES ('Cappuccino', 'Dark, rich espresso lies in wait under a smoothed and stretched layer of thick milk foam. An alchemy of barista artistry and craft.	', 29.50)
GO

INSERT INTO [Products]
VALUES ('Espresso', 'Our smooth signature Espresso Roast with rich flavor and caramelly sweetness is at the very heart of everything we do.	', 19.50)
GO

INSERT INTO [Products]
VALUES ('Latte', 'Our dark, rich espresso balanced with steamed milk and a light layer of foam. A perfect milk-forward warm-up.	', 29.50)
GO

INSERT INTO [Products]
VALUES ('Cinnamon Dolce Latte', 'We add freshly steamed milk and cinnamon dolce-flavored syrup to our classic espresso, topped with sweetened whipped cream and a cinnamon dolce topping to bring you specialness in a treat.	', 32.50)
GO

INSERT INTO [Products]
VALUES ('Flat White', 'Smooth ristretto shots of espresso get the perfect amount of steamed whole milk to create a not-too-strong, not-too-creamy, just-right flavor.	', 29.50)
GO

INSERT INTO [Products]
VALUES ('Caramel Macchiato', 'Freshly steamed milk with vanilla-flavored syrup marked with espresso and topped with a caramel drizzle for an oh-so-sweet finish.	', 29.50)
GO
