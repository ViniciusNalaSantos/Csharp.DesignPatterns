using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Decorator;
public class VisualComponentDecorator: VisualComponent
{
    private VisualComponent _visualComponent;
    public VisualComponentDecorator(VisualComponent visualComponent)
    {
        _visualComponent = visualComponent;
    }

    public override void Draw()
    {
        _visualComponent.Draw();
        Console.WriteLine("Extra logic of the decorator being draw...");
    }
}
