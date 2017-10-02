using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// An interface which applies to all elements which have the collection of XLink
    /// attributes, such as ‘xlink:href’, which define a URI reference.
    /// </summary>
    public interface SVGURIReference
    {
        /// <summary>
        /// Corresponds to attribute ‘xlink:href’ on the given element.
        /// </summary>
        SVGAnimatedString Href { get; set; }
    }
}
