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

        if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "client.db"))) {
            DBController.InitDB(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "client.db"));
            if (DBController.usersModel.Filter(("rights", "1")).Count > 0) {
                Application.Run(new LoginForm());
            } else {
                MessageBox.Show("Фатальная ошибка. Требуется переустановка программы");
                Environment.Exit(1);
            }
        } else {
            Application.Run(new EntryForm());
        }
    }    
}