class Text : IGraphic {
    private List<IGraphic> children = [];

    public void Add(IGraphic graphic) {
        children.Add(graphic);
    }

    public void Draw(IGraphic device) {
        Console.WriteLine($"Drawing a {device.GetType().FullName}");
    }

    public IGraphic GetChild(int child) {
        return children[child];
    }

    public void Remove(IGraphic graphic) {
        foreach (var child in children) {
            if (child == graphic) {
                children.Remove(child);
                break;
            }
        }
    }
}