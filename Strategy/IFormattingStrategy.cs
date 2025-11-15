using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Strategy;
public interface IFormattingStrategy
{
    void Compose(Context context);
}
