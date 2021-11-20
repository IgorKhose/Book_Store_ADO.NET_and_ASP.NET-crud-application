CREATE VIEW [dbo].[CustomerOrders]
	AS SELECT [Customer].*, [Book].* 
	FROM [Order] 
		inner join [Customer] on [Customer].CustomerID = [Order].CustomerID
		inner join [Book] on [Book].BookID = [Order].BookID
