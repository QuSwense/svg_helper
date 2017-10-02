using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// contains properties and methods that apply to all elements which have attribute ‘transform’.
    /// </summary>
    public interface SVGTransformable : SVGLocatable
    {
        /// <summary>
        /// Corresponds to attribute ‘transform’ on the given element.
        /// </summary>
        SVGAnimatedTransformList Transform { get; set; }
    }
}
