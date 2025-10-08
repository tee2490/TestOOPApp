
namespace OOPApp
{
    public class ProductService
    {
        //ออบเจค ซ้อน ออบเจค
        public List<Product> ProductList { get; set; } //List รายการข้อมูลที่ไม่จำกัด

        public ProductService()
        {
            ProductList = new List<Product>();
        }

        public void GenerateProduct()
        {
            ProductList.Add(new Product {Id="A001",Name="Coffee",Price=1000,Stock=5 });
            ProductList.Add(new Product { Id = "A002", Name = "Coffee", Price = 1000, Stock = 5 });
            ProductList.Add(new Product { Id = "A003", Name = "Coffee", Price = 1000, Stock = 5 });
        }

        public void DisplayProduct()
        {
            foreach (var item in ProductList) 
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Stock}");
            }
        }

    }
}
