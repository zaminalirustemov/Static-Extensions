namespace Find_the_number_in_the_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">>>> Enter word: <<<<");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">>>> "); string value = Console.ReadLine(); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">>>> "); Console.WriteLine( value.HasDigit()); 
            Console.ResetColor();
        }
    }
}