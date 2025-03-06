class Point2D<T> where T : struct {
    public T X { get; set; }
    public T Y { get; set; }

    public Point2D(T x, T y) {
        X = x;
        Y = y;
    }
}