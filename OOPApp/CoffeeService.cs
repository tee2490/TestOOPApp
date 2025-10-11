namespace OOPApp
{
    public class CoffeeService
    {
        List<Coffee> Coffeelist;
        Random rnd;

        public CoffeeService() //Constructor
        {
            Coffeelist = new List<Coffee>();
            rnd = new Random();
        }

        public void GenerateCoffee(int number = 10)
        {
            for (int i = 1; i <= number; i++)
            {
                Coffee coffee = new Coffee()
                {
                    Id = "ID" + i,
                    Name = "CoffeeNew" + i,
                    Price = rnd.NextDouble() * 100 + 1,
                    Stock = rnd.Next(1, 11),
                    RoastLevel = $"Level{rnd.Next(1, 4)}",
                    Origin = $"Area{rnd.Next(1, 5)}"
                };
                coffee.SetDiscountRate(rnd.NextDouble()); //กำหนดค่าผ่านเมธอด

                Coffeelist.Add(coffee); //เพิ่มกาแฟแต่ละอันเข้าไปในลิส
            }
        }

        public void DisplayCoffee()
        {
            foreach (var c in Coffeelist)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Price} {c.Stock}" +
                    $" {c.RoastLevel} {c.Origin} {c.GetDiscountRate()}");
            }
        }

    }
}
