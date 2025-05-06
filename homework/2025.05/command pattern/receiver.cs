class Receiver {
    public string? value;
    public void Operation(char operation, string value) {
        switch (operation) {
            case '+': {
                this.value += value;
                break;
            } case '-': {
                this.value = this.value[.. (this.value.Length - value.Length)];
                break;
            }
        }
    }
}