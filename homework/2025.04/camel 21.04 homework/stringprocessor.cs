class StringProcessor : DataProcessor<string>, IValidatable<string> {
    public override string ProcessData(string data) {
        if (!Validate(data)) {
            return null!;
        }

        this.data = data;
        Invoke();
        return data.ToUpper();
    }

    public bool Validate(string data) {
        if (string.IsNullOrEmpty(data)) {
            throw new ValidationException("Data is null or empty.", typeof(string));
        }
        return true;
    }

    public StringProcessor() : base() { }
}