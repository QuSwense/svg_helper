using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The interface corresponds to an SVG View Specification.
    /// </summary>
    public interface SVGViewSpec : SVGZoomAndPan, SVGFitToViewBox
    {
        /// <summary>
        /// Corresponds to the transform setting on the SVG View Specification.
        /// </summary>
        List<SVGTransform> Transform { get; set; }

        /// <summary>
        /// Corresponds to the viewTarget setting on the SVG View Specification.
        /// </summary>
        SVGElement ViewTarget { get; set; }

        /// <summary>
        /// Corresponds to the viewBox setting on the SVG View Specification.
        /// </summary>
        string ViewBoxString { get; set; }

        /// <summary>
        /// Corresponds to the preserveAspectRatio setting on the SVG View Specification.
        /// </summary>
        string PreserveAspectRatioString { get; set; }

        /// <summary>
        /// Corresponds to the transform setting on the SVG View Specification.
        /// </summary>
        string TransformString { get; set; }

        /// <summary>
        /// Corresponds to the viewTarget setting on the SVG View Specification.
        /// </summary>
        string ViewTargetString { get; set; }
    }
}
