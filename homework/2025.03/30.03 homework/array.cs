abstract class MyArrayBase {
    protected int[]? data;
    protected int size;

    protected MyArrayBase(int size) {
        this.size = size;
        data = new int[size];
    }

    abstract public void Print();
    abstract public int this[int index] {get; set;}
}

class MyArray : MyArrayBase {
    public MyArray(int capacity) : base(capacity) { }

    public override void Print() {
        for (int i = 0; i < size; i++) {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine("");
    }

    public override int this[int index] { 
        get { return data[index]; }
        set { data[index] = value; } 
    }
}