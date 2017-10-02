using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// All of the SVG DOM interfaces that correspond directly to elements in the SVG language
    /// </summary>
    public interface SVGElement
    {
        /// <summary>
        /// The value of the ‘id’ attribute on the given element, 
        /// or the empty string if ‘id’ is not present.
        /// </summary>
        AttributeId Id { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘xml:base’ on the given element.
        /// </summary>
        AttributeXmlBase XmlBase { get; set; }

        /// <summary>
        /// The nearest ancestor ‘svg’ element. Null if the given element is the outermost svg element.
        /// </summary>
        SVGElement OwnerSVGElement { get; set; }

        /// <summary>
        /// The element which established the current viewport. Often, the nearest ancestor ‘svg’ element.
        /// Null if the given element is the outermost svg element.
        /// </summary>
        SVGElement ViewportElement { get; set; }
    }
}
