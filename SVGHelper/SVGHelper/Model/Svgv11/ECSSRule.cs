using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Indicating which type of rule this is
    /// </summary>
    public enum ECSSRule
    {
        UNKNOWN,
        STYLE,
        CHARSET,
        IMPORT,
        MEDIA,
        FONT_FACE,
        PAGE
    }
}
