using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Decorator;
public class TextView: VisualComponent
{
    public override void Draw() => Console.WriteLine("Logic of drawing a text view...");
}
