namespace Figures {
    class Code {
        static void Main() {
            Triangle triangle = new Triangle(7);
            triangle.Draw();

            Console.WriteLine();

            Rectangle rectangle = new() { Width = 10, Height = 5 };
            rectangle.Draw();

            Console.WriteLine();

            Square square = new() { Width = 5, Height = 5 };
            square.Draw();
        }
    }
}