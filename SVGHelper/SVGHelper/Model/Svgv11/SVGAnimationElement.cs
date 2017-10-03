using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG/animate.html#InterfaceSVGAnimationElement"/>
    /// The base interface for all of the animation element interfaces: SVGAnimateElement,
    /// SVGSetElement, SVGAnimateColorElement, SVGAnimateMotionElement and SVGAnimateTransformElement.
    /// </summary>
    public interface SVGAnimationElement : SVGElement, SVGTests, SVGExternalResourcesRequired,
                                ElementTimeControl
    {
        /// <summary>
        /// The element which is being animated.
        /// </summary>
        SVGElement TargetElement { get; set; }
    }
}
