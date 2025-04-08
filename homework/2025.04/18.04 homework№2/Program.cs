class Code {
    static void Main() {
        Client colaCl = new(new ColaFactory());
        colaCl.Run();

        Client pepsiCl = new(new PepsiFactory());
        pepsiCl.Run();
    }
}