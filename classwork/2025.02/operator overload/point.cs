class Point {
    public int x { get; set; }
    public int y { get; set; }

    static public Point operator ++(Point s) {
        s.x++;
        s.y++;
        return s;
    }

    static public Point operator --(Point s) {
        s.x--;
        s.y--;
        return s;
    }

    static public Point operator -(Point s) {
        return new Point {x = -s.x, y = -s.y};
    }

    public override bool Equals(object? obj) {
        return this.ToString() == obj.ToString();
    }

    public override int GetHashCode(){
        return this.ToString().GetHashCode();
    }

    public override string ToString() {
        return $"Point x = {x}, y = {y}";
    }

    public static bool operator ==(Point p1, Point p2) {
        return p1.Equals(p2);
    }

    public static bool operator !=(Point p1, Point p2) {
        return !(p1 == p2);
    }

    public static bool operator >(Point p1, Point p2) {
        return Math.Sqrt(p1.x * p1.x + p1.y * p1.y) > Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
    }

    public static bool operator <(Point p1, Point p2) {
        return Math.Sqrt(p1.x * p1.x + p1.y * p1.y) < Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
    }

    public static bool operator true(Point p) {
        return p.x != 0 || p.y != 0 ? true : false;
    }

    public static bool operator false(Point p ) {
        return p.x == 0 && p.y == 0 ? true : false;
    }
}