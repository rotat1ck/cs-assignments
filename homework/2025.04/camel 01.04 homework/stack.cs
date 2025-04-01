class GenericStack<T> {
    private List<T> items = new();

    public GenericStack() { }

    public GenericStack(IEnumerable<T> items) {
        this.items = items.ToList();
    }

    public void Push(T item) {
        items.Add(item);
    }

    public void Pop() {
        items.RemoveAt(items.Count - 1);
    }

    public T Peek() {
        return items.Last();
    }
}