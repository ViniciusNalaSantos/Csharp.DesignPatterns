using Csharp.DesignPatterns.Bridge.DTO;
using System.Drawing;

namespace Csharp.DesignPatterns.Bridge;

public class WindowImplementor
{
    public virtual void DrawOn(Window window) { }

    public virtual void WindowTop() { }
    public virtual void WindowBottom() { }
    public virtual void WindowSetExtent(Point point) { }
    public virtual void WindowSetOrigin(Point originPoint) { }

    public virtual void DeviceRect(CoordinatesDto coordinates) { }
    public virtual void DeviceText(CoordinatesDto coordinates) { }
    public virtual void DeviceBitmap(char bitmap) { }
}