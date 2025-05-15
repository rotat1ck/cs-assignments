class Context {
    public string? Source { get; set; }
    public Dictionary<char, string>? Vocabulary { get; set; }
    public bool Result { get; set; }
    public int Position { get; set; }
    public int Translated { get; set; }
}