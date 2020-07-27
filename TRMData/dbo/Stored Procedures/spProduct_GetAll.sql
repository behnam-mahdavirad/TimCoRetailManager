CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	set nocount on;

	select id, Productname, [Description], RetailPrice, QuantityInStock, IsTaxable
	from dbo.Product
	order by ProductName;
end