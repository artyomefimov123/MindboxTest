--В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
-----------
--Products-   --Products_Categories-   --Categories-
--Id-------   --ProductId-----------   --Id---------
--Name-----   --CategoryId----------   --Name-------
-----------   ----------------------   -------------

SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN Products_Categories
	ON Products.Id=Products_Categories.ProductId
LEFT JOIN Categories 
	ON Categories.Id=Products_Categories.CategoryId





