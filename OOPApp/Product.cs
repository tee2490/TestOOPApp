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

        public void Input(string id, string name, double price, int stock)
        { 
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void Display() //เมธอดธรรมดา
        {
            Console.WriteLine($"{Id} {Name} {Price} {Stock}");
        }

    }
}
