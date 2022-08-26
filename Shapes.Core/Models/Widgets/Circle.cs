using System.Collections.Generic;

namespace Shapes.Core.Models.Widgets
{
    public class Circle : Widget
    {
        public uint Size { get; }

        public Circle(uint size) : base(nameof(Circle))
        {
            Size = size;
        }

        public override IEnumerable<WidgetProperty> Properties()
        {
            yield return new WidgetProperty(nameof(Size), Size);
        }
    }
}