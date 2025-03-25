// Работа с каталогами
// Directory DirectoryInfo

// Работа с файлами
// FileInfo Info

using System.Text;
using System.IO;

class Code {
    static void Main() {
        // Текущий каталог
        // DirectoryInfo dir = new(".");
        // Console.WriteLine($"Full dir path: {dir.FullName}");
        // Console.WriteLine($"All dir files:");
        // FileInfo[] files = dir.GetFiles();

        // foreach (FileInfo file in files) {
        //     Console.WriteLine(file.Name);
        // }

        // DriveInfo[] drives = DriveInfo.GetDrives();
        // foreach (DriveInfo drive in drives) {
        //     Console.WriteLine($"Name: {drive.Name}");
        //     Console.WriteLine($"Type: {drive.DriveType}");
            
        //     if (drive.IsReady) {
        //         Console.WriteLine($"Total space: {drive.TotalSize}");
        //         Console.WriteLine($"Free space: {drive.AvailableFreeSpace}");
        //     }
        // }

        // Absolute
        // string path = "/home/rotatick"; // Linux

        // DirectoryInfo dir1 = new("/home/rotatick/test");
        // if (!dir1.Exists) {
        //     dir1.Create();
        // }
        // Console.WriteLine($"Last dir access time: {dir1.LastAccessTime}");

        // // subdir
        // DirectoryInfo dir2 = dir1.CreateSubdirectory("subdir1");
        // Console.WriteLine($"Created subdir at: {dir2.FullName}");

        // FileInfo fInfo = new(dir2 + "/test.bin");
        // WriteFile(fInfo);
        // Console.WriteLine(ReadFile(fInfo));
        // Console.WriteLine($"\n\tFiles with .bin extension: ");

        // FileInfo[] files = dir2.GetFiles("*.bin");
        // foreach (FileInfo f in files) {
        //     Console.WriteLine(f.Name);
        // }

        string path2 = "/home/rotatick/test/subdir1/test.txt";
        try {
            WriteFile2(path2);
            Console.WriteLine(ReadFile2(path2));
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    static void WriteFile2(string path) {
        using (StreamWriter sw = File.CreateText(path)) {
            Console.WriteLine("\nEnter data: ");
            string? writeText = Console.ReadLine();
            sw.WriteLine(writeText);
            foreach (var item in writeText) {
                sw.Write($"{item} ");
            }
            Console.WriteLine("\nData recorded");
        }
    }

    static string ReadFile2(string path) {
        using (StreamReader sr = File.OpenText(path)) {
            return sr.ReadToEnd();
        }
    }

    static void WriteFile(FileInfo file) {
        using (FileStream fs = file.Open(FileMode.Create, FileAccess.Write, FileShare.None)) {
            Console.Write("Enter data: ");
            string? data = Console.ReadLine();
            byte[] bytes = Encoding.Default.GetBytes(data);
            fs.Write(bytes, 0, bytes.Length);
            Console.WriteLine("Data recorded");
        }
    }

    static string ReadFile(FileInfo file) {
        using (FileStream fs = file.OpenRead()) {
            byte[] readBytes = new byte[(int)fs.Length];
            fs.Read(readBytes, 0, readBytes.Length);
            return Encoding.Default.GetString(readBytes);
        }
    }
}