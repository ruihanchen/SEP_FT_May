use AdventureWorks2019
GO

--1. Write a query that lists the country and province names from person. CountryRegion and person. 
--   StateProvince tables. Join them and produce a result set similar to the following.

    --Country                        Province
SELECT c.Name'Country', s.Name'Province'
FROM Person.CountryRegion c
INNER JOIN Person.StateProvince s
ON c.CountryRegionCode=s.CountryRegionCode



--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
--Join them and produce a result set similar to the following.

    --Country                        Province
SELECT c.Name'Country',s.Name'Province'
FROM Person.CountryRegion c
INNER JOIN Person.StateProvince s
ON c.CountryRegionCode=s.CountryRegionCode
WHERE c.Name in('Germany','Canada')




 --Using Northwind Database: (Use aliases for all the Joins)
use Northwind
GO



--3. List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT* FROM Products p
INNER JOIN(SELECT ProductID FROM [Order Details] od
		INNER JOIN Orders o 
		ON od.OrderID= o.OrderID
	WHERE DATEDIFF(YEAR,o.OrderDate,GETDATE()) <25) od
ON p.ProductID=od.ProductID



--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 ShipPostalCode 'zip code', COUNT(*) 
FROM Orders o
WHERE DATEDIFF(YEAR,o.OrderDate,GETDATE()) <25
GROUP BY ShipPostalCode
ORDER BY ShipPostalCode



--5. List all city names and number of customers in that city.     
SELECT City,COUNT(*)NumCustomers
FROM Customers c 
GROUP BY City



--6. List city names which have more than 2 customers, and number of customers in that city
SELECT City,COUNT(*) NumCustomers
FROM Customers c
GROUP BY City
HAVING COUNT(city)>2



--7. Display the names of all customers  along with the  count of products they bought
SELECT c.ContactName,cp.s FROM Customers c 
INNER JOIN (SELECT CustomerID,SUM(Quantity) s FROM[Order Details] od 
INNER JOIN Orders o 
ON od.OrderID=o.OrderID 
GROUP BY CustomerID)cp 
ON c.CustomerID=cp.CustomerID



--8. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID,cp.total FROM Customers c 
INNER JOIN (SELECT CustomerID,SUM(Quantity) total FROM[Order Details] od 
INNER JOIN Orders o 
ON od.OrderID=o.OrderID
GROUP BY CustomerID 
HAVING SUM(Quantity) >100) cp 
ON c.CustomerID=cp.CustomerID



--9. List all of the possible ways that suppliers can ship their products. Display the results as below




    --Supplier Company Name                Shipping Company Name




    ---------------------------------            ----------------------------------
SELECT DISTINCT s.CompanyName supplierName, sh.CompanyName
FROM Suppliers s 
INNER JOIN Products p ON s.SupplierID = p.ProductID
INNER JOIN [Order Details] od ON od.ProductID = p.ProductID
INNER JOIN Orders o ON o.OrderID = od.OrderID
INNER JOIN Shippers sh ON sh.ShipperID = o.ShipVia



--10. Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName 
FROM Orders o JOIN [Order Details] od ON od.OrderID = o.OrderID 
INNER JOIN Products p ON p.ProductID = od.ProductID 
ORDER BY o.OrderDate



--11. Displays pairs of employees who have the same job title.
SELECT DISTINCT e1.EmployeeID,e2.EmployeeID 
FROM employees e1 
INNER JOIN Employees e2 on e1.Title=e2.Title 
WHERE e1.EmployeeID<>e2.EmployeeID



--12. Display all the Managers who have more than 2 employees reporting to them.
SELECT DISTINCT e1.LastName,e1.FirstName 
FROM Employees e1 
INNER JOIN Employees e2 
ON e1.EmployeeID=e2.ReportsTo 
GROUP BY e1.LastName,e1.FirstName 
HAVING COUNT(e1.EmployeeID) >2



--13. Display the customers and suppliers by city. The results should have the following columns




--City


--Name


--Contact Name,


--Type (Customer or Supplier)
SELECT City,ContactName FROM Customers UNION 
SELECT City,ContactName FROM Suppliers




--All scenarios are based on Database NORTHWIND.


--14. List all cities that have both Employees and Customers.
SELECT City
FROM Customers
WHERE City IN (SELECT City FROM Employees)

--15. List all cities that have Customers but no Employee.


--a. 
    
-- Use
--sub-query
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (SELECT City FROM Employees)

--b. 
    
 --Do
--not use sub-query
SELECT DISTINCT c.City
FROM Customers c, Employees e
WHERE c.City = e.City

--16. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) orderNum
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID
GROUP BY p.ProductName


--17. List all Customer Cities that have at least two customers.


--a. 
    
-- Use
--union
SELECT DISTINCT City
FROM Customers
UNION
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(City) >= 2

--b. 
    
 --Use
--sub-query and no union
SELECT DISTINCT City
FROM Customers
WHERE City IN
(SELECT City 
FROM Customers
GROUP BY City
HAVING COUNT(City) >= 2)

--18. List all Customer Cities that have ordered at least two different kinds of products.
SELECT DISTINCT City
FROM Customers
JOIN Orders
ON Orders.CustomerID = Customers.CustomerID
JOIN [Order Details]
ON [Order Details].OrderID = Orders.OrderID
GROUP BY City
HAVING COUNT([Order Details].ProductID) >= 2
ORDER BY City
 


--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 Products.ProductName, Orders.ShipCity, COUNT([Order Details].Quantity) 
AS NumberOfProducts, AVG([Order Details].UnitPrice) AS AvePrice
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
GROUP BY Products.ProductName, Orders.ShipCity
ORDER BY SUM([Order Details].Quantity) DESC

 


--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
--    from. (tip: join  sub-query)
SELECT TOP 1 COUNT([Order Details].OrderID) AS NumberOfOrders, Orders.ShipCity
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
GROUP BY Orders.ShipCity
ORDER BY COUNT([Order Details].OrderID) DESC

SELECT TOP 1 SUM([Order Details].OrderID) AS NumberOfOrders, Orders.ShipCity
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
GROUP BY Orders.ShipCity
ORDER BY SUM([Order Details].OrderID) DESC

--21. How do you remove the duplicates record of a table?
-- Use the DISTINCT or UNION to remove the duplicates record of a table.
