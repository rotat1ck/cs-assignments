class Surrogate : IHuman {
    IHuman? _operator;
    public Surrogate(IHuman operatorr) {
        this._operator = operatorr;
    }
    public void Request() {
        _operator.Request();
    }
}