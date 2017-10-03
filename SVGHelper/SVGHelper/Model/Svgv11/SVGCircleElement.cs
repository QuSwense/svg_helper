using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGCircleElement interface corresponds to the ‘circle’ element.
    /// <see href="https://www.w3.org/TR/SVG/shapes.html#InterfaceSVGCircleElement"/>
    /// </summary>
    public interface SVGCircleElement : SVGElement, SVGTests, SVGLangSpace,
        SVGExternalResourcesRequired, SVGStylable, SVGTransformable
    {
        /// <summary>
        /// Corresponds to attribute ‘cx’ on the given ‘circle’ element.
        /// </summary>
        SVGAnimatedLength Cx { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘cy’ on the given ‘circle’ element.
        /// </summary>
        SVGAnimatedLength Cy { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘r’ on the given ‘circle’ element.
        /// </summary>
        SVGAnimatedLength R { get; set; }
    }
}
