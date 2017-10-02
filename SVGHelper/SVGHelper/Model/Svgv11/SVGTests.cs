using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// An interface which applies to all elements which have attributes 
    /// ‘requiredFeatures’, ‘requiredExtensions’ and ‘systemLanguage’.
    /// </summary>
    public interface SVGTests
    {
        /// <summary>
        /// Corresponds to attribute ‘requiredFeatures’ on the given element.
        /// </summary>
        List<string> RequiredFeatures { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘requiredExtensions’ on the given element.
        /// </summary>
        List<string> RequiredExtensions { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘systemLanguage’ on the given element.
        /// </summary>
        List<string> SystemLanguage { get; set; }
    }
}
