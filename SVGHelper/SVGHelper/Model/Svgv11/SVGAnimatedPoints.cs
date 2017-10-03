using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGAnimatedPoints interface supports elements which have a ‘points’ attribute
    /// which holds a list of coordinate values and which support the ability to animate that attribute.
    /// </summary>
    public interface SVGAnimatedPoints
    {
        /// <summary>
        /// Provides access to the base (i.e., static) contents of the ‘points’ attribute.
        /// </summary>
        List<SVGPoint> Points { get; set; }

        /// <summary>
        /// Provides access to the current animated contents of the ‘points’ attribute.
        /// </summary>
        List<SVGPoint> AnimatedPoints { get; set; }
    }
}
