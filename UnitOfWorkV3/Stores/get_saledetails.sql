ALTER procedure[dbo].[get_saledetails] @id int
as
begin
	select a.*, b.Name
	from SaleDetail a
	join Product b on (b.Id = a.IdProduct)
	where a.IdSale = @id
end