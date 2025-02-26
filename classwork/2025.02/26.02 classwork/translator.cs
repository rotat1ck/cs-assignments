static class Translator {
    private static Dictionary<string, string> dict = new() {
        ["apple"] = "яблоко",
        ["dog"] = "собака",
    };
    public static string Translate(string text) {
        if (dict.TryGetValue(text, out string res)) {
            return res;
        } else {
            throw new Excep($"Word {text} not found");
        }
    }
}