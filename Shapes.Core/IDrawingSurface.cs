using System;
using System.Collections.Generic;
using Shapes.Core.Models;
using Shapes.Core.Models.Widgets;

namespace Shapes.Core
{
    public interface IDrawingSurface
    {
        IDictionary<Guid, ActiveWidget> WidgetInstances { get; }

        void AddWidget(Widget widget, Coordinates coordinates);

        void Print();
    }
}