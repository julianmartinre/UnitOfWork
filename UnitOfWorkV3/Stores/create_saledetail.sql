ALTER procedure [dbo].[create_saledetail] @idSale int, @idProduct int, @quantity int
as
begin
	insert into dbo.[SaleDetail] ([IdSale],[IdProduct],[Quantity]) values (@idSale,@idProduct,@quantity)
	select 0
end
