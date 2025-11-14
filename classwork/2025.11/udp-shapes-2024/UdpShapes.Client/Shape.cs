global using System.Windows.Media;

namespace UdpShapes.Client;

public class Shape {
    public static Shape Square { get; } = new Shape (0, "Квадрат", DrawSquare);
    public static Shape Circle { get; } = new Shape (1, "Круг", DrawCircle);
    public static Shape Triangle { get; } = new Shape (2, "Треугольник", DrawTriangle);
    public static Shape Diamond { get; } = new Shape (3, "Ромб", DrawDiamond);

    public static IReadOnlyList<Shape> All { get; } = [
        Square, Circle, Triangle, Diamond
    ];
    public static IReadOnlyDictionary<int, Shape> IdToShape { get; }
        = All.ToSortedList (shape => shape.Id, shape => shape);


    public int Id { get; }
    public string Name { get; }
    public Action<DrawingContext, Brush, Point> Draw { get; }

    public Shape (int id, string name, Action<DrawingContext, Brush, Point> draw) {
        this.Id = id;
        this.Name = name;
        this.Draw = draw;
    }

    public override string ToString () => Name;

    private static void DrawSquare (DrawingContext d, Brush brush, Point pos) =>
        d.DrawRectangle (brush, null, new Rect (pos.X, pos.Y, 50, 50));
    private static void DrawCircle (DrawingContext d, Brush brush, Point pos) =>
        d.DrawEllipse (brush, null, new Point (pos.X + 25, pos.Y + 25), 25, 25);
    private static void DrawTriangle (DrawingContext d, Brush brush, Point pos) =>
        d.DrawGeometry (brush, null, new PathGeometry ([
            new PathFigure (new Point (pos.X + 25, pos.Y + 0), [
                new LineSegment (new Point (pos.X + 50, pos.Y + 50), isStroked: false),
                new LineSegment (new Point (pos.X, pos.Y + 50), isStroked: false),
            ], closed: true)
        ]));
    private static void DrawDiamond (DrawingContext d, Brush brush, Point pos) =>
        d.DrawGeometry (brush, null, new PathGeometry ([
            new PathFigure (new Point (pos.X + 25, pos.Y + 0), [
                new LineSegment (new Point (pos.X + 50, pos.Y + 25), isStroked: false),
                new LineSegment (new Point (pos.X + 25, pos.Y + 50), isStroked: false),
                new LineSegment (new Point (pos.X + 0, pos.Y + 25), isStroked: false),
            ], closed: true)
        ]));
}
