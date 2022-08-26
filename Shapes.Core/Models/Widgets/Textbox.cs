using System.Collections.Generic;

namespace Shapes.Core.Models.Widgets
{
    public class Textbox : Widget
    {
        public uint Width { get; }
        public uint Height { get; }
        public string Text { get; }

        public Textbox(uint width, uint height, string text) : base(nameof(Textbox))
        {
            Width = width;
            Height = height;
            Text = text;
        }

        public override IEnumerable<WidgetProperty> Properties()
        {
            yield return new WidgetProperty(nameof(Width), Width);
            yield return new WidgetProperty(nameof(Height), Height);
            yield return new WidgetProperty(nameof(Text), Text);
        }
    }
}