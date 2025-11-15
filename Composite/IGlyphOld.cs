using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Composite;

internal interface IGlyphOld
{
    void Draw();
    void Bounds();
    bool Intersect(int x0, int x1);
    void Insert(IGlyphOld child);
    void Remove(IGlyphOld child);
    IGlyphOld Child(int index);
    IGlyphOld Parent();
}
