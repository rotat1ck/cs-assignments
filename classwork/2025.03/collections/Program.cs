using System.Collections;

class Code {
    static void Main() {

        // `````
        // HashTable
        // `````

        // Hashtable hash = new();
        //     // Keys
        //     // Values
        //     // ConstainsKey()
        //     // CointainsValue()
        // hash.Add(1, "John");
        // hash.Add("two", new Student() {Name = "Vova"});

        // Console.WriteLine($"Key, pair");

        // foreach (var item in hash.Keys) {
        //     Console.WriteLine($"Key: {item}, Value: {hash[item]}");
        // }

        // hash.Add("Pi", 3.14159);
        // Console.WriteLine("After update");

        // foreach (var item in hash.Values) {
        //     Console.WriteLine($"Value: {item}");
        // }

        // Console.WriteLine("After remove");
        // hash.Remove("two");        sortedList.Remove(3);


        // Console.WriteLine(hash.ContainsKey("two"));

        // `````
        // Sorted List
        // `````

        SortedList sortedList = new();
        sortedList.Add(3, 5.6);
        sortedList.Add(2, new Student() {Name = "Ivan"});
        sortedList.Add(1, "one");

        foreach (var item in sortedList.Keys) {
            Console.WriteLine($"Key: {item}, Value: {sortedList[item]}");
        }
        Console.WriteLine();

        sortedList.Remove(3);

        for (int i = 0; i < sortedList.Count; ++i) {
            Console.WriteLine($"Key: {sortedList.GetKey(i)}, Value: {sortedList.GetByIndex(i)}");
        }

        
    }
}