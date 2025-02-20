class MultiArray {
    int[,] array;
    public int Row { get; set; }
    public int Column { get; set; }

    public MultiArray(int row, int column) {
        Row = row;
        Column = column;
        array = new int[row, column];
    }

    public int this[int r, int c] {
        get { return array[r, c]; }
        set { array[r, c] = value; }
    }
}