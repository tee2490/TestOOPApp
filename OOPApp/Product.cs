namespace OOPApp
{
    public class Product
    {
        //properties
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product() //constructor
        {
            Console.WriteLine("start");  
        }

        public void Input(string Id, string Name, double Price, int Stock)
        {  
            //this ตัวค่าต่างๆ ของออบเจค
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
        }

        public void Display() //เมธอดธรรมดา
        {
            Console.WriteLine($"{Id} {Name} {Price} {Stock}");
        }

    }
}
