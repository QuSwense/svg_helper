using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGSymbolElement interface corresponds to the ‘symbol’ element.
    /// <see href="https://www.w3.org/TR/SVG/struct.html#InterfaceSVGSymbolElement"/>
    /// </summary>
    public interface SVGSymbolElement: SVGElement, SVGLangSpace, SVGExternalResourcesRequired,
                             SVGStylable, SVGFitToViewBox
    {
    }
}
