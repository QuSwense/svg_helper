using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG/types.html#BasicDataTypes"/>
    /// Within the SVG DOM, a <coordinate> is represented as an SVGLength or an SVGAnimatedLength.
    /// For properties defined in CSS2 [CSS2], a length unit identifier must be provided (for non-zero values).
    /// </summary>
    public class BDTCssAttributeCoordinate
    {
        /// <summary>
        /// Follows the pattern:
        /// length ::= number (~"em" | ~"ex" | ~"px" | ~"in" | ~"cm" | ~"mm" | ~"pt" | ~"pc")?
        /// </summary>
        public decimal Value { get; set; }

        public EBDTSvgAttributeCoordinateUnit Unit { get; set; }
    }
}
