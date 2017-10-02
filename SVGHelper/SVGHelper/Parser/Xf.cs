using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Parser
{
    struct Xf
    {
        float m0, m1, m2, m3, m4, m5;

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return m0;
                    case 1:
                        return m1;
                    case 2:
                        return m2;
                    case 3:
                        return m3;
                    case 4:
                        return m4;
                    case 5:
                        return m5;
                    default:
                        throw new System.IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        m0 = value;
                        break;
                    case 1:
                        m1 = value;
                        break;
                    case 2:
                        m2 = value;
                        break;
                    case 3:
                        m3 = value;
                        break;
                    case 4:
                        m4 = value;
                        break;
                    case 5:
                        m5 = value;
                        break;
                    default:
                        throw new System.IndexOutOfRangeException();
                }
            }
        }
    }
}
