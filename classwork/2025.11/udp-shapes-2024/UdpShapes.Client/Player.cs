global using System.Windows.Media;
global using System.Windows;
using System.Numerics;

namespace UdpShapes.Client;

public record Player {
    public int Id { get; }

    public string Name { get; }
    public NamedColor NamedColor { get; }
    public Shape Shape { get; }

    public Point Pos { get; init; }

    // универсальный конструктор
    public Player (int id, string name, NamedColor namedColor, Shape shape, Point pos) {
        this.Id = id;
        this.Name = name;
        this.NamedColor = namedColor;
        this.Shape = shape;
        this.Pos = pos;
    }

    // создать нового игрока из формы входа
    public Player (string name, NamedColor namedColor, Shape shape) : this (
        Random.Shared.Next (),
        name, namedColor, shape,
        new Point (Random.Shared.Next (400), Random.Shared.Next (400))
    ) { }

    // преобразование типа: EnteredMessage -> Player
    public static Player FromEntered (EnteredMessage message) => new Player (
        message.Id, message.Name,
        NamedColor.IdToColor[message.ColorId],
        Shape.IdToShape[message.ShapeId],
        message.Pos);

    // преобразование типа: ExistingMessage -> Player
    public static Player FromExisting (ExistingMessage message) => new Player (
        message.Id, message.Name,
        NamedColor.IdToColor[message.ColorId],
        Shape.IdToShape[message.ShapeId],
        message.Pos);

    // возвращает копию игрока, но с изменённой позицией
    public Player Move (Point newPos) =>
        this with { Pos = newPos };

    // преобразование типа: Player -> EnteredMessage
    public EnteredMessage ToEnteredMessage () => new EnteredMessage {
        Id = Id,
        Name = Name,
        ColorId = NamedColor.Id,
        ShapeId = Shape.Id,
        Pos = Pos
    };

    // преобразование типа: Player -> ExistingMessage
    public ExistingMessage ToExistingMessage () => new ExistingMessage {
        Id = Id,
        Name = Name,
        ColorId = NamedColor.Id,
        ShapeId = Shape.Id,
        Pos = Pos
    };

    // Нарисовать игрока
    public void Draw (DrawingContext d) =>
        Shape.Draw (d, NamedColor.Brush, Pos);
}
