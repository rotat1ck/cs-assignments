namespace Nums {
    class Even {
        public static int GenerateEven(int start, int end) {
            Random rnd = new Random();
            return 2 * rnd.Next(start, end);
        }
    }

    class Odd {
        public static int GenerateOdd(int start, int end) {
            Random rnd = new Random();
            return 2 * rnd.Next(start, end) + 1;
        }
    }

    class Prime {
        public static int GeneratePrime(int start, int end) {
            Random rnd = new Random();
            int num = rnd.Next(start, end);
            while (IsPrime(num) == false) {
                num = rnd.Next(start, end);
            }
            return num;
        }

        private static bool IsPrime(int number) {
            for (int i = 2; i < number / 2; i++) {
                if (number % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }

    class Fib {
        public static int GenerateFib(int start, int end) {
            Random rnd = new Random();
            int num = rnd.Next(start, end);
            while (IsFib(num) == false) {
                num = rnd.Next(start, end);
            }
            return num;
        }

        private static bool IsFib(int number) {
            int a = 0, b = 1, temp;
            while (b < number) {
                temp = a;
                a = b;
                b = temp + b;
            }
            return b == number;
        }
    }
}