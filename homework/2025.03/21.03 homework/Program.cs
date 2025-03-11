namespace Morse {
    class Code {
        static void Main() {
            string input = "abc";
            Console.WriteLine(Morse.toMorse(input));
            string from = ".- -... -.-.";
            Console.WriteLine(Morse.fromMorse(from));
        }
    }
}