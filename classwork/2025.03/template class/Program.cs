class Code {
    static void Main() {
        // InheritClass obj = new();
        // obj.M1(32);
        // obj.M2(35);

        // A<int>.Inner a = new();
        // Console.WriteLine(a);

        // A<double>.Inner b = new();
        // Console.WriteLine(b);

        // B<int>.Inner<string> c = new();
        // Console.WriteLine(c);

        // Point2D<int> point = new(1, 2);

        // int[] arr = [5, 6, 1, 12, 4];
        // Console.WriteLine(MaxElem<int>(arr));

        // List<Student> auditory = [
        //     new Student {
        //         FirstNmae = "Ivan",
        //         LastName = "Ivanov",
        //         BirthDate = new DateTime(1997, 3, 12)
        //     },
        //     new Student {
        //         FirstNmae = "Olga",
        //         LastName = "Ivanova",
        //         BirthDate = new DateTime(2003, 6, 1)
        //     },
        //     new Student {
        //         FirstNmae = "Anna",
        //         LastName = "Sergeevna",
        //         BirthDate = new DateTime(2001, 1, 1)
        //     }
        // ];

        // foreach (var student in auditory) {
        //     Console.WriteLine(student);
        // }
        // auditory.Sort();
        // foreach(var student in auditory) {
        //     Console.WriteLine(student);
        // }
        // auditory.Sort(new DataComparer());
        // foreach(var student in auditory) {
        //     Console.WriteLine(student);
        // }

        // yield return 

        Auditory audit = new();

        foreach (var st in audit) {
            Console.WriteLine(st);
        }

    }

    static T MaxElem<T> (T[] arr) where T : IComparable<T> {
        T max = arr[0];
        foreach (T i in arr) {
            if (i.CompareTo(max) > 0) {
                max = i;
            }
        }
        return max;
    }
}