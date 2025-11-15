using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Decorator;
public class VisualComponent
{
    public virtual void Draw()
    {
        Console.WriteLine("Logic of drawing a visual component...");
    }
}
