using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Domain.AbstractFactory;

public class ProductA1 : IProductA
{
    public void DoSomething()
    {
        Console.Write("ProductA1 doing something...");
    }
}