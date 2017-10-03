using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    public class SVGSVGElementImpl : SVGSVGElement
    {
        public SVGAnimatedLength X { get; set; }
        public SVGAnimatedLength Y { get; set; }
        public SVGAnimatedLength Width { get; set; }
        public SVGAnimatedLength Height { get; set; }
        public string ContentScriptType { get; set; }
        public string contentStyleType { get; set; }
        public SVGRect Viewport { get; set; }
        public float PixelUnitToMillimeterX { get; set; }
        public float PixelUnitToMillimeterY { get; set; }
        public float ScreenPixelToMillimeterX { get; set; }
        public float ScreenPixelToMillimeterY { get; set; }
        public bool UseCurrentView { get; set; }
        public SVGViewSpec CurrentView { get; set; }
        public float CurrentScale { get; set; }
        public SVGPoint CurrentTranslate { get; set; }
        public AttributeId Id { get; set; }
        public AttributeXmlBase XmlBase { get; set; }
        public SVGElement OwnerSVGElement { get; set; }
        public SVGElement ViewportElement { get; set; }
        public List<string> RequiredFeatures { get; set; }
        public List<string> RequiredExtensions { get; set; }
        public List<string> SystemLanguage { get; set; }
        public string XmlLang { get; set; }
        public string XmlSpace { get; set; }
        public SVGAnimatedBoolean ExternalResourcesRequired { get; set; }
        public SVGAnimatedString ClassName { get; set; }
        public string Style { get; set; }
        public SVGElement NearestViewportElement { get; set; }
        public SVGElement FarthestViewportElement { get; set; }
        public SVGAnimatedRect ViewBox { get; set; }
        public ushort ZoomAndPan { get; set; }
    }
}
