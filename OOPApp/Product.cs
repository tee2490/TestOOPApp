namespace OOPApp
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product() //constructor
        {
            Console.WriteLine("start");  
        }

    }
}
