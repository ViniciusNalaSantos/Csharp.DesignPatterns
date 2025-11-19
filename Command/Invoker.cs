using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Command;
public class Invoker
{
    private ICommand _command;
    public void StoreCommand(ICommand command)
    {
        _command = command;
    }

    public void Execute()
    {
        _command.Execute();
    }
}
