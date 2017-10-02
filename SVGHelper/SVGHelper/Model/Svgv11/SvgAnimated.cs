using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    public interface SVGAnimated<T>
    {
        /// <summary>
        /// The base value of the given attribute before applying any animations.
        /// </summary>
        T BaseVal { get; set; }

        /// <summary>
        /// If the given attribute or property is being animated, contains the current
        /// animated value of the attribute or property
        /// </summary>
        T AnimVal { get; set; }
    }
}
