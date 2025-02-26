class Room {
    public int number { get; set; }
    public RoomType type { get; set; }
    public int price { get; set; }
    List<DateTime> bookedDates = [];

    public Room(int number, RoomType type, int price) {
        this.number = number;
        this.type = type;
        this.price = price;
    }

    public bool isAvailable(DateTime date) => !bookedDates.Contains(date);

    public void book(DateTime date) {
        if (isAvailable(date)) {
            bookedDates.Add(date);
        } else {
            throw new Excep($"Room {number} is already booked on {date.ToShortDateString()}");
        }
    }

    public void unbook(DateTime date) {
        if (bookedDates.Contains(date)) {
            bookedDates.Remove(date);
        } else {
            throw new Excep($"Room {number} is not booked on {date.ToShortDateString()}");
        }
    }
}

enum RoomType {
    Стандарт,
    Люкс,
    Президентский
}