using System;
using System.Text;
using Shapes.Core.Models.Widgets;

namespace Shapes.Core.Models
{
    public class ActiveWidget
    {
        private readonly Widget _widget;
        private readonly Coordinates _coordinates;

        public ActiveWidget(Widget widget, Coordinates coordinates)
        {
            _widget = widget;
            _coordinates = coordinates;
        }

        public void OutputToConsole()
        {
            var sb = new StringBuilder();

            sb.Append(_widget.Type);
            sb.Append($" ({_coordinates.X},{_coordinates.Y})");

            var widgetProperties = _widget.Properties();

            foreach (var property in widgetProperties)
            {
                if (property.Value is string)
                {
                    sb.Append($" {property.Name}=\"{property.Value.ToString()}\"");
                }
                else
                {
                    sb.Append($" {property.Name.ToLower()}={property.Value.ToString()}");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}