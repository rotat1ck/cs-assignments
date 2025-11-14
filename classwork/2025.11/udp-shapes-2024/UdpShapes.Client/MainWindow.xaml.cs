using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace UdpShapes.Client;

public partial class MainWindow : Window {
    // Коллекция нуждается в синхронизации
    private IDictionary<int, Player> players = new Dictionary<int, Player> ();
    private int myId;
    private Player Me { get { lock (players) return players[myId]; } }

    private CancellationTokenSource cancel = new CancellationTokenSource ();
    private UdpClient server;

    public MainWindow (Player me) {
        InitializeComponent ();

        this.myId = me.Id;
        players.Add (myId, me);

        server = new UdpClient ("127.0.0.1", 2024);
        _ = ListenToServer (cancel.Token);
    }
    private async Task ListenToServer (CancellationToken token) {
        try {
            // При входе уведомляем всех игроков, что я появился
            await SendMessage (new Message {
                Entered = Me.ToEnteredMessage ()
            });

            // В цикле разбираем входящие сообщения
            while (true) {
                UdpReceiveResult received = await server.ReceiveAsync (token);
                if (token.IsCancellationRequested) return;

                byte[] datagram = received.Buffer;  // достали датаграмму
                await ProcessMessage (datagram);  // разобрать, что надо сделать в ответ
                this.InvalidateVisual ();  // перерисовать, потому что игрок появился, передвинулся, пропал
            }
        }
        catch (SocketException) {
            MessageBox.Show ("Сервер покинул игру");
            Close ();
            this.Dispatcher.Invoke (() => Application.Current.Shutdown ());
        }
    }

    // Функция нестандартной отрисовки окна
    protected override void OnRender (DrawingContext d) {
        IReadOnlyList<Player> playersCopy;
        lock (players)
            playersCopy = players.Values.ToArray ();

        foreach (Player player in playersCopy)
            player.Draw (d);
    }

    private async void Window_Closed (object sender, EventArgs e) {
        // сказать всем игрокам, что я ушёл
        await SendMessage (new Message {
            Leave = new LeaveMessage {
                Id = Me.Id
            }
        });
        cancel.Cancel ();  // перестать слушать
        this.Dispatcher.Invoke (() => Application.Current.Shutdown ());
    }

    // Отправить сообщение с помощью сериализации JSON
    private async Task SendMessage (Message message) {
        string json = JsonSerializer.Serialize (message);
        byte[] bytes = Encoding.UTF8.GetBytes (json);
        await server.SendAsync (bytes);
    }

    // Десериализовать сообщение. Отреагировать на него
    private async Task ProcessMessage (byte[] datagram) {
        string json = Encoding.UTF8.GetString (datagram);
        Message message = JsonSerializer.Deserialize<Message> (json) ?? throw new NullReferenceException ();

        if (message.Entered is not null) {
            Player player = Player.FromEntered (message.Entered);  // десериализовать нового игрока
            lock (players)  // добавить в коллекцию
                players[player.Id] = player;

            await SendMessage (new Message {  // послать сообщение в ответ, что я существую
                Existing = Me.ToExistingMessage ()
            });
        }
        else if (message.Existing is not null) {
            Player player = Player.FromExisting (message.Existing);  // десериализовать существующего игрока
            lock (players)  // добавить в коллекцию
                players[player.Id] = player;
        }
        else if (message.Move is not null && message.Move.Id != myId) {  // двигать других, но не себя
            lock (players) {
                Player player = players[message.Move.Id];  // достать текущее состояние игрока
                player = player.Move (message.Move.Pos);  // создать новое, передвинутое состояние
                players[player.Id] = player;  // перезаписать
            }
        }
        else if (message.Leave is not null) {
            lock (players)
                players.Remove (message.Leave.Id);
        }
    }

    // Таскание себя
    // Хранит последнюю известную позицию мышки. Если не таскаем, то null.
    private Point? lastDragging = null;
    private void Window_MouseDown (object sender, MouseButtonEventArgs e) {
        Point mouse = e.GetPosition (this);  // позиция мышки относительно клиентской области окна

        Player me = Me;
        if (mouse.X >= me.Pos.X && mouse.X < me.Pos.X + 50  // если попал по фигуре
            && mouse.Y >= me.Pos.Y && mouse.Y < me.Pos.Y + 50)
            lastDragging = mouse;
    }

    private async void Window_MouseMove (object sender, MouseEventArgs e) {
        if (lastDragging is null) return;

        Point newMouse = e.GetPosition (this);  // новая позиция мышки
        double addX = newMouse.X - lastDragging.Value.X;  // насколько мышка сдвинулась с прошлого раза?
        double addY = newMouse.Y - lastDragging.Value.Y;
        
        Player me = Me;
        Point newPos = new Point (me.Pos.X + addX, me.Pos.Y + addY);  // сдвинуть игрока на столько же
        me = me.Move (newPos);
        lock (players)
            players[me.Id] = me;  // заместить меня в коллекции

        lastDragging = newMouse;

        await SendMessage (  // сказать всем игрокам, что я передвинулся
            new Message {
                Move = new MoveMessage { Id = myId, Pos = newPos }
            }
        );
    }

    private void Window_MouseUp (object sender, MouseButtonEventArgs e) =>
        lastDragging = null;
}
