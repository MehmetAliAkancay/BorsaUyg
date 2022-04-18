USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[ParaOnay]    Script Date: 16.05.2021 15:34:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[ParaOnay] @UserID nvarchar(50) 
as


if exists(Select UserID from Tbl_Money Where MoneyAccept=1 and UserID=@UserID)
begin
update Tbl_Money set MoneyAmount+=(Select MoneyAmount From Tbl_Money Where MoneyAccept=0) Where UserID=@UserID
Delete Tbl_Money Where MoneyAccept=0 and UserID=@UserID
end
else
begin
update Tbl_Money SET MoneyAccept=1 Where UserID =@UserID
end