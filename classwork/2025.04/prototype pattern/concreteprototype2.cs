class ConcreteProrotype2 : Prototype {
    public ConcreteProrotype2(int id) : base(id) { }

    public override Prototype Clone() {
        return new ConcreteProrotype2(Id);
    }
}