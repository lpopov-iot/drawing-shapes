using System.Collections.Generic;

namespace Shapes.Core.Models.Widgets
{
    public class Square : Widget
    {
        public uint Size { get; }

        public Square(uint size) : base(nameof(Square))
        {
            Size = size;
        }

        public override IEnumerable<WidgetProperty> Properties()
        {
            yield return new WidgetProperty(nameof(Size), Size);
        }
    }
}