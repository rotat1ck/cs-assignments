class Code {
    static void Main() {
        GlyphFactory factory = new();

        var character = factory.CreateCharacter();
        character.Draw();

        var row = factory.CreateRow();
        row.AnOperation();
    }
}