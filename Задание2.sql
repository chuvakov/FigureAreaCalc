select p.name, c.name
from products as p 
left join productscategories as pc on p.id = pc.productid 
left join categories as c on pc.categoryid = c.id;
