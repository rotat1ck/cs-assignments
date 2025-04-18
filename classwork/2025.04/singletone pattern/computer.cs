using System.Runtime.InteropServices;

class Computer {
    public OS OS { get; set; }
    public void Launch(string osName) {
        OS = OS.getInstance(osName);
    }
}