using Csharp.DesignPatterns.Bridge.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Bridge;
public class XWindowImplementor : WindowImplementor
{
    // lots of X Windows system-specific state:
    private int _dpy;
    private int _winid;
    private int _gc;
    public override void DeviceRect(CoordinatesDto coordinates)
    {
        Console.WriteLine("Logic of a rectangle being draw on a window of X Window system....");
    }
}
