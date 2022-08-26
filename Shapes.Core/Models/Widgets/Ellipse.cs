using System.Collections.Generic;

namespace Shapes.Core.Models.Widgets
{
    public class Ellipse : Widget
    {
        public uint DiameterH { get; }
        public uint DiameterV { get; }

        public Ellipse(uint diameterH, uint diameterV) : base(nameof(Ellipse))
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
        }

        public override IEnumerable<WidgetProperty> Properties()
        {
            yield return new WidgetProperty(nameof(DiameterH), DiameterH);
            yield return new WidgetProperty(nameof(DiameterV), DiameterH);
        }
    }
}