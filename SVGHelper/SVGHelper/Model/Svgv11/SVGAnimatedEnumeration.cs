using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Used for attributes whose value must be a constant from a particular enumeration 
    /// and which can be animated.
    /// </summary>
    public interface SVGAnimatedEnumeration : SVGAnimated<uint>
    {
    }
}
