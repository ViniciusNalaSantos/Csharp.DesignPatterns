using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Composite;
public class RowComposite : Glyph //IGlyphOld
{
    private IList<Glyph>? _children = new List<Glyph>();

    public override Glyph Child(int index)
    {
        Console.WriteLine("Logic of row returning its childs...");
        if (_children == null || index < 0 || index >= _children.Count)
        {
            return null;
        }

        return _children[index];
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing row...");
    }

    public void Insert(Glyph child)
    {
        Console.WriteLine("Logic of a row inserting a child...");
        //child.SetParent(this);
        _children.Add(child);
        Console.WriteLine("Child parent: " + child.Parent);
    }

    public override void Remove(Glyph child)
    {
        Console.WriteLine("Logic of a row removing a child...");
        if (_children == null || child == null)
            return;

        _children.Remove(child);
    }
}
