using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGUseElement interface corresponds to the ‘use’ element.
    /// <see href="https://www.w3.org/TR/SVG/struct.html#InterfaceSVGUseElement"/>
    /// </summary>
    public interface SVGUseElement: SVGElement, SVGURIReference, SVGTests, SVGLangSpace,
                          SVGExternalResourcesRequired, SVGStylable, SVGTransformable
    {
    }
}
