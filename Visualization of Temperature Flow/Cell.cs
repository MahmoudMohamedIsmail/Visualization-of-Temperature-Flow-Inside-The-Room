using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualization_of_Temperature_Flow
{
    class Cell
    {
        public int X, Y, Side;
        public bool Block, Heat, Cold, Normal, Window,Other;
        public double Value;

        public Cell(int side)
        {
            Side = side;
            Block=false;
            Heat=false;
            Cold=false;
            Other = false;
            Normal = true;
            Window = false;
        }
    }
}
