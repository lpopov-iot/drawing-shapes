using System.Collections.Generic;

namespace Shapes.Core.Models.Widgets
{
    public class Rectangle : Widget
    {
        public uint Width { get; }
        public uint Height { get; }

        public Rectangle(uint width, uint height) : base(nameof(Rectangle))
        {
            Width = width;
            Height = height;
        }

        public override IEnumerable<WidgetProperty> Properties()
        {
            yield return new WidgetProperty(nameof(Width), Width);
            yield return new WidgetProperty(nameof(Height), Height);
        }
    }
}