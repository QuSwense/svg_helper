using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The CSSStyleSheet interface is a concrete interface used to represent a 
    /// CSS style sheet i.e., a style sheet whose content type is "text/css".
    /// </summary>
    public interface CSSStyleSheet
    {
        /// <summary>
        /// If this style sheet comes from an @import rule, the ownerRule attribute
        /// will contain the CSSImportRule
        /// </summary>
        CSSRule OwnerRule { get; set; }

        /// <summary>
        /// The list of all CSS rules contained within the style sheet.
        /// </summary>
        List<CSSRule> CssRules { get; set; }
    }
}
