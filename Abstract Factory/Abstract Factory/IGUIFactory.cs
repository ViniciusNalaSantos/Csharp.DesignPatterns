using Csharp.DesignPatterns.Abstract_Factory.Glyphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Abstract_Factory.Abstract_Factory;
public interface IGUIFactory
{
    IGlyph CreateButton();
    IGlyph CreateScrollBar();
}
