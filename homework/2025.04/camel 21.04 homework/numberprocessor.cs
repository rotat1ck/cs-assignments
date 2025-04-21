class NumberProcessor : DataProcessor<int>, IValidatable<int> {
    public override int ProcessData(int data) {
        if (!Validate(data)) {
            return -1;
        }

        this.data = data;
        Invoke();
        return data * 2;
    }

    public bool Validate(int data) {
        if (int.IsNegative(data)) {
            throw new ValidationException("Number is negative", typeof(int));
        }
        return true;
    }

    public NumberProcessor() : base() { }
}