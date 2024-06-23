CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL
);

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Products (ProductName) VALUES
('Milk'),
('Sour cream'),
('Yogurt'),
('Ñheese'),
('Beef'),
('Pork'),
('Baked'),
('Cake'),
('Whiskey'),
('Beer'),
('Chewing gum'),
('Fridge');

INSERT INTO Categories (CategoryName) VALUES
('Discounted'),
('Dairy'),
('meat '),
('Confectionery'),
('Alcohol'),
('Seafood');

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(5, 3),
(6, 3),
(7, 4),
(8, 4),
(9, 5),
(10, 5),
(3, 1),
(5, 1),
(8, 1),
(10, 1);

SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
