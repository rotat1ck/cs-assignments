using Microsoft.AspNetCore.Http.HttpResults;

namespace server {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapGet("/{id}", (int? id) => {
                if (id is null) {
                    return Results.BadRequest(new { Message = "Некорректные данные в запросе" });
                } else if (id != 1) {
                    return Results.NotFound(new { Message = $"Объект c id={id} не существует" });
                } else {
                    return Results.Ok(new User("Vova", 20));
                }
            });

            app.Run();
        }

        public record User(string name, int age);
    }
}
