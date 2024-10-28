Ответ на второе задание: 

SELECT 
    Products.Product_Name,
    Categories.Category_Name
FROM 
    Products
LEFT JOIN 
    Product_Categories ON Products.ProductID = Product_Categories.ProductID
LEFT JOIN 
    Categories ON Product_Categories.CategoryID = Categories.CategoryID;

![image](https://github.com/user-attachments/assets/19b0e43e-07e3-4e48-9540-69ce448e5fd2)

