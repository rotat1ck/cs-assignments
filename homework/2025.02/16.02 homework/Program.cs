using System.Runtime.Intrinsics.X86;

class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(0 - 9): ");
            Console.Clear();
            switch (press) {
                case ConsoleKey.D0: {
                    One();
                    break;
                } case ConsoleKey.D1: {
                    Two();
                    break;
                } case ConsoleKey.D2: {
                    Three();
                    break;
                } case ConsoleKey.D3: {
                    Four();
                    break;
                } case ConsoleKey.D4: {
                    Five();
                    break;
                } case ConsoleKey.D5: {
                    // Six();
                    break;
                } case ConsoleKey.D6: {
                    // Seven();
                    break;
                } case ConsoleKey.D7: {
                    // Eight();
                    break;
                } case ConsoleKey.D8: {
                    // Nine();
                    break;
                } case ConsoleKey.D9: {
                    // Ten();
                    break;
                } default: {
                    invalidInput = true;
                    break;
                }
            }
        }
    }
    static bool invalidInput = false;

    static ConsoleKey getKeyPress(string msg) {
        ConsoleKeyInfo keyPressed;

        while (true) {
            if (invalidInput) {
                Console.WriteLine("Invalid input!\n");
            }
            invalidInput = false;
            Console.Write(msg);
            keyPressed = Console.ReadKey();
            Console.WriteLine();

            if (keyPressed.Key == ConsoleKey.Escape) {
                Environment.Exit(0);
            } else {
                return keyPressed.Key;
            }
        }
    }

    static void One() {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = n / 10 % 10, b = n % 10;

        int[] one = [4, 7];
        int[] two = [3, 6, 9];

        foreach (int i in one) {
            if (a == i || b == i) {
                Console.WriteLine($"{n} contains 4 or 7");
                break;
            }
        }

        foreach (int i in two) {
            if (a == i || b == i) {
                Console.WriteLine($"{n} contains 3 or 6 or 9");
                break;
            }
        }
        Console.WriteLine();
    }

    static void Two() {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int nCopy = n;
        int[] nums = new int[10];
        int pointer = 0;

        while (nCopy > 0) {
            nums[pointer] = nCopy % 10;
            nCopy /= 10;
            pointer++;
        }

        bool isThree = false;
        int foundNum = 0;

        for (int i = 0; i < pointer; ++i) {
            int count = 0;
            for (int j = 0; j < pointer; ++j) {
                if (nums[j] == nums[i]) {
                    count++;
                } 
            }
            if (count == 3) {
                isThree = true;
                foundNum = nums[i];
                break;
            }
        }

        if (isThree) {
            Console.WriteLine($"{n} contains three {foundNum}'s");
        } else {
            Console.WriteLine($"{n} does not contain three of the same digit");
        }
        Console.WriteLine();
    }

    static void Three() {
        double a, b, c, d;
        Console.Write("Enter 4 digits: ");
        string[] input = Console.ReadLine().Split();
        a = Convert.ToDouble(input[0]);
        b = Convert.ToDouble(input[1]);
        c = Convert.ToDouble(input[2]);
        d = Convert.ToDouble(input[3]);

        int count = 0;

        if (a < 0) {
            count++;
        } if (b < 0) {
            count++;
        } if (c < 0) {
            count++;
        } if (d < 0) {
            count++;
        }

        Console.WriteLine($"You entered {count} negative numbers");
        Console.WriteLine();
    }

    static void Four() {
        double a, b, c;
        Console.Write("Enter a, b, c: ");
        string[] input = Console.ReadLine().Split();
        a = Convert.ToDouble(input[0]);
        if (a == 0) {
            Console.WriteLine("a can't be zero");
            Console.WriteLine();
            return;
        }
        b = Convert.ToDouble(input[1]);
        c = Convert.ToDouble(input[2]);

        double D = b * b - 4 * a * c;

        if (D < 0) {
            Console.WriteLine("No solution");
        } else if (D == 0) {
            double x = -b / (2 * a);
            Console.WriteLine($"One solution: {x}");
        } else {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"Solutions: {x1} and {x2}");
        }
        Console.WriteLine();
    }

    static void Five() {
        double a1, b1, c1, a2, b2, c2;
        double mid1, mid2;

        Console.Write("Enter first row: ");
        string[] input1 = Console.ReadLine().Split();
        a1 = Convert.ToDouble(input1[0]);
        b1 = Convert.ToDouble(input1[1]);
        c1 = Convert.ToDouble(input1[2]);
        if (a1 == b1 || b1 == c1 || a1 == c1) {
            Console.WriteLine("All numbers must be different");
            Console.WriteLine();
            return;
        }

        double[] firstRow = [a1, b1, c1];
        Array.Sort(firstRow);
        mid1 = firstRow[1];

        Console.Write("Enter second row: ");
        string[] input2 = Console.ReadLine().Split();
        a2 = Convert.ToDouble(input2[0]);
        b2 = Convert.ToDouble(input2[1]);
        c2 = Convert.ToDouble(input2[2]);
        if (a2 == b2 || b2 == c2 || a2 == c2) {
            Console.WriteLine("All numbers must be different");
            Console.WriteLine();
            return;
        }

        double[] secondRow = [a2, b2, c2];
        Array.Sort(secondRow);
        mid2 = secondRow[1];

        Console.WriteLine($"Average of {mid1} and {mid2}: {(mid1 + mid2) / 2}");
        Console.WriteLine();
    }
}