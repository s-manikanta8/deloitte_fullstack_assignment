Create Database  Sept2024Db

CREATE TABLE product
(
	productid INT PRIMARY KEY, 
	pname VARCHAR(130),
	price int,
	quantity int,
	category varchar(45)
)
INSERT INTO product VALUES(7369,'mouse',500,8,'computer');
INSERT INTO product VALUES(7499,'keyboard',800,16,'computer');
INSERT INTO product VALUES(7521,'chair',1000,12,'furniture');
INSERT INTO product VALUES(7566,'table',3000,29,'furniture');
INSERT INTO product VALUES(7654,'cricket bat',1200,12,'sports');
INSERT INTO product VALUES(7698,'shuttle bat',400,28,'sports');

SELECT * FROM product
SELECT price  FROM product WHERE productid=7499
SELECT COUNT(*) FROM product WHERE category='computer'
