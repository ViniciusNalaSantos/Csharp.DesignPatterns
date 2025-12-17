using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Domain.AbstractFactory;
public interface IProductAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}