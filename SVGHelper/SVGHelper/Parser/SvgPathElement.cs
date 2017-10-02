using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Parser
{
    /// <summary>
    /// The Svg Path element implemented as a linked list
    /// </summary>
    public class SvgPathElement
    {
        public string id;
        public float[] pts;
        public int npts;
        public uint fillColor;
        public uint strokeColor;
        public float strokeWidth;
        public bool hasFill;
        public bool hasStroke;
        public bool closed;
        public SvgPathElement next;
    }
}
