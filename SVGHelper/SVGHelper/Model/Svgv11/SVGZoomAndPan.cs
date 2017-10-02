using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// The SVGZoomAndPan interface defines attribute zoomAndPan and associated constants.
    /// </summary>
    public interface SVGZoomAndPan
    {
        /// <summary>
        /// Corresponds to attribute ‘zoomAndPan’ on the given element.
        /// </summary>
        ushort ZoomAndPan { get; set; }
    }
}
