using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGICCColor interface expresses an ICC-based color specification.
    /// Note: The SVGICCColor interface is deprecated, and may be dropped from future 
    /// versions of the SVG specification.
    /// </summary>
    public interface SVGICCColor
    {
        /// <summary>
        /// The name of the color profile, which is the first parameter of an ICC color
        /// specification.
        /// </summary>
        string ColorProfile { get; set; }

        /// <summary>
        /// The list of color values that define this ICC color. Each color value is
        /// an arbitrary floating point number.
        /// </summary>
        List<SVGNumber> Colors { get; set; }
    }
}
