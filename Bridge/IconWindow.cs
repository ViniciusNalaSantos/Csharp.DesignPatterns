using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DesignPatterns.Bridge;
public class IconWindow : Window
{
    private char _bitmap; // IconWindow stores the bitmap of the icon it displays...
    public IconWindow(WindowImplementor windowImplementor) : base(windowImplementor)
    {
    }

    public override void DrawContents()
    {
        WindowImplementor.DeviceBitmap(_bitmap);
    }
}
