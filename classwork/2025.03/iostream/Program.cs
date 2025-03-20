using System.Text;
class Code {
    static void Main() {
        // Stream
            // CanRead
            // CanWrite
            // CanSeek

        // Base streams
            // FileStream
            // MemoryStream
            // BufferedStream

        // Simbol streams
            // TextReader
            // TextWriter
        
        // FileStream
            // FileMode
            // FileAccess
            // FileShare

        // string filePath1 = "test.bin";
        // WriteFile(filePath1);
        // Console.WriteLine($"\nData read from { ReadFile(filePath1)}:");

        // StreamWriter
            // Write()
            // WriteLine()

        string filePath = "test.txt";
        using (FileStream fs = new(filePath, FileMode.Create)) {
            using (StreamWriter sw = new(fs, Encoding.Unicode)) {
                Console.Write("Enter data: ");
                string? writeText = Console.ReadLine();
                sw.WriteLine(writeText);
                // foreach (char item in writeText) {
                //     sw.Write($"{item} ");
                // }
                Console.WriteLine($"Recorded");
            }
        }

        // StreamReader
            // ReadBlock()
            // ReadLine()
            // ReadToEnd()

        using (FileStream fs = new(filePath, FileMode.Open)) {
            using (StreamReader sr = new(fs, Encoding.Unicode)) {
                Console.WriteLine($"Data read: {sr.ReadToEnd()}");
            }
        }

        string filePath2 = "test.dat";
        using (FileStream fs = new(filePath2, FileMode.Create)) {
            using (BinaryWriter bw = new(fs, Encoding.Unicode)) {
                Console.Write("Enter data: ");
                string? writeText = Console.ReadLine();
                double pi = 3.1415926;
                int num = 12345;

                bw.Write(writeText);
                bw.Write(pi);
                bw.Write(num);

                Console.WriteLine("Recorded");
            }
        }

        using (FileStream fs = new(filePath2, FileMode.Open)) {
            using (BinaryReader br = new(fs, Encoding.Unicode)) {
                Console.WriteLine($"Data read: {br.ReadString()}");
                Console.WriteLine($"Data read: {br.ReadDouble()}");
                Console.WriteLine($"Data read: {br.ReadInt32()}");
            }
        }
    }
    

    static void WriteFile(string filePath) {
        using (FileStream fs = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None)) {
            Console.Write("Enter date: ");
            string date = Console.ReadLine();
            byte[] writeBytes = Encoding.Default.GetBytes(date);
            fs.Write(writeBytes, 0, writeBytes.Length);
            Console.WriteLine("Recorded");
        }
    }

    static string ReadFile(string filePath) {
        using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)) {
            byte[] readBytes = new byte[(int)fs.Length];
            fs.Read(readBytes, 0, readBytes.Length);
            return Encoding.Default.GetString(readBytes);
        }
    }
}