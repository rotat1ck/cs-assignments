using System.Collections;

class Product {
    ArrayList parts = new();

    public void Add(string part) {
        parts.Add(part);
    }

    public void Show() {
        foreach (string part in parts) {
            Console.WriteLine(part);
        }
    }
}