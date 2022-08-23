ALTER procedure [dbo].[create_sale]
as
begin
	insert into dbo.[Sale] ([Date]) values (GETDATE())
	select convert(int,SCOPE_IDENTITY())
end
