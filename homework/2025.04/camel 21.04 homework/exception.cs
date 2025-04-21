class ValidationException : ApplicationException {
    public Type? type { get; }
    public ValidationException(string message, Type type) : base(message) {
        this.type = type;
    }

    public override string Message => $"Validation error: {base.Message} (Data type: {type})";
}