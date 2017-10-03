using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGPolylineElement interface corresponds to the ‘polyline’ element.
    /// <see href="https://www.w3.org/TR/SVG/shapes.html#InterfaceSVGPolylineElement"/>
    /// </summary>
    public interface SVGPolylineElement : SVGElement, SVGTests, SVGLangSpace, SVGExternalResourcesRequired,
                               SVGStylable, SVGTransformable, SVGAnimatedPoints
    {
    }
}
