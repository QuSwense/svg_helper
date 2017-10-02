using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    public enum ESVGTransform
    {
        /// <summary>
        /// The unit type is not one of predefined types. It is invalid to attempt
        /// to define a new value of this type or to attempt to switch an existing
        /// value to this type.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// A 'matrix(…)' transformation.
        /// </summary>
        MATRIX,

        /// <summary>
        /// A 'translate(…)' transformation.
        /// </summary>
        TRANSLATE,

        /// <summary>
        /// A 'scale(…)' transformation.
        /// </summary>
        SCALE,

        /// <summary>
        /// A 'rotate(…)' transformation
        /// </summary>
        ROTATE,

        /// <summary>
        /// A 'skewX(…)' transformation.
        /// </summary>
        SKEWX,

        /// <summary>
        /// A 'skewY(…)' transformation.
        /// </summary>
        SKEWY
    }
}
