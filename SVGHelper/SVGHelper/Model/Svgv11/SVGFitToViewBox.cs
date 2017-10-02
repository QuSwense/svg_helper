using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Defines DOM attributes that apply to elements which have XML attributes ‘viewBox’
    /// and ‘preserveAspectRatio’.
    /// </summary>
    public interface SVGFitToViewBox
    {
        /// <summary>
        /// Corresponds to attribute ‘viewBox’ on the given element.
        /// </summary>
        SVGAnimatedRect ViewBox { get; set; }
    }
}
