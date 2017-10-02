using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Used for the various attributes which specify a set of transformations, 
    /// such as the ‘transform’ attribute which is available for many of SVG's elements,
    /// and which can be animated.
    /// </summary>
    public interface SVGAnimatedTransformList : SVGAnimated<List<SVGTransform>>
    {
    }
}
