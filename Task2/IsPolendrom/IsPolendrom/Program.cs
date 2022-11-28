namespace IsPolendrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(">>>> Enter the number: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int input = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(">>>> "); input.CheckPolindrome();
            Console.ResetColor();
        }
    }
}