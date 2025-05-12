class Code {
    static void Main() {
        ActorMike mike = new();

        RoleAustin roleAustin = new(mike);
        roleAustin.Greeting("Hello, goida. It's austin");

        RoleDoctor roleDoctor = new(mike);
        roleDoctor.Greeting("Role doctor");
    }
}