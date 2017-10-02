using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Parser
{
    public struct FixedFloatArray2
    {
        float f0, f1;

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return f0;
                    case 1:
                        return f1;
                    default:
                        throw new System.IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        f0 = value;
                        break;
                    case 1:
                        f1 = value;
                        break;
                    default:
                        throw new System.IndexOutOfRangeException();
                }
            }
        }
    }
}
