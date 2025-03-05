class City {
    string? name = null; 
    int population;
    string? phoneCode = null;
    List<string> districts = [];

    public City(string name, int population, string phoneCode) {
        this.name = name;
        this.population = population;
        this.phoneCode = phoneCode;
    }

    public string Name {
        get { 
            return name;
        } set {
            name = value;
        }
    }

    public int Population {
        get {
            return population;
        } set {
            population = value;
        }
    }

    public string PhoneCode {
        get {
            return phoneCode;
        } set {
            phoneCode = value;
        }
    }

    public List<string> Districts {
        get {
            return districts;
        } set {
            districts = value;
        }
    }

    public override string ToString(){
        return $"Name {name}, Population {population}, PhoneCode {phoneCode}";
    }
}