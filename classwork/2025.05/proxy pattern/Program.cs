using System.ServiceModel;

class Code {
    static void Main() {
        IHuman human = new Operator();
        IHuman surrogate = new Surrogate(human);
        surrogate.Request();

        BasicHttpBinding bind = new();
        Uri address = new("http://localhost:4000/ISubject");
        Type contract = typeof(ISubject);

        ServiceHost host = new(typeof(RealSubject));
    }
}