class Code {
    static void Main() {
        // User user = new User("123", "456");
        // user.Print();

        // (string name, string lastname) = user;
        // Console.WriteLine($"{name}, {lastname}");

        //private
        //private protected
        //file
        //protected
        //internal
        //protected internal
        //public

        User user = new User();
        user.Name = "Test12";
        Console.WriteLine(user.Name);
    }
}
