using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.CSS
{
    /// <summary>
    /// The CSSRule interface is the abstract base interface for any type of CSS statement.
    /// </summary>
    public interface CSSRule
    {
        /// <summary>
        /// The type of the rule, as defined above.
        /// </summary>
        ECSSRule Type { get; set; }

        /// <summary>
        /// The parsable textual representation of the rule. This reflects the current 
        /// state of the rule and not its initial value.
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// If this rule is contained inside another rule (e.g. a style rule inside an @media
        /// block), this is the containing rule. If this rule is not nested inside any other
        /// rules, this returns null.
        /// </summary>
        CSSRule ParentRule { get; set; }

        /// <summary>
        /// The style sheet that contains this rule.
        /// </summary>
        CSSStyleSheet ParentStylesheet { get; set; }
    }
}
