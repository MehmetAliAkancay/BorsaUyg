USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[RaporSatim]    Script Date: 20.06.2021 23:46:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[RaporSatim] @tarih1 date,@tarih2 date, @UserID nvarchar(50)
as
SELECT ui.ItemName,ui.ItemID,ui.ItemPrice,ui.ItemAmount,ui.DateOfPurchase From Tbl_UserItems ui 
Where DateOfPurchase between @tarih1 and @tarih2 and UserID=@UserID 