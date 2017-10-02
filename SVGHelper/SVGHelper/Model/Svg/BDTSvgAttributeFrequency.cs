using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// Frequency values are used with aural properties. As defined in CSS2, 
    /// a frequency value is a <number> immediately followed by a frequency unit identifier.
    /// Frequency values may not be negative.
    /// </summary>
    public class BDTSvgAttributeFrequency
    {
        public decimal Value { get; set; }
        public EBDTSvgAttributeFrequencyUnit Unit { get; set; }
    }
}
