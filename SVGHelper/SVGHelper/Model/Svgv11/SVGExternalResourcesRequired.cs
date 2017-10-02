using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// An interface which applies to all elements where this element or one of its
    /// descendants can reference an external resource.
    /// </summary>
    public interface SVGExternalResourcesRequired
    {
        /// <summary>
        /// Corresponds to attribute ‘externalResourcesRequired’ on the given element.
        /// Note that the SVG DOM defines the attribute ‘externalResourcesRequired’ as
        /// being of type SVGAnimatedBoolean, whereas the SVG language definition says
        /// that ‘externalResourcesRequired’ is not animated. Because the SVG language
        /// definition states that ‘externalResourcesRequired’ cannot be animated, the
        /// animVal will always be the same as the baseVal.
        /// </summary>
        SVGAnimatedBoolean ExternalResourcesRequired { get; set; }
    }
}
