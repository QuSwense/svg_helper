using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG/types.html#BasicDataTypes"/>
    /// The basic type <color> is a CSS2 compatible specification for a color in the 
    /// sRGB color space [SRGB]. <color> applies to SVG's use of the ‘color’ property 
    /// and is a component of the definitions of properties ‘fill’, ‘stroke’, ‘stop-color’,
    /// ‘flood-color’ and ‘lighting-color’, which also offer optional ICC-based color specifications.
    /// A <color> is either a keyword or a numerical RGB specification.
    /// Either <see cref="Value"/> or <see cref="ColorKeyword"/> is valid not both.
    /// color-keyword matches (case insensitively)
    /// </summary>
    public class BDTSvgAttributeColor
    {
        /// <summary>
        /// A value defined as:
        /// color :=  hexdigit hexdigit hexdigit (hexdigit hexdigit hexdigit)?
        ///         | "rgb(" wsp* integer comma integer comma integer wsp* ")"
        ///         | "rgb(" wsp* integer "%" comma integer "%" comma integer "%" wsp* ")"
        /// hexdigit ::= [0-9A-Fa-f]
        /// wsp := Whitespace
        /// comma    ::= wsp* "," wsp*
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// A keyword as specified by the system / spec
        /// </summary>
        public EBDTSvgAttributeColor ColorKeyword { get; set; }
    }
}
