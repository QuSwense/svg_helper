using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGEllipseElement interface corresponds to the ‘ellipse’ element.
    /// <see href="https://www.w3.org/TR/SVG/shapes.html#InterfaceSVGEllipseElement"/>
    /// </summary>
    public interface SVGEllipseElement
    {
        /// <summary>
        /// Corresponds to attribute ‘cx’ on the given ‘ellipse’ element.
        /// </summary>
        SVGAnimatedLength Cx { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘cy’ on the given ‘ellipse’ element.
        /// </summary>
        SVGAnimatedLength Cy { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘rx’ on the given ‘ellipse’ element.
        /// </summary>
        SVGAnimatedLength Rx { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘ry’ on the given ‘ellipse’ element.
        /// </summary>
        SVGAnimatedLength Ry { get; set; }
    }
}
