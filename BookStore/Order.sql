CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerID] INT NOT NULL, 
    [BookID] INT NOT NULL,
	CONSTRAINT [FK_Order_Book] FOREIGN KEY ([BookID]) REFERENCES [Book]([BookID]) on delete cascade,
	CONSTRAINT [FK_Orders_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Customer]([CustomerID]) on delete cascade
)