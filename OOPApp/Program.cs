using OOPApp;

Product product = new Product(); //oop
Product product1 = new Product();

product.Id = "A001";
product.Name = "Coffee";
product.Price = 100.00;
product.Stock = 10;

Console.WriteLine(product.Id);
Console.WriteLine(product.Name);
Console.WriteLine(product.Price);
Console.WriteLine(product.Stock);