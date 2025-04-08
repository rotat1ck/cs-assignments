class Code {
    static void Main() {
        string text =   "Вот дом, Который построил Джек. А это пшеница, Которая в " +
                        "темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто " +
                        "ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
        
        string[] formatted = text.Split([',', '.', ' '], StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> result = [];

        foreach (string word in formatted) {
            if (result.ContainsKey(word)) {
                result[word]++;
            } else {
                result[word] = 1;
            }
        }

        Console.WriteLine("\t\tWord: \tCount:");
        for(int i = 0; i < result.Count; i++) {
            Console.WriteLine($"{i + 1}.\t{result.Keys.ElementAt(i), 8}\t{result.Values.ElementAt(i)}");
        }
        Console.WriteLine($"Total lenght: {formatted.Length} unique of which is {result.Count}");
    }
}