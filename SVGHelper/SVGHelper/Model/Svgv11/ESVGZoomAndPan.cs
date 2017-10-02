using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Interface defines attribute zoomAndPan and associated constants.
    /// </summary>
    public enum ESVGZoomAndPan
    {
        /// <summary>
        /// The enumeration was set to a value that is not one of predefined types.
        /// It is invalid to attempt to define a new value of this type or to attempt
        /// to switch an existing value to this type.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// Corresponds to value 'disable'.
        /// </summary>
        DISABLE,

        /// <summary>
        /// Corresponds to value 'magnify'.
        /// </summary>
        MAGNIFY
    }
}
