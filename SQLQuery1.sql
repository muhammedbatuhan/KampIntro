--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where categoryId=1 or CategoryID=3

Select * from Products where categoryId=1 and UnitPrice>=10

Select * from Products order by UnitPrice desc

Select Count(*) from Products where CategoryID = 2

select CategoryID, count(*) from Products where UnitPrice>20
group by CategoryID having count (*) <10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO C SHARPTA BUNA BÖYLE DİYECEĞİZ

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
