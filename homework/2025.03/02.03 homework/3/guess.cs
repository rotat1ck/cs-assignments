namespace Guess {
    class Game {
        int start = 1;
        int end = 1000;

        public void Play(int number) {
            if (number < start || number > end) {
                return;
            }
            Random rnd = new Random();
            int num = rnd.Next(start, end);
            int tries = 1;
            while (num != number) {
                num = rnd.Next(start, end);
                tries++;
            }
            Console.WriteLine($"It took {tries} tries to find the number");
        }
    }
}