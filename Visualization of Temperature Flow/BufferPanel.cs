using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Visualization_of_Temperature_Flow
{
    class BufferPanel: System.Windows.Forms.Panel
    {
        public BufferPanel()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
        }
    }
}
