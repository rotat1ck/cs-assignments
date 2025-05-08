abstract class Glyph {
    public abstract void Draw();

    public virtual void AnOperation() {
        Console.WriteLine("Glyph operation");
    }
}