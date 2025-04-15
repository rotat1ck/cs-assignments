class ConcreteProrotype1 : Prototype{
    public ConcreteProrotype1(int id) : base(id) { }

    public override Prototype Clone() {
        return new ConcreteProrotype1(Id);
    }
}