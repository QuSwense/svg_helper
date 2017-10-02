using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Used for attributes of basic type <number>.
    /// </summary>
    public interface SVGNumber
    {
        /// <summary>
        /// The value of the given attribute
        /// </summary>
        float Value { get; set; }
    }
}
