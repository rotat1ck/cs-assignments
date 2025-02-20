class Shop {
    Laptop[] laptopArr;

    public Shop(int size) {
        laptopArr = new Laptop[size];
    }

    public int Lenght {
        get { return laptopArr.Length; }
    }

    public Laptop this[int index] {
        get { 
            if (index >= 0 && index < laptopArr.Length){
                return laptopArr[index]; 
            } throw new IndexOutOfRangeException();
        }
        set { 
            laptopArr[index] = value; 
        }
    }

    public Laptop this[string name] {
        get {
            if (Enum.IsDefined(typeof(Vendor), name)) {
                return laptopArr[(int)Enum.Parse(typeof(Vendor), name)];
            } else {
                return new Laptop();
            }
        } set {
            if (Enum.IsDefined(typeof(Vendor), name)) {
                laptopArr[(int)Enum.Parse(typeof(Vendor), name)] = value;
            }
        }
    }

    public int FindByPrice(double price) {
        for (int i = 0; i < laptopArr.Length; i++) {
            if (laptopArr[i].Price == price) {
                return i;
            }
        }
        return -1;
    }

    public Laptop this[double price] {
        get {
            if (FindByPrice(price) >= 0) {
                return this[FindByPrice(price)];
            } throw new Exception("Laptop not found");
        } set {
            if (FindByPrice(price) >= 0) {
                this[FindByPrice(price)] = value;
            }
        }
    }

    enum Vendor {
        Samsung,
        Asus,
        Acer
    }
}