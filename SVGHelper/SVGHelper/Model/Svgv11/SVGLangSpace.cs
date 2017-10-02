using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// An interface which applies to all elements which have attributes ‘xml:lang’ and ‘xml:space’.
    /// </summary>
    public interface SVGLangSpace
    {
        /// <summary>
        /// Corresponds to attribute ‘xml:lang’ on the given element.
        /// </summary>
        string XmlLang { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘xml:space’ on the given element.
        /// </summary>
        string XmlSpace { get; set; }
    }
}
