namespace server {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapPost("/data", async (HttpContext httpContext) => {
                var form = httpContext.Request.Form;
                string? name = form["name"];
                string? email = form["email"];
                string? age = form["age"];
                await httpContext.Response.WriteAsync($"Name: {name}" +
                    $"Email: {email} Age: {age}");
            });

            app.MapPost("/data2", async (HttpContext context) => {
                var upPath = $"{Directory.GetCurrentDirectory()}/uploads";
                Directory.CreateDirectory(upPath);
                string fileName = Guid.NewGuid().ToString();

                using (var fileStream = new FileStream($"{upPath}/{fileName}.png",
                    FileMode.Create)) {
                    await context.Request.Body.CopyToAsync(fileStream);
                }
                await context.Response.WriteAsync("Данные сохранены");
            });

            app.MapPost("/data3", async (HttpContext context) => {
                using StreamReader sr = new StreamReader(context.Request.Body);
                string mes = await sr.ReadToEndAsync();
                await context.Response.WriteAsync($"Полученное сообщение: {mes}");
            });

            app.MapPost("/upload", async (HttpContext context) => {
                IFormFileCollection formFiles = context.Request.Form.Files;

                var uploadPath = $"{Directory.GetCurrentDirectory()}/uploads";
                Directory.CreateDirectory(uploadPath);

                foreach (var file in formFiles) {
                    string fullPath = $"{uploadPath}/{file.FileName}";
                    using (FileStream fs = new FileStream(fullPath, FileMode.Create)) {
                        await file.CopyToAsync(fs);
                    }
                }
                await context.Response.WriteAsync("Файлы загружены");
            });

            app.Run();
        }
    }
}
