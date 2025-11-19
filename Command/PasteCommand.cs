using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Command;
public class PasteCommand : ICommand
{
    private Document _document;
    public PasteCommand(Document document)
    {
        _document = document;
    }
    public void Execute()
    {
        //_document.Paste();
        Console.WriteLine("Logic of the paste command...");
    }
}
