static class Hotel {
    static List<Room> rooms = [];

    static public void AddRoom(Room room) => rooms.Add(room);

    static public string BookRoom(int number, DateTime date) {
        foreach (Room room in rooms) {
            if (room.number == number) {
                room.book(date);
                return $"Room {number} is booked on {date.ToShortDateString()}";
            }
        }
        throw new Excep("Room not found");
    }

    static public string UnbookRoom(int number, DateTime date) {
        foreach (Room room in rooms) {
            if (room.number == number) {
                room.unbook(date);
                return $"Room {number} is unbooked on {date.ToShortDateString()}";
            } 
        }
        throw new Excep("Room not found");
    }

    static public List<Room> GetAvailableRooms(DateTime date) => rooms.Where(room => room.isAvailable(date)).ToList();

}