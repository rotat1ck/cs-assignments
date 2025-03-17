class Matrix {
    public int Rows { get; set; }
    public int Columns { get; set; }
    private double[,]? Data { get; set; }

    public Matrix() {}

    public Matrix(int rows, int columns) {
        Rows = rows;
        Columns = columns;
        Data = new double[rows, columns];
    }

    public Matrix(double[,] data) {
        Rows = data.GetLength(0);
        Columns = data.GetLength(1);
        Data = data;
    }

    public override string ToString() {
        string result = "";
        for (int i = 0; i < Rows; i++) {
            for (int j = 0; j < Columns; j++) {
                result += Data[i, j] + " ";
            }
            result += "\n";
        }
        return result;
    }

    public double Min() {
        double min = Data[0, 0];
        for (int i = 0; i < Rows; i++) {
            for (int j = 0; j < Columns; j++) {
                if (Data[i, j] < min) {
                    min = Data[i, j];
                }
            }
        }
        return min;
    }

    public double Max() {
        double max = Data[0, 0];
        for (int i = 0; i < Rows; i++) {
            for (int j = 0; j < Columns; j++) {
                if (Data[i, j] > max) {
                    max = Data[i, j];
                }
            }
        }
        return max;
    }

    public override bool Equals(object? obj) {
        return ToString() == obj.ToString();
    }

    static public bool operator ==(Matrix matrix1, Matrix matrix2) {
        return matrix1.Equals(matrix2);
    }

    static public bool operator !=(Matrix matrix1, Matrix matrix2) {
        return !(matrix1 == matrix2);
    }
}