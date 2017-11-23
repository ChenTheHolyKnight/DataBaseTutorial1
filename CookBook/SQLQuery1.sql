Select * From Receipe

select * from Ingredient

select a.Name from Ingredient a
Inner Join ReceipeIngredient b On a.Id = b.IngredientId
WHERE b.ReceipeId = 6;


Update Receipe
SET Name = 'Salad'
where Id = 5;

INSERT INTO Receipe
VALUES('Salad 4',50,'Combine everything');

Delete FROM Receipe
where Id=10;


