using System;
using System.Linq;

delegate T AddDelegate<T>(T x, T y);

// class Exam {
//     public int AddInt(int x, int y) {
//         return x + y;
//     }

//     public double AddDouble(double x, double y) {
//         return x + y;
//     }

//     public static char AddChar(char x, char y) {
//         return (char)(x + y);
//     }
// }

class Code {
    static string FullName(Student student) {
        return $"{student.LastName} {student.FirstName}";
    }

    static void DbOp(int a, int b, Action<int, int> op) {
        op(a, b);
    }

    static void Add(int a, int b) {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }   
    
    static void Mult(int a, int b) {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    // Func<T, return type> - return delegate
    static int DbOpl(int n, Func<int, int> op) => op(n);
    static int DoubleNum(int n) => 2 *n;
    static int SquareNum(int n) => n * n;

    // Predicate - return bool
    static Predicate<int> isPosivite = (int n) => {
        if (n > 0) {
            return true;
        }
        return false;
    };
    

    static void Main() {
        // Exam exam = new();
        // AddDelegate<int> delInt = exam.AddInt;
        // Console.WriteLine($"AddInt {delInt(8, 3)}");

        // AddDelegate<double> delDouble = exam.AddDouble;
        // Console.WriteLine($"AddDouble {delDouble(8.5, 3.7)}");

        // AddDelegate<char> delChar = Exam.AddChar;
        // Console.WriteLine($"AddChar {delChar('!', '#')}");

        List<Student> list = [
            new Student {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Date = new DateTime(2003, 3, 12)
            },
            new Student {
                FirstName = "Anna",
                LastName = "Ivanova",
                Date = new DateTime(2005, 6, 6)
            },
            new Student {
                FirstName = "Vova",
                LastName = "Ivanov",
                Date = new DateTime(2003, 6, 12)
            }
        ];

        // int res = DbOpl(6, DoubleNum);
        // Console.WriteLine(res);
        // int res1 = DbOp(10, 10, );
        // Console.WriteLine(isPosivite(20));
        // Console.WriteLine(isPosivite(-1));

        IEnumerable<string> students = list.Select(FullName);

        foreach (string student in students) {
            Console.WriteLine(student);
        }

        List<Student> students1 = list.FindAll(OnlySpring);

        foreach (var student in students1) {
            Console.WriteLine(student);
        }
    }

    static bool OnlySpring(Student student) {
        return student.Date.Month >= 3 && student.Date.Month <= 5;
    }
}
