using System.Security.Cryptography;

class Code {
    static void Main() {
        // Client cl = null;
        // cl = new Client();

        ClientWarrior cl = new(new ArcFactory());
        cl.Hit();
        cl.Run();
    }
}