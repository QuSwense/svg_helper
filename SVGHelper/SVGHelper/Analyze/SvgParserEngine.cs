using SVGHelper.Model.Svg;
using SVGHelper.Model.Svgv11;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SVGHelper.Analyze
{
    /// <summary>
    /// The SVG parser is based on Anti-Grain Geometry 2.4 SVG example <see href="http://www.antigrain.com/doc/index.html"/>
    /// The code logic is taken from <see href="https://github.com/thinksquirrel/nanosvg-csharp/blob/master/NanoSvg.cs"/>
    /// </summary>
    public class SvgParserEngine
    {
        /// <summary>
        /// The whole Svg file content in this object
        /// </summary>
        public SVGSVGElementImpl SvgRoot { get; set; }

        /// <summary>
        /// The svg file reader
        /// </summary>
        private XDocument svgFile;

        /// <summary>
        /// Constructor to initialize the Parser engine object
        /// </summary>
        /// <param name="fullFilePath"></param>
        public SvgParserEngine(string fullFilePath)
        {
            svgFile = new XDocument(fullFilePath);

            if (svgFile == null)
                throw new Exception("Svg File not found");
        }

        /// <summary>
        /// Public method to parse file
        /// </summary>
        public void Parse()
        {
            Initialize();
            ParseXml();
        }

        /// <summary>
        /// Initialize data objects before Parsing
        /// </summary>
        private void Initialize()
        {
            SvgRoot = new SVGSVGElementImpl();
        }

        /// <summary>
        /// The main functio nto start parsing the xml
        /// </summary>
        private void ParseXml()
        {
            foreach (XElement element in svgFile.Elements())
            {
                SwitchElementFactory(element, SvgRoot);
            }
        }

        /// <summary>
        /// This method creates a element node
        /// </summary>
        /// <param name="element"></param>
        private void SwitchElementFactory(XElement element, SVGElement svgElement)
        {
            
        }

        /// <summary>
        /// Parse the whole content of the element tag without the tag
        /// </summary>
        /// <param name="content"></param>
        private void ParseElement(StringStream content)
        {
            
        }

        /// <summary>
        /// The XML Prolog.
        /// The XML prolog is optional. If it exists, it must come first in the document.
        /// </summary>
        /// <param name="content"></param>
        private void ParseXMLProlog(StringStream content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Parse the content when the start of a tag is found
        /// </summary>
        /// <param name="content"></param>
        private void ParseContent(StringStream content)
        {
            // Skip spaces
            svgFile.SkipWhitespaces();
            if (svgFile.IsEof) return;
        }

        /// <summary>
        /// This is the core method to parse a content state type
        /// </summary>
        /// <param name="content"></param>
        private void ParseCoreContent(StringStream content)
        {
            // Not used
        }
    }
}
