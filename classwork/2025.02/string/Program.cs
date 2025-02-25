class Code {
    static void Main() {
        // string s1 = "Test";
        // string s2 = new String(['a', 'b', 'c', 'd', 'e']);
        // string s3 = new String(['a', 'b', 'c', 'd', 'e'], 1, 3);

        // Console.WriteLine(s1);
        // Console.WriteLine(s2);
        // Console.WriteLine(s3);
        // Console.WriteLine();

        // foreach(var c in s1) Console.WriteLine(c);

        // Console.WriteLine(s1 == s3);

        // COMPARE

        // string s1 = "Help";
        // string s2 = "word";

        // string s3 = s1 + s2;
        // string s4 = string.Concat(s3, '&');

        // Console.WriteLine(s4);

        // var val = new string[] {s1, s2, s3, s4};

        // string s5 = string.Join(" ", val);

        // Console.WriteLine(s5);

        // int res = string.Compare(s1, s2);
        // if (res < 0) {
        //     Console.WriteLine("String s1 is first in order");
        // } else if (res > 0) {
        //     Console.WriteLine("String s2 is first in order");
        // } else {
        //     Console.WriteLine("s1 == s2");
        // }

        // string s3 = "Test word text";
        // char ch = 'o';

        // int indexOfChar = s3.IndexOf(ch);
        // Console.WriteLine(indexOfChar);

        // string sub = "tex";
        // int index1 = s3.IndexOf(sub);
        // Console.WriteLine(index1);

        // // startwith
        // // endwith

        // var files = new string[] {
        //     "my.png",
        //     "1.jpg",
        //     "word.exe",
        //     "note.exe",
        //     "test.png",
        //     "3.png"
        // };

        // for (int i = 0; i < files.Length; ++i) {
        //     if (files[i].EndsWith(".png")) {
        //         Console.WriteLine(files[i]);
        //     }
        // }

        // SPLIT

        // string text = "Test text    tee tog";
        // string[] words = text.Split([' '], StringSplitOptions.RemoveEmptyEntries);

        // foreach (string word in words) {
        //     Console.WriteLine(word);
        // }

        // Trim 
        // TrimStart
        // TrimEnd

        string text = "   Test text tee tog    ";
        text = text.Trim();
        Console.WriteLine(text);

        text = text.TrimStart(['t']);
        Console.WriteLine(text);

        text = text[4..9];
        Console.WriteLine(text);

        // INSERT

        string sub = "World settings";
        text = text.Insert(0, sub);
        Console.WriteLine(text);

        // REMOVE

        int ind = text.Length - 1;
        text = text.Remove(ind);

        Console.WriteLine(text);

        text = text.Remove(0, 2);
        Console.WriteLine(text);

        // REPLACE

        string text1 = "Good day";
        text1 = text1.Replace("day", "night");
        Console.WriteLine(text1);

        Console.WriteLine(text1.ToUpper());
        Console.WriteLine(text1.ToLower());

        string lastName = "Ivanov";
        int salary = 20000;

        Console.WriteLine("Lastname: {0}, Salary: {1}", lastName, salary);
        // string output = string.Format("Lastname: {0}, Salary: {1}", lastName, salary);

        string res = string.Format("{0:C0}", salary);
        Console.WriteLine(res);
    }   
}