USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[ItemEkleme]    Script Date: 20.06.2021 23:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[ItemEkleme] @UserID nvarchar(50),@ItemID int ,@ItemName nvarchar(50),@ItemAmount int ,@ItemPrice decimal
as
declare @UserIDBuy nvarchar(50)
declare @ItemPriceBuy decimal
declare @ItemAmountBuy int

set @UserIDBuy=(Select Top 1 UserID From Tbl_BuyOrder Where ItemID=@ItemID order by ItemPrice)
set @ItemPriceBuy=(Select Top 1 ItemPrice From Tbl_BuyOrder Where ItemID=@ItemID and UserID=@UserIDBuy order by ItemPrice)
set @ItemAmountBuy=(Select Top 1 ItemAmount from Tbl_BuyOrder where ItemID=@ItemID and UserID=@UserIDBuy order by ItemPrice)
if exists(select UserID from Tbl_UserItems Where UserID=@UserID and ItemID=@ItemID and ItemPrice=@ItemPrice and ItemAccept=0) 
begin 
update Tbl_UserItems set ItemAmount+=@ItemAmount
end
else
begin
insert into Tbl_UserItems(UserID,ItemID,ItemName,ItemAmount,ItemPrice,DateOfPurchase,ItemAccept) values(@UserID,@ItemID,@ItemName,@ItemAmount,@ItemPrice,getdate(),0)
if(@ItemPrice=@ItemPriceBuy and @ItemAmount>=@ItemAmountBuy)
begin
Delete Tbl_BuyOrder where UserID=@UserIDBuy and ItemID=@ItemID and ItemAmount>=@ItemAmountBuy
Execute Satis @ItemID,@UserIDBuy,@ItemPriceBuy,@ItemAmountBuy
end
end
