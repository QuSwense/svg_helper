using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGRenderingIntent interface defines the enumerated list of possible 
    /// values for ‘rendering-intent’ attributes or descriptors.
    /// </summary>
    public enum ESVGRenderingIntent
    {
        /// <summary>
        /// The type is not one of predefined types. It is invalid to attempt to
        /// define a new value of this type or to attempt to switch an existing value to this type.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// Corresponds to a value of 'auto'.
        /// </summary>
        AUTO,

        /// <summary>
        /// Corresponds to a value of 'perceptual'.
        /// </summary>
        PERCEPTUAL,

        /// <summary>
        /// Corresponds to a value of 'relative-colorimetric'.
        /// </summary>
        RELATIVE_COLORIMETRIC,

        /// <summary>
        /// Corresponds to a value of 'saturation'.
        /// </summary>
        SATURATION,

        /// <summary>
        /// Corresponds to a value of 'absolute-colorimetric'.
        /// </summary>
        ABSOLUTE_COLORIMETRIC
    }
}
