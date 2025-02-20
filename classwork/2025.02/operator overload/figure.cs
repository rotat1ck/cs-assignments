abstract class Figure {
    public abstract void Draw();

}

abstract class Quadrangle : Figure {

}

class Rectangle : Quadrangle {
    public int width { get; set;}
    public int height { get; set; }

    public static implicit operator Rectangle(Square s) {
        return new Rectangle { width = s.lenght*2, height = s.lenght };
    }

    public override void Draw() {
        for (int i = 0; i < height; ++i, Console.WriteLine()) {
            for (int j = 0; j < width; ++j) {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }

    public override string ToString() {
        return $"Rectangle: {width}x{height}";
    }
}

class Square : Quadrangle {
    public int lenght { get; set; }
    public static explicit operator Square(Rectangle r) {
        return new Square { lenght = r.width };
    }

    public static explicit operator int(Square s) {
        return s.lenght;
    }

    public static implicit operator Square(int num) {
        return new Square { lenght = num };
    }

    public override void Draw() {
        for (int i = 0; i < lenght; ++i, Console.WriteLine()) {
            for (int j = 0; j < lenght; ++j) {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }

    public override string ToString() {
        return $"Square: {lenght}x{lenght}";
    }
}