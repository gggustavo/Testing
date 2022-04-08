# testing

SQL
You have three different tables
A Customer Table with FirstName, LastName, Age, Occupation, MartialStatus, PersonID

An Orders Table with OrderID, PersonID, DateCreated, MethodofPurchase

An Orders Details table with OrderID, OrderDetailID, ProductNumber, ProductID, ProductOrigin

Please return a result of the customers who ordered product ID = 1112222333 and return
FirstName and LastName as full name, age, orderid, datecreated, MethodOfPurchase as Purchase Method, ProductNumber and ProductOrigin

```sql
SELECT 
CONCAT(c.FirstName, ' ', c.LastName) AS 'Full Name',
c.age,
o.OrderID,
o.DateCreated,
o.MethodOfPurchase AS 'Purchase Method',
od.ProductNumber,
od.ProductOrigin
FROM Customer as c 
inner join Order as o on c.PersonID = o.PersonID
inner join OrderDetails as od on o.OrderID = od.OrderID
WHERE od.ProductID = 1112222333
```
