class Code {
    static void Main() {
        Prototype? prototype = null;
        Prototype? clone = null;

        prototype = new ConcreteProrotype1(1);
        clone = prototype.Clone();

        prototype = new ConcreteProrotype2(2);
        clone = prototype.Clone();
    }
}