ALTER procedure [dbo].[get_sale] @id int
as
begin
	select * from Sale a where a.Id = @id
end