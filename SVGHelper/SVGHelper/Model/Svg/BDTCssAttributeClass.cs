using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// This attribute assigns a class name or set of class names to an element.
    /// class = list
    /// </summary>
    public class BDTCssAttributeClass
    {
        public List<string> Names { get; set; }
    }
}
