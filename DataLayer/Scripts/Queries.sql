-- ######################################################################################
-- CREATE DATABASE AND TABLES
-- ######################################################################################


CREATE DATABASE crud_mvp_winforms
GO

USE crud_mvp_winforms

CREATE TABLE Articles (
    Id INT identity(1, 1) PRIMARY KEY,
    Name NVARCHAR(100),
    Description NVARCHAR(100),
    Brand NVARCHAR(100),
    Stock INT
    )

CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    DateCreated DATETIME
)
INSERT INTO Categories
VALUES
    ('Otro', sysdatetime()),
    ('Pantalones', sysdatetime()),
    ('Camisas', sysdatetime())
GO

-- ######################################################################################
-- LOAD DATASETS IN DB
-- ######################################################################################


INSERT INTO Articles
VALUES 
	('Camisa', 'algodon 100%', 100), 
	('Zapatilla', 'cuero', 200), 
	('Zapatilla', 'cuero sintético', 250), 
	('Camisa', 'algodon 75%',  150), 
	('Pantalon', 'deportivo', 200),
	('Jean', 'cuero chupin', 220),
	('Buso', 'tipo canguro, c/capucha', 120),
	('Gorra', 'blanca', 500),
	('Medias', 'tipo soquetes, p/hombre', 500),
	('Medias', 'tipo soquetes p/mujer', 400)
GO

INSERT INTO Categories
VALUES
    ('Otro'),
    ('Pantalones'),
    ('Camisas'),
    ('Medias')
GO

-- ######################################################################################
-- CREATE STORE PROCEDURES
-- ######################################################################################


CREATE PROCEDURE InsertArticle 
    @Name NVARCHAR(100),
    @Description NVARCHAR(100),
    @Stock INT,
    @CategoryId INT
AS
INSERT INTO Articles
VALUES (
    @Name,
    @Description,
    @Stock,
    @CategoryId,
    SYSDATETIME(),
    NULL
    )
GO


CREATE PROCEDURE GetArticle @Id INT
AS
SELECT *
FROM Articles
WHERE Id = @Id
GO


CREATE PROCEDURE GetArticles
AS
SELECT a.*, c.Name as CategoryName
FROM Articles a, Categories c
WHERE a.CategoryId = c.Id
GO


CREATE PROCEDURE DeleteArticle @Id INT
AS
DELETE
FROM Articles
WHERE Id = @Id
GO


CREATE PROCEDURE UpdateArticle 
    @Name NVARCHAR(100),
    @Description NVARCHAR(100),
    @Stock INT,
    @Id INT,
    @CategoryId INT
AS
UPDATE Articles
SET Name = @Name,
    Description = @Description,
    Stock = @Stock,
    CategoryId = @CategoryId,
    DateUpdated = SYSDATETIME()
WHERE Id = @Id
GO


CREATE PROCEDURE SearchArticle
    @IncludeName BIT,
    @IncludeDesc BIT,
    @Search VARCHAR(100)
AS
SELECT
    a.*, c.Name CategoryName
FROM
    Articles a, Categories c
WHERE
    (
        (@IncludeName = 1 AND a.Name LIKE '%' + @Search + '%')
        OR
        (@IncludeDesc = 1 AND a.Description LIKE '%' + @Search + '%')
    )
    AND
    @Search <> ''
    AND
    a.CategoryId = c.Id
GO


-- ######################################################################################
-- CREATE STORE PROCEDURES
-- ######################################################################################

CREATE PROCEDURE InsertCategory
    @Name VARCHAR(100)
AS
INSERT INTO Categories
VALUES (
    @Name,
    SYSDATETIME()
    )
GO


CREATE PROCEDURE GetCategories
AS
SELECT c.*, ISNULL(sub.ArticlesRelated, 0) AS ArticlesRelated
FROM Categories c
LEFT JOIN
(
    SELECT CategoryId, COUNT(*) AS ArticlesRelated
    FROM Articles
    GROUP BY CategoryId
) AS sub
ON c.Id = sub.CategoryId;
GO


CREATE PROCEDURE DeleteCategory
    @Id INT
AS
    DELETE FROM Categories WHERE Id = @Id
GO


-- ######################################################################################
-- CREATE FOREIGN KEY Articles.CategoryId AND DateCreated,DateUpdated PROPERTIES
-- ######################################################################################

ALTER TABLE Articles ADD CategoryId INT NOT NULL DEFAULT (1)
--ALTER TABLE Articles DROP COLUMN CategoryId
ALTER TABLE Articles ADD FOREIGN KEY (CategoryId) REFERENCES Categories(Id)

ALTER TABLE Articles ADD DateCreated DATETIME NOT NULL DEFAULT GETDATE()
ALTER TABLE Articles ADD DateUpdated DATETIME DEFAULT NULL


