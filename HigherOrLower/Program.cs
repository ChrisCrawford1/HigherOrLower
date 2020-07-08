namespace HigherOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Game game = new Game(numbers.GetNumberStack());
            game.Run();
        }
    }
}
