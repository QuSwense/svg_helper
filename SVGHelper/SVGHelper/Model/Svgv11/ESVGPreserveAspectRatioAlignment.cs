using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Corresponds to the ‘preserveAspectRatio’ attribute, which is available for some of SVG's elements.
    /// </summary>
    public enum ESVGPreserveAspectRatioAlignment
    {
        /// <summary>
        /// The enumeration was set to a value that is not one of predefined types.
        /// It is invalid to attempt to define a new value of this type or to attempt
        /// to switch an existing value to this type.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// Corresponds to value 'none' for attribute ‘preserveAspectRatio’.
        /// </summary>
        NONE,

        /// <summary>
        /// Corresponds to value 'xMinYMin' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMINYMIN,

        /// <summary>
        /// Corresponds to value 'xMidYMin' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMIDYMIN,

        /// <summary>
        /// Corresponds to value 'xMaxYMin' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMAXYMIN,

        /// <summary>
        /// Corresponds to value 'XMinYMid' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMINYMID,

        /// <summary>
        /// Corresponds to value 'xMidYMid' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMIDYMID,

        /// <summary>
        /// Corresponds to value 'xMaxYMid' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMAXYMID,

        /// <summary>
        /// Corresponds to value 'xMinYMax' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMINYMAX,

        /// <summary>
        /// Corresponds to value 'xMidYMax' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMIDYMAX,

        /// <summary>
        /// Corresponds to value 'xMaxYMax' for attribute ‘preserveAspectRatio’.
        /// </summary>
        XMAXYMAX
    }
}
