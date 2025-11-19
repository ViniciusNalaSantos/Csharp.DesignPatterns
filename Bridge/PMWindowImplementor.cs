using Csharp.DesignPatterns.Bridge.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Bridge;
public class PMWindowImplementor : WindowImplementor
{
    // lots of Presentation Manager system-specific state:
    private int _hps;

    public override void DeviceRect(CoordinatesDto coordinates)
    {
        Console.WriteLine("Logic of a rectangle being draw on a window of Presentation Manager system....");
    }
}
