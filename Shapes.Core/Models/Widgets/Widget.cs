using System.Collections.Generic;

namespace Shapes.Core.Models.Widgets
{
    public abstract class Widget
    {
        protected Widget(string type)
        {
            Type = type;
        }

        public string Type { get; }
        public abstract IEnumerable<WidgetProperty> Properties();
    }
}