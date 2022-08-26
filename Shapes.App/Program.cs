using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shapes.App.Models;
using Shapes.Core;
using Shapes.Core.Models;
using Shapes.Core.Models.Widgets;

namespace Shapes.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var drawingSurface = host.Services.GetService<IDrawingSurface>();

            if (drawingSurface == null)
            {
                throw new Exception($"An implementation of {typeof(IDrawingSurface)} could not");
            }

            foreach (var input in GetInputs())
            {
                drawingSurface.AddWidget(input.Widget, input.Coordinates);
            }

            drawingSurface.Print();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddSingleton<IDrawingSurface, Canvas>();
                });

        private static InputWidget[] GetInputs()
        {
            return new InputWidget[]
            {
                new InputWidget()
                {
                    Widget = new Rectangle(30, 40),
                    Coordinates = new Coordinates(10, 10)
                },
                new InputWidget()
                {
                    Widget = new Square(35),
                    Coordinates = new Coordinates(15, 30)
                },
                new InputWidget()
                {
                    Widget = new Ellipse(300, 200),
                    Coordinates = new Coordinates(100, 150)
                },
                new InputWidget()
                {
                    Widget = new Circle(300),
                    Coordinates = new Coordinates(1, 1)
                },
                new InputWidget()
                {
                    Widget = new Textbox(200, 100, "sample text"),
                    Coordinates = new Coordinates(5, 5)
                }
            };
        }
    }
}