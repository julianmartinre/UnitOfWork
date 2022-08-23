ALTER procedure [dbo].[create_product] @name varchar(20)
as
begin
	insert into dbo.[Product] ([Name]) values (@name)
	select convert(int,SCOPE_IDENTITY())
end