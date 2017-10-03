using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGPolygonElement interface corresponds to the ‘polygon’ element.
    /// <see href="https://www.w3.org/TR/SVG/shapes.html#InterfaceSVGPolygonElement"/>
    /// </summary>
    public interface SVGPolygonElement : SVGElement, SVGTests, SVGLangSpace, SVGExternalResourcesRequired,
                               SVGStylable, SVGTransformable, SVGAnimatedPoints
    {
    }
}
