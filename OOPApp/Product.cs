namespace OOPApp
{
    public class Product
    {
        //properties
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        // private: เข้าถึงได้เฉพาะภายในคลาส Product เท่านั้น
        private double costPrice;

        // protected: เข้าถึงได้ในคลาสนี้ และคลาสที่สืบทอดจากมัน (inherit)
        protected double discountRate;

        // internal: เข้าถึงได้เฉพาะภายใน assembly (โปรแกรมเดียวกัน)
        internal int warehouseStock;


        public static string ShopName { get; set; } = "ComScience Shop";

        public Product() //constructor
        {
           // Console.WriteLine("start");  
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
            Console.WriteLine($"{Id} {Name} {Price} {Stock} {costPrice}");
        }

        public void SetCostPrice(double costPrice) //เข้าถึงแบบทางอ้อม
        { 
            this.costPrice = costPrice;
        }

        public double GetCostPrice() => costPrice; //เข้าถึงแบบทางอ้อม


    }
}
