using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGImageElement interface corresponds to the ‘image’ element.
    /// <see href="https://www.w3.org/TR/SVG/struct.html#InterfaceSVGImageElement"/>
    /// </summary>
    public interface SVGImageElement : SVGElement, SVGURIReference, SVGTests, SVGLangSpace,
                            SVGExternalResourcesRequired, SVGStylable, SVGTransformable
    {
        /// <summary>
        /// Corresponds to attribute ‘x’ on the given ‘image’ element.
        /// </summary>
        SVGAnimatedLength X { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘y’ on the given ‘image’ element.
        /// </summary>
        SVGAnimatedLength Y { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘width’ on the given ‘image’ element.
        /// </summary>
        SVGAnimatedLength Width { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘height’ on the given ‘image’ element.
        /// </summary>
        SVGAnimatedLength Height { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘preserveAspectRatio’ on the given ‘image’ element.
        /// </summary>
        SVGAnimatedPreserveAspectRatio PreserveAspectRatio { get; set; }
    }
}
