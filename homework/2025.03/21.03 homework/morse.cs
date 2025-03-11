using System.Collections;

namespace Morse {
    class Morse {
        private static Hashtable morseMap = new() {
            {"a", ".-"},
            {"b", "-..."},
            {"c", "-.-."},
            {"d", "-.."},
            {"e", "."},
            {"f", "..-."},
            {"g", "--."},
            {"h", "...."},
            {"i", ".."},
            {"j", ".---"},
            {"k", "-.-"},
            {"l", ".-.."},
            {"m", "--"},
            {"n", "-."},
            {"o", "---"},
            {"p", ".--."},
            {"q", "--.-"},
            {"r", ".-."},
            {"s", "..."},
            {"t", "-"},
            {"u", "..-"},
            {"v", "...-"},
            {"w", ".--"},
            {"x", "-..-"},
            {"y", "-.--"},
            {"z", "--.."},
            {"0", "-----"},
            {"1", ".----"},
            {"2", "..---"},
            {"3", "...--"},
            {"4", "....-"},
            {"5", "....."},
            {"6", "-...."},
            {"7", "--..."},
            {"8", "---.."},
            {"9", "----."}
        };

        public static string toMorse(string input) {
            string res = "";
            for (int i = 0; i < input.Length; ++i) {
                if (morseMap.ContainsKey(input[i].ToString())) {
                    res += morseMap[input[i].ToString()] + " ";
                }
            }
            return res;
        }

        public static string fromMorse(string input) {
            string[] words = input.Split(' ');
            string res = "";
            foreach (string word in words) {
                foreach (DictionaryEntry entry in morseMap) {
                    if (entry.Value.ToString() == word) {
                        res += entry.Key;
                        break;
                    }
                }
                res += " ";
            }
            return res;
        }
    }
}