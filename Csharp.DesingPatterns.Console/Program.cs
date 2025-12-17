// Abstract Factory
using Csharp.DesignPatterns.Domain.AbstractFactory;

var product1Factory = new Product1AbstractFactory();
var productA1 = product1Factory.CreateProductA();
productA1.DoSomething();
