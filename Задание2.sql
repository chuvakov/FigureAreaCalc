CREATE DATABASE Shop;
USE Shop;

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(256)
);

CREATE TABLE Products
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(256)
);

CREATE TABLE CategoryProducts
(
	ProductId INT REFERENCES Products,
	CategoryId INT REFERENCES Categories
); 

INSERT INTO Categories(Name) VALUES
('category1'), 
('category2'),
('category3'),
('category4'),
('category5'),
('category6');

INSERT INTO Products(Name) VALUES
('productCode1'),
('productCode2'),
('productCode3'),
('productCode4'),
('productCode5'),
('productCode6'),
('productCode7'),
('productCode8'),
('productCode9');

INSERT INTO CategoryProducts VALUES
(1,1),
(2,1),
(4,2),
(5,2),
(7,3),
(8,4),
(9,5);

SELECT p.Name, c.Name 
FROM Products p 
LEFT JOIN CategoryProducts cp ON cp.ProductId = p.Id 
LEFT JOIN Categories c ON c.Id = cp.CategoryId;
