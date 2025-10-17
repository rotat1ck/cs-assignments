using System.Net.Http;
using System.Text;

namespace client {
    internal class Program {
        static HttpClient client = new();
        static async Task Main(string[] args) {
            //Dictionary<string, string> data = new() {
            //    ["name"] = "Vova",
            //    ["email"] = "vova@mail.ru",
            //    ["age"] = "18"
            //};

            //HttpContent content = new FormUrlEncodedContent(data);
            //using var response = await client.PostAsync("http://localhost:5285/data", content);

            //string resText = await response.Content.ReadAsStringAsync();
            //Console.Write(resText);

            //string filePath = @"1.png";
            //using var fileStream = File.OpenRead(filePath);
            //StreamContent content = new StreamContent(fileStream);

            //using var response = await client.PostAsync("http://localhost:5285/data2", content);
            //string resText = await response.Content.ReadAsStringAsync();
            //Console.Write(resText);

            string mes = "Welcome to GOIDA";
            byte[] mesToBytes = Encoding.UTF8.GetBytes(mes);
            var content = new ByteArrayContent(mesToBytes);
            using var response = await client.PostAsync("http://localhost:5285/data3", content);

            string resText = await response.Content.ReadAsStringAsync();
            Console.WriteLine(resText);
        }
    }
}
