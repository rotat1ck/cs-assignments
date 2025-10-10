namespace api {
    public class Program {
        static int id = 1;
        static List<User> users = new List<User> {
            new User {Id = id++, Name = "Ivan", Age = 20 },
            new User {Id = id++, Name = "Anna", Age = 21 },
            new User {Id = id++, Name = "Vova", Age = 22 }
        };

        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("api/users", () => users);

            app.MapGet("api/users/{id}", (int id) => {
                User? user = users.FirstOrDefault(u => u.Id == id);
                if (user == null) {
                    return Results.NotFound( new { error = "Пользователь не найден"});
                }
                return Results.Json(user);
            });

            app.MapDelete("api/users/{id}", (int id) => {
                User? user = users.FirstOrDefault(u => u.Id == id);
                if (user == null) {
                    return Results.NotFound(new { error = "Пользователь не найден" });
                }
                users.Remove(user);
                return Results.Ok();
            });

            app.MapPost("api/users", (User user) => {
                user.Id = id++;
                users.Add(user);
                return user;
            });

            app.MapPut("api/users", (User userData) => {
                User? user = users.FirstOrDefault(u => u.Id == userData.Id);
                if (user == null) {
                    return Results.NotFound(new { error = "Пользователь не найден" });
                }
                user.Age = userData.Age;
                user.Name = userData.Name;
                return Results.Json(user);
            });

            app.Run();
        }
    }
}
