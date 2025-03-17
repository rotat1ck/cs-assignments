class Code {
    static void Main() {
        City city = new() {Name = "123", Country = "123", Population = 123, PhoneCode = "123", Districts = ["123", "456"]};
        Console.WriteLine(city);

        Employee employee = new() {Name = "123", BirthDate = new DateTime(2000, 7, 29), Phone = "123", Email = "123", Role = "123", Description = "123"};
        Console.WriteLine(employee);

        Plane plane = new() {Name = "Boeing 757", Manifacturer = "Boeing", Date = new DateTime(2001, 9, 11), Type = "Passenger"};
        Console.WriteLine(plane);
        Console.WriteLine();

        Matrix matrix1 = new(new double[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        });

        Matrix matrix2 = new(new double[,] {
            {10, 11, 12},
            {13, 14, 15},
            {16, 17, 18}
        });

        Matrix matrix3 = new(new double[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        });

        Console.WriteLine($"{matrix1.Min()}, {matrix1.Max()}");
        Console.WriteLine($"{matrix2.Min()}, {matrix2.Max()}");

        Console.WriteLine(matrix1 == matrix2);
        Console.WriteLine(matrix1 == matrix3);

        Console.WriteLine(matrix1);
        Console.WriteLine(matrix2);
    }
}