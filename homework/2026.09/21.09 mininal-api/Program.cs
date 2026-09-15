using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using mininal_api.Shapes;
using mininal_api.Vehicles;

public static class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.MapShapeEndpoints();

        app.MapGet("/vehicle/{vehicleType}", GetPer100Kilo);

        app.Run();
    }

    private static WebApplication MapShapeEndpoints(this WebApplication app)
    {
        app.MapGet("/shape/circle", ([FromQuery] double radius) =>
        {
            var circle = new Circle(radius);
            return new
            {
                Area = circle.Area(),
                Perimeter = circle.Perimeter()
            };
        });

        app.MapGet("/shape/rectangle", ([FromQuery] double width, [FromQuery] double height) =>
        {
            var rectangle = new Rectangle(width, height);
            return new
            {
                Area = rectangle.Area(),
                Perimeter = rectangle.Perimeter()
            };
        });

        app.MapGet("/shape/triangle", ([FromQuery] double sideA, [FromQuery] double sideB, [FromQuery] double sideC) =>
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return new
            {
                Area = triangle.Area(),
                Perimeter = triangle.Perimeter()
            };
        });

        return app;
    }

    private static object GetPer100Kilo(string vehicleType)
    {
        var type = Type.GetType($"mininal_api.Vehicles.{vehicleType}", throwOnError: false, ignoreCase: true);
        if (type is null)
        {
            return new { Error = "Vehicle type not found" };
        }

        var vehicle = Activator.CreateInstance(type) as Vehicle;
        return new
        {
            Per100Kilo = vehicle.LiterPerKilo * 100
        };
    }
}
