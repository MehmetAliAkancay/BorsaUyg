USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[Onay]    Script Date: 16.05.2021 15:34:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Onay] @UserID varchar(50),@ItemID int ,@ItemPrice decimal
as
if exists(Select UserID from Tbl_UserItems Where ItemAccept=1 and UserID=@UserID and ItemID=@ItemID and ItemPrice=@ItemPrice )
begin
update Tbl_UserItems set ItemAmount+=(Select ItemAmount From Tbl_UserItems Where ItemAccept=0) Where UserID=@UserID
Delete Tbl_UserItems Where ItemAccept=0 and UserID=@UserID and ItemID=@ItemID and ItemPrice=@ItemPrice
end
else
begin
update Tbl_UserItems SET ItemAccept=1 Where UserID =@UserID and ItemID=@ItemID and ItemPrice=@ItemPrice
end
