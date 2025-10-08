
namespace OOPApp
{
    public class ProductService
    {
        //ออบเจค ซ้อน ออบเจค
        public List<Product> ProductList { get; set; } //List รายการข้อมูลที่ไม่จำกัด
        Random rnd = new Random();

        public ProductService()
        {
            ProductList = new List<Product>();
        }

        public void GenerateProduct(int number=10)
        {
            for (int i = 1; i <= number; i++) {
                var temp = new Product()
                {
                    Id = "A00" +i,
                    Name = "Coffee"+i,
                    Price = rnd.NextDouble()*100+1,
                    Stock = rnd.Next(1,11)
                };

                ProductList.Add(temp);
            }
        }

        public void DisplayProduct()
        {
            foreach (var item in ProductList) 
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price:N2} {item.Stock}");
            }
        }

        public string ShopName(string shopname = "ComSciene Shop") 
        {
            return shopname;
        }

    }
}
