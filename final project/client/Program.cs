using client.forms.Auth.Authentication;
using client.forms.Helper;

namespace client;

static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "client.db"))) {
            Application.Run(new EntryForm());
        } else {
            Application.Run(new LoginForm());
        }
    }    
}