using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Parser
{
    struct FixedFloatArray10
    {
        float f0, f1, f2, f3, f4, f5, f6, f7, f8, f9;

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
                    case 2:
                        return f2;
                    case 3:
                        return f3;
                    case 4:
                        return f4;
                    case 5:
                        return f5;
                    case 6:
                        return f6;
                    case 7:
                        return f7;
                    case 8:
                        return f8;
                    case 9:
                        return f9;
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
                    case 2:
                        f2 = value;
                        break;
                    case 3:
                        f3 = value;
                        break;
                    case 4:
                        f4 = value;
                        break;
                    case 5:
                        f5 = value;
                        break;
                    case 6:
                        f6 = value;
                        break;
                    case 7:
                        f7 = value;
                        break;
                    case 8:
                        f8 = value;
                        break;
                    case 9:
                        f9 = value;
                        break;
                    default:
                        throw new System.IndexOutOfRangeException();
                }
            }
        }
    }
}
