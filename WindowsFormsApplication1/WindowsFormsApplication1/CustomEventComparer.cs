using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CustomEventComparer: IComparer<CustomEvent>
    {
        public int Compare(CustomEvent x, CustomEvent y)
        {
            if (x.getPriority() == 0 && y.getPriority() == 0) return 0;
            else if (x.getPriority() == 0) return -1;
            else if (y.getPriority() == 0) return 1;
            else if (x.getPriority() < y.getPriority()) { return -1; }
            else return 1;
        }
    }
}
