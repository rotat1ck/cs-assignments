class Simple {
    public delegate double AnonyomousDelegateDouble(double x, double y);
    public delegate void AnonyomousDelegateInt(int x);
    public delegate void AnonyomousDelegateVoid();

    public event AnonyomousDelegateDouble? eventDouble;
    public event AnonyomousDelegateInt? eventVoid;

    public double OnEventDouble(double x, double y) {
        if (eventDouble != null) {
            return eventDouble(x, y);
        }
        throw new NullReferenceException();
    }

    public void OnEventVoid(int n = 0) {
        if (eventVoid != null) {
            eventVoid(n);
        }
    }
}