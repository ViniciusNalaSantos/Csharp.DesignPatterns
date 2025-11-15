using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Composite;
public class Title : Glyph //IGlyphOld
{
    public override void Draw()
    {
        Console.WriteLine("Logic of a title being draw...");
    }
}
