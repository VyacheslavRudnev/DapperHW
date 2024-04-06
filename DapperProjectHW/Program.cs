using Dapper;
using DapperProjectHW;
using System.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DapperDB;Integrated Security=True;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    //***Створення таблиці***
    //connection.Execute("create table Product(id int primary key identity, name varchar(64), price int)");

    //***Додавання даних в таблицю***
    //List<Product> productsToAdd = new List<Product>()
    //{
    //    new Product() { Name = "Prod 1", Price = 122 },
    //    new Product() { Name = "Prod 2", Price = 150 },
    //    new Product() { Name = "Prod 3", Price = 200 },
    //    new Product() { Name = "Prod 4", Price = 177 },
    //    new Product() { Name = "Prod 5", Price = 222 },
    //};

    //string insertQuery = "insert into Product (Name, Price) values (@name, @price)";
    //connection.Execute(insertQuery, productsToAdd);

    //Console.WriteLine($"Додано {productsToAdd.Count} нових продуктів.");

    //***Оновлення даних***
    //string updateProductName = "Prod 3";
    //int newPrice = 777;

    //string updateQuery = "update Product set Price = @newPrice where Name = @name";
    //connection.Execute(updateQuery, new { newPrice, name = updateProductName });

    //Console.WriteLine($"Продукт {updateProductName} оновлено з новою ціною {newPrice}.");
    //Console.WriteLine();

    //***Видалення даних***
    //string deleteProductName = "Prod 1";
    //string deleteQuery = "delete from Product where Name = @name";
    //connection.Execute(deleteQuery, new { name = deleteProductName });
    //Console.WriteLine($"Продукт {deleteProductName} видалено.");
    //Console.WriteLine();

    //***отримання результату***
    var list = connection.Query<Product>("select * from Product");
    foreach (var item in list)
    {
        var product = item as Product;
        Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
    }


}