using DZ_09_02_24;

//using (ApplicationContext db = new ApplicationContext())
//{
//    db.Database.EnsureDeleted();
//    db.Database.EnsureCreated();

//    var user1 = new User { Username = "user1" };
//    var user2 = new User { Username = "user2" };

//    var userService = new UserService(db);

//    userService.AddUser(user1);
//    userService.AddUser(user2);


//    var products = new List<Product>
//    {
//        new Product {Name = "Product 1", Description = "Descrtiption 1", Price = 10.99m, AvailableQuantity = 100, Timestamp = GenerateTimestamp()},
//        new Product {Name = "Product 2", Description = "Descrtiption 2", Price = 20.49m, AvailableQuantity = 50, Timestamp = GenerateTimestamp() },
//        new Product { Name = "Product 3", Description = "Descrtiption 3", Price = 5.99m, AvailableQuantity = 200, Timestamp = GenerateTimestamp() },
//        new Product { Name = "Product 4", Description = "Descrtiption 4", Price = 15.79m, AvailableQuantity = 75, Timestamp = GenerateTimestamp()},
//        new Product { Name = "Product 5", Description = "Descrtiption 5", Price = 8.49m, AvailableQuantity = 150, Timestamp = GenerateTimestamp() },
//        new Product { Name = "Product 6", Description = "Descrtiption 6", Price = 12.99m, AvailableQuantity = 120, Timestamp = GenerateTimestamp() },
//        new Product { Name = "Product 7", Description = "Descrtiption 7", Price = 18.99m, AvailableQuantity = 80, Timestamp = GenerateTimestamp() },
//        new Product { Name = "Product 8", Description = "Descrtiption 8", Price = 22.49m, AvailableQuantity = 100, Timestamp = GenerateTimestamp() },
//        new Product { Name = "Product 9", Description = "Descrtiption 9", Price = 6.99m, AvailableQuantity = 300, Timestamp = GenerateTimestamp() },
//        new Product { Name = "Product 10", Description = "Descrtiption 10", Price = 14.99m, AvailableQuantity = 90, Timestamp = GenerateTimestamp() }
//    };

//    var productService = new ProductService(db);

//    foreach (var product in products)
//    {
//        productService.AddProduct(product);
//    }
//}

var timestamp = new byte[8];
new Random().NextBytes(timestamp);
byte[] GenerateTimestamp()
{
    var timestamp = new byte[8];
    new Random().NextBytes(timestamp);
    return timestamp;
}

//using (ApplicationContext db = new ApplicationContext())
//{

//    var productService = new ProductService(db);

//    var updatedProduct = new Product
//    {
//        Id = 1,
//        Name = "New Product",
//        Description = "New Description Product",
//        Price = 25.99m,
//        AvailableQuantity = 200,
//        //Timestamp = GenerateTimestamp()
//    };

//    productService.UpdateProduct(updatedProduct);
//}

//using (ApplicationContext db = new ApplicationContext())
//{
//    var productService = new ProductService(db);
//    int productIdToDelete = 2;
//    productService.DeleteProduct(productIdToDelete);
//}

