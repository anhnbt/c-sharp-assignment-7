CREATE DATABASE Products
GO
Use Products
GO
CREATE Table Products(
	ProductID int primary key identity,
	ProductName nvarchar(50),
	ImagePath varchar(50),
	Selected bit
)
GO
INSERT INTO Products 
SELECT 'Nokia 2222','images\mobile1.jpg',0 UNION ALL
SELECT 'Nokia 7777','images\mobile2.jpg',0 UNION ALL
SELECT 'Google G1','images\mobile3.jpg',0 UNION ALL
SELECT 'Nokia N-Gate','images\mobile4.jpg',0 UNION ALL
SELECT 'BlackBerry 111','images\mobile5.jpg',1 UNION ALL
SELECT 'IPHONE 4','images\mobile6.jpg',0 UNION ALL
SELECT 'LG 333','images\mobile7.jpg',0 UNION ALL
SELECT 'Samsung 8888','images\mobile8.jpg',1
GO