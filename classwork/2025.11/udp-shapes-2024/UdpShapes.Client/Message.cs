namespace UdpShapes.Client;

// Объект сообщения от клиента всем остальным клиентам.
// Сериализуется в JSON.
// Только одно из этих полей заполнено одновременно.
public class Message {
    public EnteredMessage? Entered { get; set; }
    public ExistingMessage? Existing { get; set; }
    public MoveMessage? Move { get; set; }
    public LeaveMessage? Leave { get; set; }
}

// Когда новый клиент подключается, он рассылает всем сообщение Entered.
// Все клиенты запоминают новичка.
// Все клиенты в ответ присылают всем Existing, чтобы новичок узнал, какие игроки тут есть.
public class EnteredMessage {
    public int Id { get; set; }
    public string Name { get; set; }
    public int ColorId { get; set; }
    public int ShapeId { get; set; }
    public Point Pos { get; set; }
}

// Когда новичок присылает Entered, существующий клиент рассылает всем Existing.
public class ExistingMessage {
    public int Id { get; set; }
    public string Name { get; set; }
    public int ColorId { get; set; }
    public int ShapeId { get; set; }
    public Point Pos { get; set; }
}

// Когда игрока таскают мышкой, он уведомляет всех клиентов об этом.
public class MoveMessage {
    public int Id { get; set; }
    public Point Pos { get; set; }
}

// Перед уходом игрок рассылает всем сообщение Leave
public class LeaveMessage {
    public int Id { get; set; }
}
