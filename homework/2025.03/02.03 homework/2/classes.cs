namespace Figures {
    class Triangle {
        public int Height { get; set; }
        
        public Triangle(int height) {
            Height = height;
        }

        public void Draw() {
            for (int i = 0; i < Height; i++) {
                for (int j = 0; j < Height - i - 1; j++) {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class Rectangle {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw() {
            for (int i = 0; i < Height; i++) {
                for (int j = 0; j < Width; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class Square {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw() {
            for (int i = 0; i < Height; i++) {
                for (int j = 0; j < Width; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}