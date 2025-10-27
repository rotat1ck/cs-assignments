using System.Net;

namespace http_listener {
    internal class Program {
        static async Task Main(string[] args) {
            HttpListener serv = new();
            serv.Start();
            serv.Prefixes.Add("http://127.0.0.1:8888/connection/");

            var context = await serv.GetContextAsync();
            var request = context.Request;
            var response = context.Response;
            var user = context.User;

            serv.Stop();
        }
    }
}
