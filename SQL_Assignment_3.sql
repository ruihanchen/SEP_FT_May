use Northwind
GO
--1. Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
GO
--drop view view_product_order_Chen
CREATE VIEW view_product_order_Chen 
AS

SELECT ProductID, Quantity
FROM [Order Details]

--SELECT p.productid,p.productname,SUM(od.quantity)'total quantity' FROM Products p 
--JOIN[Order Details] od 
--ON p.ProductID=od.ProductID 
--GROUP BY p.ProductID,p.ProductName


--2. Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id 
--as an input and total quantities of order as output parameter.
CREATE PROC sp_product_order_quantity_Chen
@pid INT,
@total_quantity float(20) OUTPUT
AS
BEGIN
SELECT @total_quantity = SUM(Quantity) FROM [Order Details] WHERE ProductID = @pid GROUP BY ProductID
END

BEGIN
DECLARE @total_quantity varchar(20)
EXEC sp_product_order_quantity_Chen 2, @total_quantity out
PRINT @total_quantity
END

--DROP PROC sp_product_order_quantity_Chen



--3. Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and top 5 cities 
--that ordered most that product combined with the total quantity of that product ordered from that city as output.
CREATE PROC sp_product_order_city_Chen
@product_name varchar(50), 
@order_city varchar(50)OUTPUT,
@nums varchar(50) OUTPUT
AS
BEGIN 
SELECT @product_name=ss.productname FROM(SELECT TOP 5 d.ProductID,
d.ProductName
FROM (SELECT p.ProductID,p.ProductName,SUM(od.quantity) t FROM Products p
INNER JOIN[Order Details] od 
ON p.ProductID=od.ProductID
GROUP BY p.ProductID,p.ProductName) AS [d] ORDER BY d.t DESC)ss
LEFT JOIN(
SELECT*FROM(SELECT dd.productid, dd.city,RANK() OVER(PARTITION BY productid ORDER BY q DESC) [rk] FROM
(SELECT p.ProductID,c.city,SUM(od.quantity)q FROM Customers c 
JOIN orders o ON c.CustomerID=o.CustomerID 
LEFT JOIN [Order Details] od ON o.OrderID=od.OrderID 
LEFT JOIN Products p ON od.ProductID=p.ProductID
GROUP BY p.ProductID,c.City)dd)cc WHERE cc.rk=1)x 
ON ss.productid=x.productid
WHERE x.city=@order_city
END

DROP PROC sp_product_order_city_Chen

--4. Create 2 new tables “people_your_last_name” “city_your_last_name”. City table has two records: {Id:1, City: Seattle}, 
--{Id:2, City: Green Bay}. People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, 
--{Id: 3, Name: Jody Nelson, City:2}. Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. 
--Create a view “Packers_your_name” lists all people from Green Bay. 
--If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
CREATE TABLE people_Chen(id int,name char(20),cityid int)
CREATE TABLE city_Chen(cityid int,city char(20))

INSERT INTO people_Chen(id,name,cityid)values(1,'Aaron Rodgers',2)
INSERT INTO people_Chen(id,name,cityid)values(2,'Russell Wilson',1)
INSERT INTO people_Chen(id,name,cityid)values(3,'Jody Nelson',2)
INSERT INTO city_Chen(cityid,city)values(1,'Settle')
INSERT INTO city_Chen(cityid,city)values(2,'Green Bay')

UPDATE city_Chen
SET City=  'Madison'
WHERE city_Chen.cityid = 1

Go

CREATE VIEW Packers_Ruihan_Chen
AS
SELECT p.Name
FROM city_Chen c JOIN people_Chen p ON p.id = c.cityid
WHERE c.City In ('Green Bay')

DROP TABLE people_Chen
DROP TABLE city_Chen
DROP VIEW Packers_Ruihan_Chen


--5.       Create a stored procedure “sp_birthday_employees_[you_last_name]” that creates a new table “birthday_employees_your_last_name” 
--and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
CREATE PROC sp_birthday_employees_Chen
AS 
BEGIN
CREATE TABLE birthday_employees_Chen (id int primary key not null, name varchar(40), dob date)
INSERT INTO birthday_employees_Chen VALUES(1, 'John', 1945-2-15)
INSERT INTO birthday_employees_Chen VALUES(2, 'Jay', 1985-2-5)
INSERT INTO birthday_employees_Chen VALUES(3, 'James', 1995-2-25)
END

EXEC sp_birthday_employees_Chen

DROP TABLE birthday_employees_Chen

DROP PROC sp_birthday_employees_Chen

--6. How do you make sure two tables have the same data?
-- Use TABLEDIFF() function