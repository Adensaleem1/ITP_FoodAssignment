using System;

namespace ITP_FoodAssignment
{
    class Food
    {
        public int FoodID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Cost { get; set; }

        public override string ToString()
        {
            return $"{FoodID}\t{Name}\t{Description}\t${Cost:F2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food
            {
                FoodID = 1,
                Name = "Burger",
                Description = "Juicy beef burger with cheese",
                Cost = 5.99
            };

            Food food2 = new Food
            {
                FoodID = 2,
                Name = "Pizza",
                Description = "Cheesy pepperoni pizza slice",
                Cost = 3.49
            };

            Console.WriteLine("FoodID\tName\tDescription\tCost");
            Console.WriteLine(food1);
            Console.WriteLine(food2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
