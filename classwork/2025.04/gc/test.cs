class SomeTest : IDisposable{
    private bool disposed = false;

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(false);
    }

    public virtual void Dispose(bool disposing) {
        if (disposed) {
            return;
        } if (disposing) {
            
        }
        disposed = true;
    }

    ~SomeTest() => Dispose(false);
}