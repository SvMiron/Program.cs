namespace Program.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the cost of notebooks: ");
            int x = Convert.ToInt32 (Console.ReadLine()); //Стоимость тетради
            Console.Write("Enter the cost of pens: ");
            int y = Convert.ToInt32(Console.ReadLine()); //Стоимость ручки
            Console.Write("Enter the number of notebooks: ");
            int n = Convert.ToInt32(Console.ReadLine()); //Количество тетрадей
            Console.Write("Enter the number of pens: ");
            int m = Convert.ToInt32(Console.ReadLine()); //Количество ручек
            int totalAmount = x*n + y*m;
            Console.WriteLine($"Total amount of purchase: {totalAmount}");
        }
    }
}