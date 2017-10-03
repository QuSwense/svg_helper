using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// <see cref="https://www.w3.org/TR/SVG/struct.html#InterfaceSVGSVGElement"/>
    /// The interface that corresponds to the ‘svg’ element.
    /// </summary>
    public interface SVGSVGElement : SVGElement, SVGTests, SVGLangSpace, SVGExternalResourcesRequired,
                          SVGStylable, SVGLocatable, SVGFitToViewBox, SVGZoomAndPan
    {
        /// <summary>
        /// Corresponds to attribute ‘x’ on the given ‘svg’ element.
        /// </summary>
        SVGAnimatedLength X { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘y’ on the given ‘svg’ element.
        /// </summary>
        SVGAnimatedLength Y { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘width’ on the given ‘svg’ element.
        /// </summary>
        SVGAnimatedLength Width { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘height’ on the given ‘svg’ element.
        /// </summary>
        SVGAnimatedLength Height { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘contentScriptType’ on the given ‘svg’ element.
        /// </summary>
        string ContentScriptType { get; set; }

        /// <summary>
        /// Corresponds to attribute ‘contentStyleType’ on the given ‘svg’ element.
        /// </summary>
        string contentStyleType { get; set; }

        /// <summary>
        /// The position and size of the viewport (implicit or explicit) that corresponds
        /// to this ‘svg’ element. When the user agent is actually rendering the content,
        /// then the position and size values represent the actual values when rendering.
        /// The position and size values are unitless values in the coordinate system of the parent element.
        /// </summary>
        SVGRect Viewport { get; set; }

        /// <summary>
        /// Size of a pixel units (as defined by CSS2) along the x-axis of the viewport, 
        /// which represents a unit somewhere in the range of 70dpi to 120dpi
        /// </summary>
        float PixelUnitToMillimeterX { get; set; }

        /// <summary>
        /// Corresponding size of a pixel unit along the y-axis of the viewport.
        /// </summary>
        float PixelUnitToMillimeterY { get; set; }

        /// <summary>
        /// User interface (UI) events in DOM Level 2 indicate the screen positions at which
        /// the given UI event occurred.
        /// </summary>
        float ScreenPixelToMillimeterX { get; set; }

        /// <summary>
        /// Corresponding size of a screen pixel along the y-axis of the viewport.
        /// </summary>
        float ScreenPixelToMillimeterY { get; set; }

        /// <summary>
        /// The initial view (i.e., before magnification and panning) of the current innermost
        /// SVG document fragment can be either the "standard" view
        /// </summary>
        bool UseCurrentView { get; set; }

        /// <summary>
        /// The definition of the initial view (i.e., before magnification and panning) of 
        /// the current innermost SVG document fragment.
        /// </summary>
        SVGViewSpec CurrentView { get; set; }

        /// <summary>
        /// On an outermost svg element, this attribute indicates the current scale factor
        /// relative to the initial view to take into account user magnification and panning operations
        /// </summary>
        float CurrentScale { get; set; }

        /// <summary>
        /// On an outermost svg element, the corresponding translation factor that takes into
        /// account user "magnification".
        /// </summary>
        SVGPoint CurrentTranslate { get; set; }
    }
}
