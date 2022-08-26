namespace Shapes.Core.Models.Widgets
{
    public class WidgetProperty
    {
        public string Name { get; }
        public object Value { get; }

        public WidgetProperty(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}