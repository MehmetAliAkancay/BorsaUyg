USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[ItemGoster]    Script Date: 16.05.2021 15:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[ItemGoster] @ItemID int 
as 
Select ui.UserID,u.UserName,ui.ItemAmount,ui.ItemPrice from Tbl_UserItems ui inner join Tbl_Users u on ui.UserID=u.UserID 
inner join Tbl_Items i on  i.ItemID=ui.ItemID
Where ui.ItemID=@ItemID and ui.ItemAccept=1
