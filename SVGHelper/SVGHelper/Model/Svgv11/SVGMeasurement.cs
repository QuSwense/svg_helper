using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    public interface SVGMeasurement<ET>
    {
        /// <summary>
        /// The type of the value as specified by one of the SVG_LENGTHTYPE_* constants
        /// defined on this interface.
        /// </summary>
        ET UnitType { get; set; }

        /// <summary>
        /// The value as a floating point value, in user units. Setting this attribute
        /// will cause valueInSpecifiedUnits and valueAsString to be updated automatically 
        /// to reflect this setting.
        /// </summary>
        float Value { get; set; }

        /// <summary>
        /// The value as a floating point value, in the units expressed by <see cref="UnitType"/>
        /// Setting this attribute will cause <see cref="Value"/> and <see cref="ValueAsString"/> to be
        /// updated automatically to reflect this setting.
        /// </summary>
        float ValueInSpecifiedUnits { get; set; }

        /// <summary>
        /// The value as a string value, in the units expressed by <see cref="UnitType"/>. Setting 
        /// this attribute will cause <see cref="Value"/>, <see cref="ValueInSpecifiedUnits"/> and 
        /// <see cref="UnitType"/>to be updated automatically to reflect this setting.
        /// </summary>
        string ValueAsString { get; set; }
    }
}
