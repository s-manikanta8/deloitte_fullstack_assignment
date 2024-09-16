alter view Products_Less_Than_Average_Price
as
select * from Products where UnitPrice < (select avg(UnitPrice) from Products); 
--------------------------------------------------------------------------------
Exec sp_rename 'plap','Low_Cost_Products';

select * from Low_Cost_Products
--------------------------------------------------------------------------------
drop view Low_Cost_Products
--------------------------------------------------------------------------------

alter procedure total_cost_of_products
as
begin 
declare ttl_prdct cursor
for select productname,unitsonorder,round(unitprice,2) as unitprice from products;
open ttl_prdct;
declare @pn Varchar(50),@uo int,@up decimal,@tt decimal,@ttl decimal=0;
fetch next from ttl_prdct into @pn,@uo,@up;
while @@fetch_status =0
begin
set @tt=@uo*@up
set @ttl=@ttl+@tt
print @pn +' '+ cast(@uo as varchar)+'  '+cast(@up as varchar)+' '+cast(round(@tt,2) as varchar)
fetch next from ttl_prdct into @pn,@uo,@up;
end
print 'total'+' '+cast(@ttl as varchar)
close ttl_prdct;
deallocate ttl_prdct;
end


EXEC total_cost_of_products;