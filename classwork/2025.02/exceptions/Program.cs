// Systemm.Exception
// throw 

class Code {
    static void Main() {
        // try {
        //     int x = 5;
        //     int y = x / 0;

        //     Console.WriteLine($"Result: {y}");
        //     Console.WriteLine("End");
        // } catch (Exception ex) {
        //     Console.WriteLine($"Error: {ex.Message}");
        // } finally {
        //     Console.WriteLine("Finally");
        // }

        // Myexp exp = new();

        // Console.WriteLine(exp.Message);

        Console.WriteLine("Enter nums: ");
        int num1, num2, res = 0;

        try {
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            res = num1 / num2;
            if (res % 2 != 0) {
                throw new Myexception();
            }
            Console.WriteLine($"Result: {res}");
        } catch (Myexception my) {
            Console.WriteLine(my.Message);
            Console.WriteLine(my.ExceptionTime);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}