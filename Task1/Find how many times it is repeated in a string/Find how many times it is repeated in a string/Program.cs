namespace Find_how_many_times_it_is_repeated_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Cut";
            string sentence = "Cut cuce, cut cut cuce, uc cut cuce";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($">>>>>>>> Sentence: {sentence}");
            Console.WriteLine($">>>> Checked word: {word}");
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine($">>>> Repeat count: {sentence.MatchCount(word)} pieces.");
            Console.ResetColor();
        }
    }
}