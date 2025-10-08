
using OOPApp;

var ps = new ProductService();

ps.GenerateProduct(20);

Console.WriteLine($"======= {ps.ShopName("My Shop")} =========");
ps.DisplayProduct();