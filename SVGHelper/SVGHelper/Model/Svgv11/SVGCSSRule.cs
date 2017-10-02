using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// SVG extends interface CSSRule with interface SVGCSSRule by adding an 
    /// SVGColorProfileRule rule to allow for specification of ICC-based color.
    /// </summary>
    public interface SVGCSSRule : CSSRule
    {
        const ushort COLOR_PROFILE_RULE = 7;
    }
}
