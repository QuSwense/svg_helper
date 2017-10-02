using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGColor interface corresponds to color value definition for properties ‘stop-color’,
    /// ‘flood-color’ and ‘lighting-color’, Interface SVGColor does not correspond to the <color> basic data type.
    /// The SVGColor interface is deprecated, and may be dropped from future versions of the SVG specification.
    /// </summary>
    public interface SVGColor
    {
        /// <summary>
        /// The type of the value as specified by one of the SVG_COLORTYPE_* constants defined on this interface.
        /// </summary>
        ESVGColor UnitType { get; set; }

        /// <summary>
        /// The color specified in the sRGB color space.
        /// </summary>
        Color RgbColor { get; set; }

        /// <summary>
        /// The alternate ICC color specification.
        /// </summary>
        SVGICCColor IccColor { get; set; }
    }
}
