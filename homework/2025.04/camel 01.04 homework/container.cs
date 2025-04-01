class Container<T> {
    private List<T> items = new();
    public int Count => items.Count;

    public Container() { }

    public Container(IEnumerable<T> items) {
        this.items = items.ToList();
    }

    public void Push(T item) {
        items.Add(item);
    }

    public void Pop(int index) {
        if (index > items.Count - 1) {
            return;
        }
        items.RemoveAt(index);
    }

    public T GetAt(int index) {
        return items[index];
    }

    public List<T> GetAll() {
        return items;
    }

    public T this[int index] {
        get => items[index];
        set => items[index] = value;
    }
}