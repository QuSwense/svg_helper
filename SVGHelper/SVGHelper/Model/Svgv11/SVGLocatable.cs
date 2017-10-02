using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// For all elements which either have a ‘transform’ attribute or don't have a
    /// ‘transform’ attribute but whose content can have a bounding box in current user space.
    /// </summary>
    public interface SVGLocatable
    {
        /// <summary>
        /// The element which established the current viewport. Often, the nearest ancestor
        /// ‘svg’ element. Null if the current element is the outermost svg element.
        /// </summary>
        SVGElement NearestViewportElement { get; set; }

        /// <summary>
        /// The farthest ancestor ‘svg’ element. Null if the current element is the outermost svg element.
        /// </summary>
        SVGElement FarthestViewportElement { get; set; }
    }
}
