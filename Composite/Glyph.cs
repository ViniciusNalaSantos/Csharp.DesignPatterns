using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Composite;
public class Glyph
{
    // Would better if it was a DTO instead of this
    protected int x0 {  get; set; }
    protected int y0 { get; set; }
    protected int x1 { get; set; }
    protected int y1 { get; set; }

    public Glyph Parent { get; private set; }

    public Glyph(Glyph parent = null)
    {
        this.Parent = parent;
    }
    protected void SetParent(Glyph parent)
    {
        Parent = parent;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Logic of a glyph being draw...");
    }
    public (int, int, int, int) Bounds()
    {
        return (x0, y0, x1, y1);
    }
    public bool Intersect(int c0, int c1)
    {
        Console.WriteLine("Returnin if glyph intersect a coordinate...");
        return true;
    }
    public virtual void Insert(Glyph child)
    {
        throw new NotApplicableActionException();
    }
    public virtual void Remove(Glyph child)
    {
        throw new NotApplicableActionException();
    }
    public virtual Glyph Child(int index)
    {
        throw new NotApplicableActionException();
    }
    public IEnumerable<Glyph> CreateIterator()
    {
        return null;
    }
}
