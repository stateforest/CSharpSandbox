namespace CSharpSandbox
{
    internal class Eggs
    {
        static void Main(string[] args)
        {
            int eggsChicken1;
            int eggsChicken2;
            int eggsChicken3;
            int eggsChicken4;

            int eggsTotal;
            int eggsDozen;
            int eggsRemainder;

            Console.WriteLine("Input egg count for the first chicken: ");
            eggsChicken1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input egg count for the second chicken: ");
            eggsChicken2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input egg count for the third chicken: ");
            eggsChicken3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input egg count for the fourth chicken: ");
            eggsChicken4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            eggsTotal = eggsChicken1 + eggsChicken2 + eggsChicken3 + eggsChicken4;
            eggsDozen = eggsTotal / 12;
            eggsRemainder = eggsTotal % 12;

            Console.WriteLine($"There are {eggsTotal} total eggs, making {eggsDozen} dozen eggs with {eggsRemainder} remaining.");
            Console.WriteLine();
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}