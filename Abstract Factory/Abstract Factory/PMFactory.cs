using Csharp.DesignPatterns.Abstract_Factory.Glyphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Abstract_Factory.Abstract_Factory;
public class PMFactory : IGUIFactory
{
    public IGlyph CreateButton()
    {
        Console.WriteLine("Logic of creating a presenter manager button...");
        return null;
    }

    public IGlyph CreateScrollBar()
    {
        Console.WriteLine("Logic of creating a presenter manager scrollbar...");
        return null;
    }
}
