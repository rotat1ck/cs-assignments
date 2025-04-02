using System.Collections;

static class Archive {
    public static void BubbleSort(List<int> nums) {
        bool sorted = false;
        while (!sorted) {
            sorted = true;
            for (int i = 0; i < nums.Count - 1; i++) {
                if (nums[i] > nums[i + 1]) {
                    (nums[i + 1], nums[i]) = (nums[i], nums[i + 1]);
                    sorted = false;
                }
            }
        }

        foreach (var num in nums) {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");
    }

    public static void FastSort(ArrayList array) {
        bool sorted = false;
        while (!sorted) {
            sorted = true;
            for (int i = 0; i < array.Count - 1; i++) {
                if (((IComparable?)array[i]).CompareTo(array[i + 1]) > 0) {
                    (array[i + 1], array[i]) = (array[i], array[i + 1]);
                    sorted = false;
                }
            }
        }


        foreach (var num in array) {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");
    }

    public static void Lenght() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        int count = 0;
        foreach (char c in input) {
            count++;
        }
        Console.WriteLine($"Result: {count}\n");
    }

    public static void Reverse() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        string res = "";
        for (int i = input.Length - 1; i >= 0; i--) {
            res += input[i] + " ";
        }
        Console.WriteLine($"Result: {res}\n");
    }

    public static void Count() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Result: {input.Length}\n");
    }

    public static void Compare() {
        Console.Write("Enter first sentence: ");
        string? input1 = Console.ReadLine();
        Console.Write("Enter second sentence: ");
        string? input2 = Console.ReadLine();
        int len1 = input1.Length;
        int len2 = input2.Length;
        int minLen = Math.Min(len1, len2);
        for (int i = 0; i < minLen; i++) {
            if (input1[i] < input2[i]) {
                Console.WriteLine("First is smaller than second");
                return;
            } else if (input1[i] > input2[i]) {
                Console.WriteLine("First is greater than second");
                return;
            }
        }

        if (len1 < len2) {
            Console.WriteLine("First is smaller than second");
        } else if (len1 > len2) {
            Console.WriteLine("First is greater than second");
        } else {
            Console.WriteLine("Equal");
        }
    
    }

    public static void Letters() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        int letterCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        foreach (char c in input) {
            if (char.IsLetter(c)) {
                letterCount++;
            } else if (char.IsDigit(c)) {
                digitCount++;
            } else if (!char.IsWhiteSpace(c)) {
                specialCharCount++;
            }
        }

        Console.WriteLine("Letter count: " + letterCount);
        Console.WriteLine("Number count: " + digitCount);
        Console.WriteLine("Special character count: " + specialCharCount);
    }

    public static void Copy() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        string? res = input;
        Console.WriteLine($"Result: {res}\n");
    }

    public static void Vowels() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        char[] toFind = ['a', 'e', 'i', 'o', 'u'];
        int res = 0;

        foreach (var ch in toFind) {
            int i = 0;
            while ((i = input.IndexOf(ch, i)) != -1) {
                res++;
                i++;
            }
        }

        Console.WriteLine($"Vowels: {res}");
        Console.WriteLine($"Consonants: {input.Length - res}\n");
        Console.WriteLine();
    }

    public static void Sort(List<int> nums) {
        BubbleSort(nums);
    }
}