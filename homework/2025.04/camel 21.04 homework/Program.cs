class Code {
    static void Main() {
        StringProcessor processor = new();
        try {
            string data = processor.ProcessData("гойда");
            Console.WriteLine(data);
        } catch (ValidationException ex) {
            Console.WriteLine(ex.Message);
        }

        NumberProcessor numberProcessor = new();
        try {
            int data = numberProcessor.ProcessData(5);
            Console.WriteLine(data);
        } catch (ValidationException ex) {
            Console.WriteLine(ex.Message);
        }
    }
}