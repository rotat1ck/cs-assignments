class GenericClass<T> {
    public void M1(T obj) {
        Console.WriteLine($"Parametr: {obj}");
    }

    public virtual void M2(T data) {
        Console.WriteLine($"Generic: {data}");
    }
}

class InheritClass : GenericClass<int> {
    public override void M2(int data) {
        Console.WriteLine($"Inherited: {data}");
    }
}