static class Archive {
    static public void JournalFunc() {
        Console.Write("Enter data (name creationdate desc phone email employees): ");
        string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Journal journal = new(data[0], DateTime.Parse(data[1]), data[2], data[3], data[4], int.Parse(data[5]));

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
                } case "employees": {
                    strDel = journal.GetEmployees;
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

    static public void ShopFunc() {
        Console.Write("Enter data (name address desc phone email area): ");
        string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Shop shop = new(data[0], data[1], data[2], data[3], data[4], double.Parse(data[5]));

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
                } case "area": {
                    del = shop.GetArea;
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