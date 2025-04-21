abstract class DataProcessor<T> {
    abstract public T ProcessData(T data);

    public T? data;

    public event Action<T>? OnProcessingComplete;

    public DataProcessor() {
        OnProcessingComplete += EventHandler;
    }

    protected void Invoke() => OnProcessingComplete?.Invoke(data);
    
    void EventHandler(T data) {
        Console.WriteLine($"Data processed: {data}, Data Type: {typeof(T).Name}");
    }
}