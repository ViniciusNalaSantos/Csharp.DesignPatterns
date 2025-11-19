using Csharp.DesignPatterns.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Command;
public class OpenCommand : ICommand
{
    private Window _window;
    public OpenCommand(Window window) 
    {
        _window = window;
    }
    public void Execute()
    {
        var documentPath = AskUser();
        if (documentPath != "")
        {
            //var document = new Document(documentPath);
            //_window.Add(document);
            //document.Open();
            Console.WriteLine("Logic of the open command...");
        }
    }
    private string AskUser()
    {
        Console.WriteLine("Enter a documents path: ");
        Console.ReadLine();
        return "/path";
    }
}
