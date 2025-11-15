using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Bridge;
public class Window
{
    protected WindowImp WindowImplementation { get; set; }
    public Window(WindowImp windowImplementation) 
    {
        WindowImplementation = windowImplementation;
    }
    public virtual void DrawContents() { }
    public virtual void Open() { }
    public virtual void Close() { }
    public virtual void Iconify() { }
    public virtual void Deiconify() { }
    public virtual void SetOrigin() { }
    public virtual void SetExtent() { }
    public virtual void Raise() { }
    public virtual void Lower() { }
    public virtual void DrawLine() { }
    public virtual void DrawRect() { }
    public virtual void DrawPolygon() { }
    public virtual void DrawText() { }
}
