USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[RaporAlim]    Script Date: 20.06.2021 23:46:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[RaporAlim] @tarih1 date ,@tarih2 date,@UserID nvarchar(50)
as
SELECT i.ItemName,pt.ItemID,pt.ItemAmount,pt.DateOfPurchase From Tbl_PurchasedItems pt inner join Tbl_Items i on i.ItemID=pt.ItemID
Where DateOfPurchase between @tarih1 and @tarih2 and UserID=@UserID  