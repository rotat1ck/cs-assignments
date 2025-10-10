using System.Net;
using System.Net.Http.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace client {
    internal class Program {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args) {
            List<User>? people = await client.GetFromJsonAsync<List<User>>
                ("http://localhost:5078/api/users");

            Console.WriteLine("\nGet all users: ");
            if (people != null) {
                foreach (var user in people) {
                    Console.WriteLine(user.Name);
                }
            }

            int id = 4;
            Console.WriteLine($"\nGet user by id = {id}: ");
            using var getResponse = await client.GetAsync($"http://localhost:5078/api/users/{id}");

            if (getResponse.StatusCode == System.Net.HttpStatusCode.NotFound) {
                Error? error = await getResponse.Content.ReadFromJsonAsync<Error>();
                Console.WriteLine($"Error: {error.error}");
            }
            else if (getResponse.StatusCode == HttpStatusCode.OK) {
                User? user = await getResponse.Content.ReadFromJsonAsync<User>();
                Console.WriteLine($"User: {user.Id}, {user.Name}, {user.Age}");
            }

            Console.WriteLine($"\nPost new user: ");
            User postUser = new User {
                Name = "Goida",
                Age = 555
            };
            using var postResponse = await client.PostAsJsonAsync($"http://localhost:5078/api/users", postUser);
            User? newUser = await postResponse.Content.ReadFromJsonAsync<User>();
            Console.WriteLine($"New user: {newUser.Id}, {newUser.Name}, {newUser.Age}");

            Console.WriteLine($"\nPut user: ");
            User? putUser = new User {
                Id = 1,
                Name = "Goida",
                Age = 444
            };
            using var putResponse = await client.PutAsJsonAsync($"http://localhost:5078/api/users", putUser);
            if (putResponse.StatusCode == HttpStatusCode.NotFound) {
                Error? error = await putResponse.Content.ReadFromJsonAsync<Error>();
                Console.WriteLine($"Error: {error.error}");
            }
            else if (putResponse.StatusCode == HttpStatusCode.OK) {
                putUser = await putResponse.Content.ReadFromJsonAsync<User>();
                Console.WriteLine($"Putted user: {putUser.Id}, {putUser.Name}, {putUser.Age}");
            }

            Console.WriteLine($"\nDelete user: ");
            using var deleteResponse = await client.DeleteAsync($"http://localhost:5078/api/users/{id}");
            if (deleteResponse.StatusCode == HttpStatusCode.NotFound) {
                Error? error = await putResponse.Content.ReadFromJsonAsync<Error>();
                Console.WriteLine($"Error: {error.error}");
            } else if (deleteResponse.StatusCode == HttpStatusCode.OK)
                Console.WriteLine($"User with id = {id} was deleted");
        }
    }

    public class User {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
    }

    public record Error(string error);
}
