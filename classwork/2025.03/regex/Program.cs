using System.Text.RegularExpressions;
class Code {
    static void Main() {
        string s = "Но элементы политического процесса представляют собой";
        Regex regex = new(@"\w*но\w*", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        MatchCollection matchCollection = regex.Matches(s);

        if (matchCollection.Count > 0) {
            foreach (var match in matchCollection) {
                // Console.WriteLine(match);
            }
        } else {
            Console.WriteLine("Not found");
        }

        string s2 = "456-435-1122";
        Regex regex2 = new(@"\d{3}-\d{3}-\d{4}");
        Regex regex3 = new(@"[0-9]{3}-[0-9]{3}-[0-9]{4}");
        Match match1 = regex2.Match(s2);

        // RegexOptions
            // Compiled
            // IgnoreCase
            // CuiltureInvariant
            // IgnorePatternWhitespace
            // Multiline ^ - startline, $ - endline
            // RightToLeft
            // Singleline

            // + - multiple chars
            // \s - space
            // \S - not space
            // \w - word
            // \W - not word
            // \d - digit
            // \D - not digit

        string text = "Тест    тест     раму.";
        string pattern = @"\s+";
        string target = " ";

        Regex rg = new(pattern);
        string res = rg.Replace(text, target);
        Console.WriteLine(res);

        string phone = "+1(876)-234-12-98";
        string pattern2 = @"\D";
        string target2 = "";
        Regex rg2 = new(pattern2);
        string res2 = rg2.Replace(phone, target2);
        Console.WriteLine(res2);
    }


    static void Test() {
        int[][] intervals = [[1,3], [2, 7], [8, 9]];
        SortedSet<int> res = [];
        bool intersect = false;

        for (int i = 0; i < intervals.Length; i++) {
            int[] interval = intervals[i];
            int count = 0;
            if (i + 1 < intervals.Length) {
                if (intervals[i + 1][0] <= interval[1]) {
                    intersect = true;
                }
            }
            if (intersect) {
                for (int j = interval[1]; j >= interval[0]; j--) {
                    if (count < 2) {
                        res.Add(j);
                        count++;
                    }
                }
            } else {
                for (int j = interval[0]; j <= interval[1]; j++) {
                    if (count < 2) {
                        res.Add(j);
                        count++;
                    }
                }
            }
            intersect = false;
        }

        Console.WriteLine($"Result: {res.Count()}");
    }
}