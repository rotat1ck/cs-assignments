class Character : Glyph {
    public override void Draw() {
        Console.WriteLine($"This is {this.GetType().FullName} class, child of Glyph class");
    }
}