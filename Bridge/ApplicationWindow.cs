using Csharp.DesignPatterns.Bridge.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Bridge;
public class ApplicationWindow : Window
{
    public ApplicationWindow(WindowImplementor windowImplementation) : base(windowImplementation)
    {
    }

    public override void DrawContents()
    {
        WindowImplementor.DrawOn(this);
    }

    public override void DrawRect()
    {
        var coordinates = new CoordinatesDto();
        WindowImplementor.DeviceRect(coordinates);
    }
}
