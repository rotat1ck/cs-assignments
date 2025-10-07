using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;

namespace httpclient {
    internal class Program {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args) {
            using HttpRequestMessage request = new HttpRequestMessage
                (HttpMethod.Get, "https://ya.ru");
            //await client.SendAsync(request);

            // get request + response

            //using HttpResponseMessage response = await client.SendAsync(request);

            //Console.WriteLine($"Status code: {response.StatusCode}\n");
            //Console.WriteLine($"Headers:");
            //foreach (var header in response.Headers) {
            //    Console.WriteLine($"{header.Key}: ");
            //    foreach (var headerValue in header.Value) {
            //        Console.WriteLine(headerValue);
            //    }
            //}
            //Console.WriteLine("\nContent: ");
            //string content = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(content);

            // simple response (no request variable)
            //using HttpResponseMessage response1 = await client.GetAsync("https://ya.ru");

            // only content (no response, no request)
            //string content1 = await client.GetStringAsync("https://ya.ru");

            // content using stream
            //using Stream stream = await client.GetStreamAsync("https://ya.ru");
            //using StreamReader reader = new StreamReader(stream);
            //string content2 = await reader.ReadToEndAsync();
            //Console.WriteLine(content2);

            // getting json (no response variable)
            //User? user = await client.GetFromJsonAsync<User>("http://localhost:5082/");
            //Console.WriteLine($"Name: {user.name} Age: {user.age}");

            // getting response and parsing json
            using var response = await client.GetAsync("http://localhost:5082/2");
            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest || response.StatusCode == System.Net.HttpStatusCode.NotFound) {
                Error? error = await response.Content.ReadFromJsonAsync<Error>();
                Console.WriteLine(response.StatusCode);
                Console.WriteLine(error.message);
            } else {
                User? user1 = await response.Content.ReadFromJsonAsync<User>();
                Console.WriteLine($"Name: {user1.name} Age: {user1.age}");
            }
        }

        record User(string name, int age);
        record Error(string message);
    }
}
