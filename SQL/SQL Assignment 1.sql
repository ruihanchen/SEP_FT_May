use AdventureWorks2019
GO

--Question1. Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
--from the Production.Product table, with no filter. 

--Answer:

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--Question2. Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
--from the Production.Product table, excluding the rows that ListPrice is 0.

--Answer:

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

--Question3. Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
--from the Production.Product table, the rows that are not NULL for the Color column.

--Answer:

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

--Question4. Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
--from the Production.Product table, the rows that are not NULL for the column Color, and the column ListPrice 
--has a value greater than zero.

--Answer:

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0 AND Color IS NOT NULL

--Question5. Write a query that concatenates the columns Name and Color
--from the Production.Product table by excluding the rows that are null for color.

--Answer:

SELECT Name + ' ' + Color
FROM Production.Product
WHERE Color IS NOT NULL

--Question6. Write a query that generates the following result set from
--Production.Product:
--NAME: LL Crankarm  --  COLOR: Black
--NAME: ML Crankarm  --  COLOR: Black
--NAME: HL Crankarm  --  COLOR: Black
--NAME: Chainring Bolts  --  COLOR: Silver
--NAME: Chainring Nut  --  COLOR: Silver
--NAME: Chainring  --  COLOR: Black

--Answer:

SELECT 'NAME: ' + Name + ' -- COLOR: ' + Color
FROM Production.Product
WHERE Color IS NOT NULL

--Question7.Write a query to retrieve the to the columns ProductID and Name 
--from the Production.Product table filtered by ProductID from 400 to 500 using between.

--Answer:

SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--Question8. Write a query to retrieve the to the columns  ProductID, Name and color
--from the Production.Product table restricted to the colors black and blue.

--Answer:

SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black', 'Blue')

--Question9. Write a query to get a result set on products that begins with the letter S. 

--Answer:

SELECT Name
FROM Production.Product
WHERE Name LIKE 'S%'


--Question10. Write a query that retrieves the columns Name and ListPrice
--from the Production.Product table. Your result set should look something like the following. Order the result set
--by the Name column. The products name should start with either 'A' or 'S'.
--Name                                            ListPrice
--Adjustable Race                                   0,00
--All-Purpose Bike Stand                       159,00
--AWC Logo Cap                                      8,99
--Seat Lug                                          0,00
--Seat Post                                         0,00

--Answer:

SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
ORDER BY NAME

--Question11. Write a query so you retrieve rows that have a Name that begins with the letters SPO, 
--but is then not followed by the letter K. After this zero or more letters can exists. Order the result set by the Name column.

--Answer:

SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%'
ORDER BY NAME

--Question12. Write a query that retrieves the unique combination of columns ProductSubcategoryID and Color from the Production.Product table. 
--We do not want any rows that are NULL.in any of the two columns in the result. (Hint: Use IsNull)

--Answer:

SELECT DISTINCT IsNull(ProductSubcategoryID, 0), IsNull(Color, 0)
FROM Production.Product
