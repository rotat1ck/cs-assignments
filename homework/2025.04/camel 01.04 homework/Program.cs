class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 5): ");
            Console.Clear();
            switch (press) {
                case ConsoleKey.D1: {
                    One();
                    break;
                } case ConsoleKey.D2: {
                    Two();
                    break;
                } case ConsoleKey.D3: {
                    Three();
                    break;
                } case ConsoleKey.D4: {
                    Four();
                    break;
                } case ConsoleKey.D5: {
                    Five();
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
        Pair<int, string> pair = new();
        pair.First = 0;
        pair.Second = "Zero";
        Console.WriteLine(pair);
    }

    static void Two() {
        static T FindMax<T>(IEnumerable<T> items) where T : IComparable<T> {
            T max = items.First();
            foreach (T item in items) {
                if (item.CompareTo(max) > 0) {
                    max = item;
                }
            }
            return max;
        }

        List<int> list = [1, 5, 8, 34, 109, 15, 2];
        Console.WriteLine(FindMax(list));
    }

    static void Three() {
        GenericStack<int> stack = new([5, 4, 3, 2, 1]);

        for (int i = 0; i < 5; i++) {
            Console.WriteLine(stack.Peek());
            stack.Pop();
        }
        stack.Push(10);
        Console.WriteLine(stack.Peek());
    }

    static void Four() {
        Container<int> container = new([1, 2, 3, 4, 5]);
        for (int i = 0; i < container.Count; i++) {
            if (container[i] % 2 == 0) {
                container.Pop(i);
            }
        }

        List<int> result = container.GetAll();
        for (int i = 0; i < result.Count; i++) {
            Console.WriteLine(result[i]);
        }
    }

    static void Five() {
        static HashSet<T> MergeCollections<T>(IEnumerable<T> first, IEnumerable<T> second) {
            HashSet<T> result = new();
            result.UnionWith(first);
            result.UnionWith(second);
            return result;
        }

        List<int> first = [1, 3, 5, 7, 9];
        List<int> second = [5, 7, 9, 11, 13];
        foreach(var item in MergeCollections(first, second)) {
            Console.WriteLine(item);
        }
    }
}