// System.GC;

class Code {
    static void Main() {
        //Test();
        //long totalMemory = GC.GetTotalMemory(false);

        //GC.Collect(2, GCCollectionMode.Forced);
        //GC.WaitForPendingFinalizers();

        //GC.Collect();
        //Console.Read();

        // unsafe {
        //     int* x;
        //     int y = 10;

        //     x = &y;
        //     Console.WriteLine(*x);

        //     y = y + 20;
        //     Console.WriteLine(*x);

        //     y = 50;
        //     Console.WriteLine(*x);

        //     int** z = &x;
        //     **z = **z + 40;
        //     Console.WriteLine(y);
        //     Console.WriteLine(**z);
        // }

        unsafe {
            Point point = new Point(0, 0);
            Console.WriteLine(point);

            Point* p = &point;

            p->X = 30;
            Console.WriteLine(p->X);

            (*p).Y = 180;
            Console.WriteLine((*p).Y);

            Console.WriteLine(point);
        }
    }

    struct Point {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }
    }

    //static void Test() {
        // Person? ivan = null;
        // try {
        //     ivan = new("Ivan");
        //     Console.WriteLine(ivan.Name);
        // } finally {
        //     ivan.Dispose();
        // }

        //using (Person ivan = new("Ivan")) {
            //using (Person petr = new("Petr")) {
                //Console.WriteLine($"Person 1: {ivan.Name}, Person 2: {petr.Name}");
            //}
        //}
        //Console.WriteLine("End method Test");
    //}

    unsafe void Test() {

    }
}

unsafe class User {

}

// record class Person(string Name);

class Person : IDisposable {
    public string? Name { get; set; }
    public Person(string name) => Name = name;

    public void Dispose() {
        Console.WriteLine($"{Name} was deleted");
    }
    
    // ~Person() {
    //     Console.WriteLine($"{Name} was deleted");
    // }

    // protected override void Finalize() {
    //     try { }
    //     finally {
    //         base.Finalize();
    //     }
    // }
}