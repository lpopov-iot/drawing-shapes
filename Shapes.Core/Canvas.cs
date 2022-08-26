using System;
using System.Collections.Generic;
using Shapes.Core.Models;
using Shapes.Core.Models.Widgets;

namespace Shapes.Core
{
    public class Canvas : IDrawingSurface
    {
        public IDictionary<Guid, ActiveWidget> WidgetInstances { get; } = new Dictionary<Guid, ActiveWidget>();

        public void AddWidget(Widget widget, Coordinates coordinates)
        {
            WidgetInstances.Add(Guid.NewGuid(), new ActiveWidget(widget, coordinates));
        }

        public void Print()
        {
            foreach (var widgetInstance in WidgetInstances.Values)
            {
                widgetInstance.OutputToConsole();
            }
        }
    }
}