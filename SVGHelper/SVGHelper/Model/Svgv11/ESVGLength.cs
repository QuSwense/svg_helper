using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    public enum ESVGLength
    {
        /// <summary>
        /// The unit type is not one of predefined unit types. It is invalid to attempt to
        /// define a new value of this type or to attempt to switch an existing value to this type.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// No unit type was provided (i.e., a unitless value was specified), which indicates a value in user units.
        /// </summary>
        NUMBER,

        /// <summary>
        /// A percentage value was specified.
        /// </summary>
        PERCENTAGE,

        /// <summary>
        /// A value was specified using the em units defined in CSS2.
        /// </summary>
        EMS,

        /// <summary>
        /// A value was specified using the ex units defined in CSS2.
        /// </summary>
        EXS,

        /// <summary>
        /// A value was specified using the px units defined in CSS2.
        /// </summary>
        PX,

        /// <summary>
        /// A value was specified using the cm units defined in CSS2.
        /// </summary>
        CM,

        /// <summary>
        /// A value was specified using the mm units defined in CSS2.
        /// </summary>
        MM,

        /// <summary>
        /// A value was specified using the in units defined in CSS2.
        /// </summary>
        IN,

        /// <summary>
        /// A value was specified using the pt units defined in CSS2.
        /// </summary>
        PT,

        /// <summary>
        /// A value was specified using the pc units defined in CSS2.
        /// </summary>
        PC
    }
}
