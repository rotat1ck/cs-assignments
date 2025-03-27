﻿using System.Data;
using System.Linq;
using System.Windows.Markup;

class Code {
    static ConsoleColor[] Colors = [
        ConsoleColor.DarkBlue,
        ConsoleColor.DarkGreen,
        ConsoleColor.DarkCyan,
        ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow,
        ConsoleColor.Blue,
        ConsoleColor.Red,
        ConsoleColor.Magenta
    ];
    static void Main() {
        try {
            Console.CursorVisible = false;
            while (true) {
                NewBoard:
                    Console.Clear();
                    int?[,] board = new int?[4, 4];
                    int score = 0;
                    while (true) {
                        bool IsNull((int X, int Y) point) => board[point.X, point.Y] == null;
                        int nullCount = BoardValues(board).Count(IsNull);
                        if (nullCount is 0) {
                            goto GameOver;
                        }
                        int index = Random.Shared.Next(0, nullCount);
                        var (x, y) = BoardValues(board).Where(IsNull).ElementAt(index);
                        board[x, y] = Random.Shared.Next(10) < 9 ? 2 : 4;
                        score += 2;

                        if (!TryUpdate((int?[,])board.Clone(), ref score, Direction.Up) && 
                            !TryUpdate((int?[,])board.Clone(), ref score, Direction.Down) &&
                            !TryUpdate((int?[,])board.Clone(), ref score, Direction.Left) &&
                            !TryUpdate((int?[,])board.Clone(), ref score, Direction.Right) ) 
                        {
                            goto GameOver;
                        }
                        Render(board, score);
                        Direction direction;
                    
                    GetDirection:
                        switch (Console.ReadKey(true).Key) {
                            case ConsoleKey.UpArrow:
                                direction = Direction.Up;
                                break;
                            case ConsoleKey.DownArrow:
                                direction = Direction.Down;
                                break;
                            case ConsoleKey.LeftArrow:
                                direction = Direction.Left;
                                break;
                            case ConsoleKey.RightArrow:
                                direction = Direction.Right;
                                break;
                            case ConsoleKey.End:
                                goto NewBoard;
                            case ConsoleKey.Escape:
                                goto Close;
                            default:
                                goto GetDirection;

                        }
                        if (!TryUpdate(board, ref score, direction)) {
                            goto GetDirection;
                        }
                    }
                    
                    GameOver:
                        Render(board, score);
                        Console.WriteLine("Game Over!");
                        Console.WriteLine($"\nPlay Again [enter], or quit [escape]?");
                    GetInput:
                        switch (Console.ReadKey().Key) {
                            case ConsoleKey.Enter: goto NewBoard;
                            case ConsoleKey.Escape: goto Close;
                            default: goto GetInput;
                        }
            }
            Close:
                Console.Clear();
                Console.WriteLine("2048 was closed");
        } finally { }
    }

    static bool TryUpdate(int?[,] board, ref int score, Direction direction) {
        (int X, int Y) Adjacent(int x, int y) => 
            direction switch {
                Direction.Up => (x + 1, y),
                Direction.Down => (x - 1, y),
                Direction.Left => (x, y - 1),
                Direction.Right => (x, y + 1),
                _ => throw new NotImplementedException()
            };
        (int X, int Y) Map(int x, int y) =>
        direction switch {
            Direction.Up => (board.GetLength(0) - x-1, y),
            Direction.Down => (x, y),
            Direction.Left => (x, y),
            Direction.Right => (x, board.GetLength(1) - y - 1),
            _ => throw new NotImplementedException()
        };
        bool[,] locked = new bool[board.GetLength(0), board.GetLength(1)];

        bool update = false;
        for (int i = 0; i < board.GetLength(0); i++) {
            for (int j = 0; j < board.GetLength(1); j++) {
                var (tempi, tempj) = Map(i, j);
                if (board[tempi, tempj] is null) {
                    continue;
                }
                KeepChanging:
                    var (adji, adjj) = Adjacent(tempi, tempj);
                    if (adji < 0 || adji >=board.GetLength(0) ||
                        adjj < 0 || adjj >= board.GetLength(1) || 
                        locked[adji, adjj]) {
                            continue;
                    } else if (board[adji, adjj] is null) {
                        board[adji, adjj] = board[tempi, tempj];
                        board[tempi, tempi] = null;
                        update = true;
                        tempi = adji;
                        tempj = adjj;
                        goto KeepChanging;
                    } else if (board[adji, adjj] == board[tempi, tempj]) {
                        board[adji, adjj] += board[tempi, tempj];
                        score += board[tempi, tempj]!.Value;
                        board[tempi, tempj] = null;
                        update = true;
                        locked[adji, adjj] = true;
                    }
            }
        }
        return update;
    }

    static IEnumerable<(int, int)> BoardValues(int?[,] board) {
        for (int i = board.GetLength(0) - 1; i >= 0; --i) {
            for (int j = 0; j < board.GetLength(1); ++j) {
                yield return (i, j);
            }
        }
    }

    static ConsoleColor GetColor(int? value) =>
        value is null ? ConsoleColor.DarkGray : Colors[(value.Value / 2 - 1) % Colors.Length];

    static void Render(int?[,] board, int score) {
        int horizontal = board.GetLength(0) + 8;
        string horizontalBar = new('=', horizontal);
        string horizontalSpace = new(' ', horizontal);

        Console.SetCursorPosition(0, 0);
        Console.WriteLine("2048");
        Console.WriteLine($"\n{horizontalBar}\n{horizontalSpace}");

        for (int i = board.GetLength(1) - 1; i >= 0; i--) {
            Console.Write("|");
            for (int j = 0; j < board.GetLength(0); j++) {
                Console.Write("  ");
                ConsoleColor background = Console.BackgroundColor;
                Console.BackgroundColor = GetColor(board[i, j]);
                Console.Write(string.Format("{0,4}", board[i, j]));
                Console.BackgroundColor = background;
                Console.Write("  ");
            }
            Console.WriteLine("|");
            Console.WriteLine($"|{horizontalSpace}|");
        }
        Console.WriteLine($"{horizontalBar}");
        Console.WriteLine($"Score: {score}");
    }

    public enum Direction {
        Up = 1,
        Down = 2,
        Left = 3,
        Right = 4
    }
} 