using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Strategy;
public class SimpleFormattingStrategy : IFormattingStrategy
{
    public void Compose(Context context)
    {
        context.property = 2;
    }
}
