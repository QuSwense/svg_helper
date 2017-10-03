using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGLineElement interface corresponds to the ‘line’ element.
    /// <see href="https://www.w3.org/TR/SVG/shapes.html#InterfaceSVGLineElement"/>
    /// </summary>
    public interface SVGLineElement
    {
        /// <summary>
        /// Corresponds to attribute ‘x1’ on the given ‘line’ element.
        /// </summary>
        SVGAnimatedLength X1 { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘y1’ on the given ‘line’ element.
        /// </summary>
        SVGAnimatedLength Y1 { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘x2’ on the given ‘line’ element.
        /// </summary>
        SVGAnimatedLength X2 { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘y2’ on the given ‘line’ element.
        /// </summary>
        SVGAnimatedLength Y2 { get; set; }
    }
}
