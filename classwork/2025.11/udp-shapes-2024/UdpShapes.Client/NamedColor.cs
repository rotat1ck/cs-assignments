using System.Windows.Media;

namespace UdpShapes.Client;

public record NamedColor {
    public static NamedColor Red { get; } = new (0, "Красный", Colors.Red);
    public static NamedColor Orange { get; } = new (1, "Оранжевый", Colors.Orange);
    public static NamedColor Yellow { get; } = new (2, "Жёлтый", Colors.Yellow);
    public static NamedColor Green { get; } = new (3, "Зелёный", Colors.Green);
    public static NamedColor SkyBlue { get; } = new (4, "Голубой", Color.FromRgb (122, 173, 255));
    public static NamedColor Indigo { get; } = new (5, "Синий", Color.FromRgb (0, 68, 255));
    public static NamedColor Violet { get; } = new (6, "Фиолетовый", Color.FromRgb (101, 0, 201));

    public static IReadOnlyList<NamedColor> All { get; } = [
        Red, Orange, Yellow, Green, SkyBlue, Indigo, Violet,
    ];
    public static IReadOnlyDictionary<int, NamedColor> IdToColor { get; }
        = All.ToSortedList (color => color.Id, color => color);


    public int Id { get; }
    public string Name { get; }
    public Color Color { get; }
    public Brush Brush { get; }

    public NamedColor (int id, string name, Color color) {
        this.Id = id;
        this.Name = name;
        this.Color = color;
        this.Brush = new SolidColorBrush (color);
    }

    public override string ToString () => Name;
}