--------CHALLENGE-----------
ALTER TABLE Articles ADD Price DECIMAL(10,2)
GO

ALTER PROCEDURE InsertArticle 
    @Name NVARCHAR(100),
    @Description NVARCHAR(100),
    @Stock INT,
    @CategoryId INT,
	@Price DECIMAL(10,2)
AS
INSERT INTO Articles
VALUES (
    @Name,
    @Description,
    @Stock,
    SYSDATETIME(),
    NULL,
    @CategoryId,
	@Price
    )
GO

ALTER PROCEDURE UpdateArticle 
    @Name NVARCHAR(100),
    @Description NVARCHAR(100),
    @Stock INT,
    @Id INT,
    @CategoryId INT,
	@Price DECIMAL(10,2)
AS
UPDATE Articles
SET Name = @Name,
    Description = @Description,
    Stock = @Stock,
    DateUpdated = SYSDATETIME(),
    CategoryId = @CategoryId,
	Price = @Price
WHERE Id = @Id
GO

CREATE TABLE Orders (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    DateCreated DATETIME NOT NULL
)
GO

CREATE TABLE Orders_Article (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    DateCreated DATETIME NOT NULL,
	OrderId INT NOT NULL,
	ArticleId INT NOT NULL,
	NumberOfArticle INT NOT NULL,
	FOREIGN KEY (OrderId) REFERENCES [dbo].[Orders](Id),
	FOREIGN KEY (ArticleId) REFERENCES [dbo].[Articles](Id)
)
GO

CREATE PROCEDURE GetOrders
AS
SELECT *
FROM Orders
GO

CREATE PROCEDURE InsertOrder
AS
INSERT INTO Orders
VALUES (SYSDATETIME())
GO

CREATE PROCEDURE DeleteOrder
	 @Id integer
AS
DELETE Orders_Article
	WHERE OrderId = @Id
DELETE Orders
	WHERE Id = @Id
GO

CREATE PROCEDURE GetOrderArticlesByOrderId
    @IdOrden INT
AS
SELECT Orders_Article.*,Articles.Name AS ArticleName, Articles.Description as ArticleDescription
FROM Orders_Article 
JOIN Articles ON Articles.Id = Orders_Article.ArticleId
WHERE OrderId = @IdOrden
GO

CREATE PROCEDURE InsertOrderArticle 
    @OrderId integer,
    @ArticleId integer,
    @NumberOfArticle INT
AS
INSERT INTO Orders_Article
VALUES (
	SYSDATETIME(),
    @OrderId,
    @ArticleId,
    @NumberOfArticle
    )
GO

CREATE PROCEDURE UpdateOrderArticle 
    @ArticleId INT,
    @NumberOfArticle INT,
	@Id INT
AS
UPDATE Orders_Article
SET ArticleId = @ArticleId,
    NumberOfArticle = @NumberOfArticle
WHERE Id = @Id
GO

CREATE PROCEDURE DeleteOrderArticle
	 @Id integer
AS
DELETE Orders_Article
WHERE Id = @Id
GO

CREATE PROCEDURE SearchOrder
    @IncludeOrderNumber BIT,
    @IncludeDate BIT,
    @Search VARCHAR(100)
AS
SELECT
    *
FROM
    Orders 
WHERE
    (
        (@IncludeOrderNumber = 1 AND Id  LIKE '%' + @Search + '%')
        OR
        (@IncludeDate = 1 AND DateCreated LIKE '%' + @Search + '%')
    )
    AND
    @Search <> ''
GO

CREATE PROCEDURE SearchOrderArticle
    @IncludeArticleName BIT,
    @IncludeArticleDescription BIT,
    @Search VARCHAR(100),
	@OrderId INT
AS
SELECT
    Orders_Article.*, Articles.Name as ArticleName, Articles.Description as ArticleDescription
FROM
    Orders_Article
JOIN Articles on Articles.Id = Orders_Article.ArticleId
WHERE
    (
        (@IncludeArticleName = 1 AND Articles.Name  LIKE '%' + @Search + '%')
        OR
        (@IncludeArticleDescription = 1 AND Articles.Description LIKE '%' + @Search + '%')
    )
    AND
    @Search <> '' AND @OrderId = OrderId
GO

CREATE PROCEDURE GetStockArticle
    @IdArticle INT
AS
SELECT 
    ISNULL(A.Stock - OA.TotalOrdered, A.Stock) AS Stock,
	id
FROM
    Articles A
LEFT JOIN (
    SELECT
        ArticleId,
        SUM(NumberOfArticle) AS TotalOrdered
    FROM
        Orders_Article
	WHERE ArticleId = @IdArticle
    GROUP BY
        ArticleId
) OA ON OA.ArticleId = A.Id
WHERE Id = @IdArticle
GROUP BY
	a.id,
    A.Name,
    A.Stock,
	oa.TotalOrdered
GO

