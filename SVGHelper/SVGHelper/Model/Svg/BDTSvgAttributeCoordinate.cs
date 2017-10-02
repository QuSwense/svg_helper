using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG/types.html#BasicDataTypes"/>
    /// A <coordinate> is a length in the user coordinate system that is the given distance 
    /// from the origin of the user coordinate system along the relevant axis (the x-axis 
    /// for X coordinates, the y-axis for Y coordinates). Its syntax is the same as that for <code><length></code>.
    /// </summary>
    public class BDTSvgAttributeCoordinate
    {
        /// <summary>
        /// The syntax must match the following pattern:
        /// length ::= number ("em" | "ex" | "px" | "in" | "cm" | "mm" | "pt" | "pc" | "%")?
        /// The unit identifier, if present, must be in lower case; if not present, 
        /// the length value represents a distance in the current user coordinate system.
        /// </summary>
        public decimal Value { get; set; }

        public EBDTSvgAttributeCoordinateUnit Unit { get; set; }
    }
}
