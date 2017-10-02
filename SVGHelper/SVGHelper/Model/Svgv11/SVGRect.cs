using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Represents rectangular geometry. Rectangles are defined as consisting of a (x,y)
    /// coordinate pair identifying a minimum X value, a minimum Y value, and a width and
    /// height, which are usually constrained to be non-negative.
    /// </summary>
    public interface SVGRect
    {
        /// <summary>
        /// The x coordinate of the rectangle, in user units.
        /// </summary>
        float X { get; set; }

        /// <summary>
        /// The y coordinate of the rectangle, in user units.
        /// </summary>
        float Y { get; set; }

        /// <summary>
        /// The width coordinate of the rectangle, in user units.
        /// </summary>
        float Width { get; set; }

        /// <summary>
        /// The height coordinate of the rectangle, in user units.
        /// </summary>
        float Height { get; set; }
    }
}
