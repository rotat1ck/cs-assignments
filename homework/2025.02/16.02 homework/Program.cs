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
                    Six();
                    break;
                } case ConsoleKey.D6: {
                    Seven();
                    break;
                } case ConsoleKey.D7: {
                    Eight();
                    break;
                } case ConsoleKey.D8: {
                    Nine();
                    break;
                } case ConsoleKey.D9: {
                    Ten();
                    break;
                } default: {
                    invalidInput = true;
                    break;
                }
            }
        }

        // 🥨
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

    static void Six() {
        Console.Write("Enter day number: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day) {
            case 1: {
                Console.WriteLine("Monday");
                break;
            } case 2: {
                Console.WriteLine("Tuesday");
                break;
            } case 3: {
                Console.WriteLine("Wednesday");
                break;
            } case 4: {
                Console.WriteLine("Thursday");
                break;
            } case 5: {
                Console.WriteLine("Friday");
                break;
            } case 6: {
                Console.WriteLine("Saturday");
                break;
            } case 7: {
                Console.WriteLine("Sunday");
                break;
            } default: {
                Console.WriteLine("Invalid day");
                break;
            }
        }
        Console.WriteLine();
    }

    static void Seven() {
        Console.Write("Enter month number: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day) {
            case 1: {
                Console.WriteLine("January");
                break;
            } case 2: {
                Console.WriteLine("February");
                break;
            } case 3: {
                Console.WriteLine("March");
                break;
            } case 4: {
                Console.WriteLine("April");
                break;
            } case 5: {
                Console.WriteLine("May");
                break;
            } case 6: {
                Console.WriteLine("June");
                break;
            } case 7: {
                Console.WriteLine("July");
                break;
            } case 8: {
                Console.WriteLine("August");
                break;
            } case 9: {
                Console.WriteLine("September");
                break;
            } case 10: {
                Console.WriteLine("October");
                break;
            } case 11: {
                Console.WriteLine("November");
                break;
            } case 12: {
                Console.WriteLine("December");
                break;
            } default: {
                Console.WriteLine("Invalid month");
                break;
            }
        }
        Console.WriteLine();
    }

    static void Eight() {
        int birthYear, birthMonth, birthDay, currentYear, currentMonth, currentDay;
        
        Console.Write("Enter birth year, month, day: ");
        string[] birthdate = Console.ReadLine().Split();
        birthYear = Convert.ToInt32(birthdate[0]);
        birthMonth = Convert.ToInt32(birthdate[1]);
        birthDay = Convert.ToInt32(birthdate[2]);

        Console.Write("Enter current year, month, day: ");
        string[] curdate = Console.ReadLine().Split();
        currentYear = Convert.ToInt32(curdate[0]);
        currentMonth = Convert.ToInt32(curdate[1]);
        currentDay = Convert.ToInt32(curdate[2]);

        int age = currentYear - birthYear;

        if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay)) {
            age--;
        }

        Console.WriteLine($"Age: {age}");
        Console.WriteLine();
    }

    static void Nine() {
        int a, b;
        Console.Write("Enter A: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 50) {
            Console.WriteLine("A is greater than 50");
            return;
        }
        Console.Write("Enter B: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (b < 10) {
            Console.WriteLine("B is less than 10");
            return;
        } if (b > a) {
            Console.WriteLine("B is greater than A");
            return;
        }

        Console.CursorTop = 3;
        Console.Write("┌────┐\n│  a │\n├────┤\n");
        for (int i = 20; i <= 35; ++i) {
            Console.WriteLine($"│ {i} │");
        }
        Console.WriteLine("└────┘");

        
        Console.CursorTop = 3;
        Console.CursorLeft = 10;
        Console.WriteLine("┌────┐");
        Console.CursorLeft = 10;
        Console.WriteLine("│  d │");
        Console.CursorLeft = 10;
        Console.WriteLine("├────┤");
        for (int i = b; i <= a; ++i) {   
            Console.CursorLeft = 10;
            Console.WriteLine($"│ {i} │");
        }
        Console.CursorLeft = 10;
        Console.WriteLine("└────┘");

        void printb(int adgust) {
            Console.CursorTop = 3;
            Console.CursorLeft = adgust;
            Console.WriteLine("┌───────┐");
            Console.CursorLeft = adgust;
            Console.WriteLine("│   b   │");
            Console.CursorLeft = adgust;
            Console.WriteLine("├───────┤");

            for (int i = 10; i <= b; ++i) {   
                Console.CursorLeft = adgust; 
                Console.WriteLine($"│ {i * i, 5} │");
            }
            Console.CursorLeft = adgust;
            Console.WriteLine("└───────┘");
        }

        void printc(int adgust) {
            Console.CursorTop = 3;
            Console.CursorLeft = adgust;
            Console.WriteLine("┌──────────┐");
            Console.CursorLeft = adgust;
            Console.WriteLine("│     c    │");
            Console.CursorLeft = adgust;
            Console.WriteLine("├──────────┤"); 

            for (int i = a; i <= 50; ++i) {   
                Console.CursorLeft = adgust;
                Console.WriteLine($"│ {i * i * i, 8} │");
            }

            Console.CursorLeft = adgust;
            Console.WriteLine("└──────────┘");
        }

        if (b - 10 > 50 - a) {
            printc(20);
            printb(36);
        } else {
            printb(20);
            printc(34);
        }
        Console.WriteLine();
    }

    static void Ten() {
        double R = 6370;
        Console.WriteLine("Height above earth │ Distance to horizon");
        Console.WriteLine("───────────────────┼────────────────────");
        for (int i = 10; i >= 1; --i) {
            double d = Math.Sqrt(2 * R * i + i * i);
            Console.WriteLine($"{i,18} │ {d:F2}");
        }
        Console.WriteLine();
    }
}