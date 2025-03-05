using System.Diagnostics;

sealed class OperationTimer : IDisposable {
    long _startTime;
    string _text;
    int _collectionCount;

    public OperationTimer(string text) {
        PrepareForOperation();

        _text = text;
        _collectionCount = GC.CollectionCount(0);
        _startTime = Stopwatch.GetTimestamp();
    }

    public void Dispose() {
        Console.WriteLine($"{_text}\t{(Stopwatch.GetTimestamp() - _startTime) 
        / (double)Stopwatch.Frequency:0.00}секунды(сборок мусора) {GC.CollectionCount(0) -
        _collectionCount}");
    }

    private void PrepareForOperation() {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}