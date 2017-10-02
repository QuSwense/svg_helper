using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG/types.html#BasicDataTypes"/>
    /// When an <angle> is used a property in a ‘style’ attribute, the syntax must match the following pattern:
    /// angle ::= number (~"deg" | ~"grad" | ~"rad")?
    /// deg indicates degrees, grad indicates grads and rad indicates radians. 
    /// The unit identifier may be in lower (recommended) or upper case.
    /// </summary>
    public class BDTCssAttributeAngle
    {
        /// <summary>
        /// A data type which follows the sytax defined in
        /// <see href="https://www.w3.org/TR/SVG/types.html#DataTypeNumber"/>
        /// Regex to validate a float/decimal 
        /// [+-]? [0-9]+ | [+-]? [0-9]* "." [0-9]+
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// For properties defined in CSS2 [CSS2], an angle unit identifier must be provided (for non-zero values)
        /// </summary>
        public EBDTAngleUnit AngleType { get; set; }
    }
}
