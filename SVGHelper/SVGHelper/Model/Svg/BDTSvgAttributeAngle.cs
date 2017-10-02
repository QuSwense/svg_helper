using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG/types.html#BasicDataTypes"/>
    /// When an <angle> is used in an SVG presentation attribute, the syntax must match the following pattern:
    /// angle ::= number ("deg" | "grad" | "rad")?
    /// The unit identifier, if present, must be in lower case; if not present, the angle value is assumed to be in degrees.
    /// </summary>
    public class BDTSvgAttributeAngle
    {
        /// <summary>
        /// A data type which follows the sytax defined in
        /// <see href="https://www.w3.org/TR/SVG/types.html#DataTypeNumber"/>
        /// Regex to validate a float/decimal 
        /// integer ([Ee] integer)? | [+-]?[0 - 9]* "." [0-9]+ ([Ee] integer)?
        /// integer ::= [+-]? [0-9]+
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// The unit identifier, if present, must be in lower case; if not present, the angle value is assumed to be in degrees.
        /// </summary>
        public EBDTAngleUnit AngleType { get; set; }
    }
}
