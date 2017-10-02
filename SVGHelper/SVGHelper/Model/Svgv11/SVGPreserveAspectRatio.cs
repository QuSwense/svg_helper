using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGPreserveAspectRatio interface corresponds to the ‘preserveAspectRatio’
    /// attribute, which is available for some of SVG's elements.
    /// </summary>
    public class SVGPreserveAspectRatio
    {
        ESVGPreserveAspectRatioAlignment AlignmentType { get; set; }
        ESVGPreserveAspectRatioMeetOrSliceType MeetOrSliceType { get; set; }

        /// <summary>
        /// The type of the alignment value as specified by one of the 
        /// SVG_PRESERVEASPECTRATIO_* constants defined on this interface.
        /// </summary>
        ushort Align { get; set; }

        /// <summary>
        /// The type of the meet-or-slice value as specified by one of the 
        /// SVG_MEETORSLICE_* constants defined on this interface.
        /// </summary>
        ushort MeetOrSlice { get; set; }
    }
}
