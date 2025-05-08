interface IGraphic {
    void Add(IGraphic graphic);
    void Draw(IGraphic device);
    IGraphic GetChild(int child);
    void Remove(IGraphic graphic);
}