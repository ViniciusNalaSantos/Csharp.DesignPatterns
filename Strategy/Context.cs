using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Strategy;
public class Context
{
    private IFormattingStrategy _formattingStrategy;
    public int property { get; set; } = 0;

    public Context(IFormattingStrategy formattingStrategy)
    {
        _formattingStrategy = formattingStrategy;
    }

    public void SetStrategy(IFormattingStrategy formattingStrategy)
    {
        _formattingStrategy = formattingStrategy;
    }

    public void DoSomeBusinessLogic()
    {
        _formattingStrategy.Compose(this);
    }
}
