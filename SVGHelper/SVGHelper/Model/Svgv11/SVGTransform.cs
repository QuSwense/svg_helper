using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The interface for one of the component transformations. Corresponds to a single component
    /// (e.g., 'scale(…)' or 'matrix(…)') within a ‘transform’ attribute specification.
    /// </summary>
    public interface SVGTransform
    {
        /// <summary>
        /// The type of the value as specified by one of the SVG_TRANSFORM_* constants defined on
        /// this interface.
        /// </summary>
        ESVGTransform UnitType { get; set; }

        /// <summary>
        /// The matrix that represents this transformation. The matrix object is live, 
        /// meaning that any changes made to the SVGTransform object are immediately reflected in 
        /// the matrix object and vice versa.
        /// </summary>
        SVGMatrix Matrix { get; set; }

        /// <summary>
        /// A convenience attribute for SVG_TRANSFORM_ROTATE, SVG_TRANSFORM_SKEWX and 
        /// SVG_TRANSFORM_SKEWY. It holds the angle that was specified.
        /// </summary>
        float Angle { get; set; }
    }
}
