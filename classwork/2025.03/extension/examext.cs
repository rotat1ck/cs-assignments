using System.Text.RegularExpressions;
static class ExamExt {
    public static int NumberWords(this string data) {
        if (string.IsNullOrEmpty(data)) {
            return 0;
        }
        data = Regex.Replace(data.Trim(), @"\s+", " ");
        return data.Split(" ").Length;
    }
}