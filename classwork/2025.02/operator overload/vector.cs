class Vector {
    public int x { get; set;}
    public int y { get; set; }

    public Vector() {}

    public Vector(Point begin, Point end) {
        x = end.x - begin.x;
        y = end.y - begin.y;
    }

    public static Vector operator +(Vector a, Vector b) {
        return new Vector {
            x = a.x + b.x,
            y = a.y + b.y
        };
    }

    public static Vector operator -(Vector a, Vector b) {
        return new Vector {
            x = a.x - b.x,
            y = a.y - b.y
        };
    }

    public static Vector operator *(Vector a, int n) {
        a.x *= n;
        a.y *= n;
        return a;
    }

    public static Vector operator *(int n, Vector a) {
        return a * n;
    }

    public override string ToString(){
        return $"Vector: x = {x}, y = {y}";
    }
}