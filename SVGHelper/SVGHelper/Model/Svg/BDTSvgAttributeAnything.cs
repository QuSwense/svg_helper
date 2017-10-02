using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG/types.html#BasicDataTypes"/>
    /// The basic type <anything> is a sequence of zero or more characters.
    /// anything ::= Char*
    /// </summary>
    public class BDTSvgAttributeAnything
    {
        public string Value { get; set; }
    }
}
