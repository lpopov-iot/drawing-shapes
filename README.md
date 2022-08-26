# Design Rationale

The overall design of this basic application utilises OO design and SOLID principles to meet the brief.
However, time constraints didn't allow for an extensive implementation + testing.

The first major decision made was to allow `Widgets` to exist without coordinates.
This is in-line with common real world use cases where a `Widget` can be designed/saved in isolation without existing on a
drawing surface. 

The idea of an `ActiveWidget` is to represent a `Widget` on some coordinate-based system `IDrawingSurface`.
The `IDrawingSurface` allows the creation of `ActiveWidgets` and holds references to these in memory. The output of `Widget` information
is managed by the `IDrawingSurface` but uses property information collated and exposed by the `Widget`. 

Derived classes of the base `Widget` class must specify a `Type` and must override `GetProperties()` to retrieve property information.

No further work was done to break up `Widget` properties into base classes, causing minor duplication of properties (eg. width/height in multiple `Widgets`).
This also presents potential extension issues in future - with more effort allocated these would be seperated into base classes.