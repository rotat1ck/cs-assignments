using System.Reflection;

class Code {
    static void Main() {
        Console.WriteLine("\tAttributes of class Employee");
        foreach (var attr in typeof(Emp).GetCustomAttributes(false)) {
            Console.WriteLine($"{attr.GetType().Name}: {attr}");
        }

        foreach (MemberInfo info in typeof(Emp).GetMembers()) {
            foreach (var attr in info.GetCustomAttributes(true)) {
                Console.WriteLine(attr);
            }
        }
    }
}