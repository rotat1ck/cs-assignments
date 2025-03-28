using System.Dynamic;

class GoidaArray {
    int[]? arr;
    int index = 0;

    public GoidaArray() { }

    public GoidaArray(int[]? arr) {
        this.arr = arr;
    }

    public int ElementNow {
        get { return arr[index]; }
        set { arr[index] = value; }
    }

    public int this[int index] {
        get { 
            this.index = index;
            return arr[index]; 
        } set { 
            this.index = index;
            arr[index] = value; 
        }
    }
}

class RoflArray {
    int[]? arr;

    public RoflArray() { }

    public RoflArray(int[]? arr) {
        this.arr = arr;
    }

    public int this[int index] {
        get { 
            return arr[index] % 10 * (int)Math.Pow(10, index); 
        } set { arr[index] = value; }
    }
}

class StringArray {
    List<string>? arr;

    public StringArray() { }

    public StringArray(List<string>? arr) {
        this.arr = arr;
    }

    public string this[int index] {
        get { return arr[index]; }
        set {
            if (index < arr.Count) {
                arr[index] = value;
            }
        }
    }

    public char this[int index1, int index2] {
        get { return arr[index1][index2]; }
        set { 
            char[] s = arr[index1].ToArray();
            s[index2] = value;
            arr[index1] = new string(s);
        }
    }
}