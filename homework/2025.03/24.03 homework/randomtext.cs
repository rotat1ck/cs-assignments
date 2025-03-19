namespace goidaNamespaceWhyDoYouEvenUseNamespacesTheyAreUseless {
    class TextGenerator {
        public int CountVowels { get; set; }
        public int CountJunc { get; set; }
        public int LengthText { get; set; }
        Random rnd = new Random();

        public TextGenerator() { }

        public TextGenerator(int CountVowels, int CountJunc, int LengthText) {
            this.CountVowels = CountVowels;
            this.CountJunc = CountJunc;
            this.LengthText = LengthText;
        }
        public string Random() {
            string vowels = "AEIOUaeiou";
            string consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            string res = "";
            Random random = new();

            for (int i = 0; i < CountVowels; i++) { 
                res += vowels[random.Next(vowels.Length)]; 
            }

            for (int i = CountVowels; i < CountVowels + CountJunc; i++) { 
                res += consonants[random.Next(consonants.Length)]; 
            }

            for (int i = CountVowels + CountJunc; i < LengthText; i++) { 
                res += (vowels + consonants)[random.Next(vowels.Length + consonants.Length)]; 
            }

            res = new string(res.OrderBy(x => random.Next()).ToArray());
            return res;
        }
    }
}