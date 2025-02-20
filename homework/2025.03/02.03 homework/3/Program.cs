namespace Guess {
    class Code {
        static void Main() {
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out int number);
            Game game = new Game();
            game.Play(number);
        }
    }
}