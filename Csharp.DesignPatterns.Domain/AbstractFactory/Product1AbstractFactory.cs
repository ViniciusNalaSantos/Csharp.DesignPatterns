using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Domain.AbstractFactory;
public class Product1AbstractFactory : IProductAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ProductA1();
    }

    public IProductB CreateProductB()
    {
        return new ProductB1();
    }
}