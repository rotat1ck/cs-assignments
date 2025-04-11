class MazeGame {
    MazeFactory factory = null;

    public Maze CreateMaze() {
        this.factory = factory;

        Maze aMaze = this.factory.MakeMaze();
        Room r1 = this.factory.MakeRoom(1);
        Room r2 = this.factory.MakeRoom(2);
        Door aDoor = this.factory.MakeDoor(r1, r2);

        aMaze.AddRoom(r1);
        aMaze.AddRoom(r2);
        
        r1.SetSide(Direction.North, this.factory.MakeWall());
        r1.SetSide(Direction.East, aDoor);
        r1.SetSide(Direction.South, this.factory.MakeWall());
        r1.SetSide(Direction.West, this.factory.MakeWall());

        r1.SetSide(Direction.North, this.factory.MakeWall());
        r1.SetSide(Direction.East, this.factory.MakeWall());
        r1.SetSide(Direction.South, this.factory.MakeWall());
        r1.SetSide(Direction.West, aDoor);

        return aMaze;

        // Maze aMaze = new();
        // Room r1 = new(1);
        // Room r2 = new(2);
        // Door d1 = new(r1, r2);

        // aMaze.AddRoom(r1);
        // aMaze.AddRoom(r2);

        // r1.SetSide(Direction.North, new Wall());
        // r1.SetSide(Direction.East, d1);
        // r1.SetSide(Direction.South, new Wall());
        // r1.SetSide(Direction.West, new Wall());

        // r1.SetSide(Direction.North, new Wall());
        // r1.SetSide(Direction.East, new Wall());
        // r1.SetSide(Direction.South, new Wall());
        // r1.SetSide(Direction.West, d1);

        // return aMaze;
    }
}