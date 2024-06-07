public class Program
{
    public static void Main(string[] args)
    {
        ICoffee coffee = new Coffee();

        while (true)
        {
            Console.WriteLine("Add an addition to the coffee (milk/sugar/whipped cream/finish):");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "milk":
                    coffee = new MilkDecorator(coffee);
                    break;
                case "sugar":
                    coffee = new SugarDecorator(coffee);
                    break;
                case "whipped cream":
                    coffee = new WhipCreamDecorator(coffee);
                    break;
                case "finish":
                    Console.WriteLine($"Order: {coffee.GetDescription()}");
                    Console.WriteLine($"Cost: {coffee.GetCost()} zł");
                    return;
                default:
                    Console.WriteLine("Unknown addition, please try again.");
                    break;
            }
        }
    }
}


