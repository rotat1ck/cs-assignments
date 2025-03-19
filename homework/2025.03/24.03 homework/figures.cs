namespace goidaNamespaceWhyDoYouEvenUseNamespacesTheyAreUseless {
    abstract class Figure {
        public virtual double a { get; set; }
        public virtual double b { get; set; }
        public virtual double h { get; set; }
        public abstract void Print();
    }

    class Triangle : Figure {
        public Triangle() { }
        public Triangle(double h) {
            this.h = h;
        }

        public override void Print() {
            for (int i = 0; i < h; i++, Console.WriteLine()) {
                for (int j = 0; j < h - i - 1; j++) {
                    Console.Write(" ");
                } for (int j = 0; j <= i; j++) {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }

    }

    class Square : Figure {
        public Square() { }
        public Square(double a) {
            this.a = a;
        }
        public override void Print() {
            for (int i = 0; i < a; i++, Console.WriteLine()) {
                for (int j = 0; j < a; j++) {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }

    class Rectangle : Figure {
        public Rectangle() { }
        public Rectangle(double a, double b) {
            this.a = a;
            this.b = b;
        }

        public override void Print() {
            for (int i = 0; i < a; i++, Console.WriteLine()) {
                for (int j = 0; j < b; j++) {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
}