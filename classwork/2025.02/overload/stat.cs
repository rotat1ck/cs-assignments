class Stat {
    static int count;
    public int Count => count;
    int age;
    public static int limitAge = 18;
    static int limAge = 18;

    public static int LimAge {
        get { return limAge; }
        set {
            if (value > 1 && value < 100) {
                limAge = value;
            }
        }
    }

    public Stat(int age) {
        this.age = age;
        count++;
    }

    public void Check() {
        if (age >= limitAge) {
            Console.WriteLine("Welcome");
        } else {
            Console.WriteLine("GO AWAY MINOR");
        }
    }
    
    public static void AddAge() {
        LimAge++;
        Console.WriteLine(LimAge);

    }

    static Stat() {
        if (DateTime.Now.Year == 2024) {
            limAge = 18;
        } else {
            limAge = 21;
        }
    }
}

static class Stat2 {
    public static double Add(double a, double b) => a + b;
}
