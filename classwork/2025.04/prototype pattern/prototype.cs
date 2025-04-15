abstract class Prototype {
    public int Id { get; set; }

    public Prototype(int id) {
        Id = id;
    }

    public abstract Prototype Clone();
}