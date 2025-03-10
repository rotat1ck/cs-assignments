class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 3): ");
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
        Console.Write("Enter data (name url desc ip): ");
        string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        WebSite site = new(data[0], data[1], data[2], data[3]);

        Console.Write("Enter return value: ");
        string? toGet = Console.ReadLine();
        WebSite.WebSiteDelegate? del = null;

        try {
            switch(toGet) {
                case "name": {
                    del = site.GetName;
                    break;
                } case "url": {
                    del = site.GetUrl;
                    break;
                } case "description": {
                    del = site.GetDescription;
                    break;
                } case "ip": {
                    del = site.GetIp;
                    break;
                } default: {
                    throw new ArgumentException();
                }
            }
            Console.WriteLine($"Result: {del()}");
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    
    static void Two() {
        Console.Write("Enter data (name creationdate desc phone email): ");
        string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Journal journal = new(data[0], DateTime.Parse(data[1]), data[2], data[3], data[4]);

        Console.Write("Enter return value: ");
        string? toGet = Console.ReadLine();
        Journal.JournalStringDelegate? strDel = null;
        Journal.JournalDateTimeDelegate? dateDel = null;

        try {
            switch(toGet) {
                case "name": {
                    strDel = journal.GetName;
                    break;
                } case "creationdate": {
                    dateDel = journal.GetCreatedDate;
                    break;
                } case "description": {
                    strDel = journal.GetDescription;
                    break;
                } case "phone": {
                    strDel = journal.GetPhone;
                    break;
                } case "email": {
                    strDel = journal.GetEmail;
                    break;
                } default: {
                    throw new ArgumentException();
                }
            }
            if (strDel != null) Console.WriteLine($"Result: {strDel()}");
            else if (dateDel != null) Console.WriteLine($"Result: {dateDel()}");
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Three() {
        Console.Write("Enter data (name address desc phone email): ");
        string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Shop shop = new(data[0], data[1], data[2], data[3], data[4]);

        Console.Write("Enter return value: ");
        string? toGet = Console.ReadLine();
        Shop.ShopDelegate? del = null;

        try {
            switch(toGet) {
                case "name": {
                    del = shop.GetName;
                    break;
                } case "address": {
                    del = shop.GetAddress;
                    break;
                } case "description": {
                    del = shop.GetDescription;
                    break;
                } case "phone": {
                    del = shop.GetPhone;
                    break;
                } case "email": {
                    del = shop.GetEmail;
                    break;
                } default: {
                    throw new ArgumentException();
                }
            }
            Console.WriteLine($"Result: {del()}");
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}