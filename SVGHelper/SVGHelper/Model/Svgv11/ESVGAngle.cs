using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    public enum ESVGAngle
    {
        /// <summary>
        /// The unit type is not one of predefined unit types. It is invalid to
        /// attempt to define a new value of this type or to attempt to switch 
        /// an existing value to this type.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// No unit type was provided (i.e., a unitless value was specified). 
        /// For angles, a unitless value is treated the same as if degrees were specified.
        /// </summary>
        UNSPECIFIED,

        /// <summary>
        /// The unit type was explicitly set to degrees.
        /// </summary>
        DEG,

        /// <summary>
        /// The unit type is radians.
        /// </summary>
        RAD,

        /// <summary>
        /// The unit type is radians.
        /// </summary>
        GRAD
    }
}
