using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGStylable interface is implemented on all objects corresponding to 
    /// SVG elements that can have ‘style’, ‘class’ and presentation attributes specified on them
    /// </summary>
    public interface SVGStylable
    {
        /// <summary>
        /// Corresponds to attribute ‘class’ on the given element.
        /// </summary>
        SVGAnimatedString ClassName { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘style’ on the given element. If the user agent does 
        /// not support styling with CSS, then this attribute must always have the value of null.
        /// </summary>
        string Style { get; set; }
    }
}
