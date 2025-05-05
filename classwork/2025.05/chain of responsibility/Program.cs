using System.Runtime.InteropServices;

class Code {
    static void Main() {
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();

        h1.Successor = h2;
        h1.HandleRequest(1);
        h2.HandleRequest(2);
    }
}