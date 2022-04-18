USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[CuzdanItem]    Script Date: 20.06.2021 23:47:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[CuzdanItem] @UserID nvarchar(50)
as
Select i.ItemName,pt.ItemID,pt.ItemAmount,pt.DateOfPurchase from Tbl_PurchasedItems pt inner join Tbl_Users u on pt.UserID=u.UserID 
inner join Tbl_Items i on  i.ItemID=pt.ItemID
Where pt.UserID=@UserID

