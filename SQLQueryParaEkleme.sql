USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[ParaEkleme]    Script Date: 16.05.2021 15:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[ParaEkleme] @UserID nvarchar(50) ,@MoneyAmount decimal 
as
if exists(select UserID MoneyAccept from Tbl_Money Where UserID=@UserID and MoneyAccept=0) 
begin
update Tbl_Money Set MoneyAmount+=@MoneyAmount Where UserID=@UserID
end
else
begin
insert into Tbl_Money (UserID , MoneyAmount,MoneyAccept) values (@UserID,@MoneyAmount,0)
end
