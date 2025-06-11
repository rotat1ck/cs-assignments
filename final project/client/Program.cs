using client.forms.Auth.Authentication;

namespace client;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        DBController.InitDB("client.db");
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }    
}