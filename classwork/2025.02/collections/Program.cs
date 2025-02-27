using System.Collections;
using System.Collections.Generic;

class Code {
    static void Main() {
        
        // ARRAYLIST

        // ArrayList arrayList = [1, 5, 22, "zov"];

        // Console.WriteLine($"Capacity: {arrayList.Capacity}");
        // arrayList.Add("one");
        // Console.WriteLine($"Capacity: {arrayList.Capacity}");
        // arrayList.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        // Console.WriteLine($"Capacity: {arrayList.Capacity}");

        // Console.WriteLine($"Count: {arrayList.Count}");
        // arrayList.TrimToSize();
        // Console.WriteLine($"Capacity: {arrayList.Capacity}");


        // arrayList.Insert(2, "Help");
        // Console.Write("Content: ");
        // foreach (var i in arrayList) {
        //     Console.Write($"{i} ");
        // }
        // Console.WriteLine();

        // arrayList.Remove(5);
        // arrayList.RemoveAt(5);
        // Console.Write("Content: ");
        // foreach (var i in arrayList) {
        //     Console.Write($"{i} ");
        // }
        // Console.WriteLine();

        // Console.WriteLine(arrayList.IndexOf("Help"));

        // ArrayList day = ["Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"];

        // foreach (var i in day) { 
        //     Console.Write(i + "\t");
        // }
        // Console.WriteLine();

        // day.Sort();
        // foreach (var i in day) { 
        //     Console.Write(i + "\t");
        // }
        // Console.WriteLine();

        // STACK

        Stack st1 = new();
        Console.WriteLine("Method Push()");
        st1.Push("one");
        st1.Push("two");
        st1.Push("three");

        foreach (var i in st1) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Method Pop()");
        st1.Pop();
        foreach (var i in st1) {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine(st1.Peek());
        Console.WriteLine(st1.Contains("row"));
        Console.WriteLine(st1.Contains("one"));

        Console.WriteLine("CopyTo()");
        string[] strArr = new string[st1.Count];

        st1.CopyTo(strArr, 0);
        foreach (var i in strArr) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine(st1.Count);

        st1.Clear();
        Console.WriteLine(st1.Count);

    }
}