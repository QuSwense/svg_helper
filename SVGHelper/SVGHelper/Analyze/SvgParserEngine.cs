using SVGHelper.Model.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public SvgImage Image { get; set; }

        /// <summary>
        /// The svg file reader
        /// </summary>
        private SvgFileReader svgFile;

        /// <summary>
        /// Constructor to initialize the Parser engine object
        /// </summary>
        /// <param name="fullFilePath"></param>
        public SvgParserEngine(string fullFilePath)
        {
            svgFile = new SvgFileReader(fullFilePath);

            if (svgFile == null)
                throw new Exception("Svg File not found");

            if (svgFile.Length <= 0)
                throw new Exception("Svg file is of Zero size");
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
            Image = new SvgImage();
        }

        /// <summary>
        /// The main functio nto start parsing the xml
        /// </summary>
        private void ParseXml()
        {
            ESvgParserState state = ESvgParserState.NSVG_XML_CONTENT;
            StringStream content = new StringStream();

            while(!svgFile.IsEof)
            {
                if(svgFile.CurrentChar == '<' && state == ESvgParserState.NSVG_XML_CONTENT)
                {
                    // Start of a tag
                    ParseContent(content);
                    content.Clear();
                    state = ESvgParserState.NSVG_XML_TAG;
                }
                else if(svgFile.CurrentChar == '>' && state == ESvgParserState.NSVG_XML_TAG)
                {
                    ParseElement(content);
                    content.Clear();
                    state = ESvgParserState.NSVG_XML_CONTENT;
                }
                else
                {
                    content.Append(svgFile.CurrentChar);
                }

                svgFile.SeekNext();
            }
        }

        /// <summary>
        /// Parse the whole content of the element tag without the tag
        /// </summary>
        /// <param name="content"></param>
        private void ParseElement(StringStream content)
        {
            // Temporary storage for attributes after parsing
            List<string> attributes = new List<string>();
            ESvgTagType tagType = ESvgTagType.NONE;

            // Skip white space after the '<'
            content.SkipWhitespaces();

            // Check if the tag is end tag
            if(content.CurrentChar == '/')
            {
                tagType = ESvgTagType.END;
                svgFile.SeekNext();
            }
            else
            {
                tagType = ESvgTagType.START;
            }

            // Skip comments, data and preprocessor stuff.
            if (content.CurrentChar == '?')
            {
                ParseXMLProlog(content);
            }
            else if(content.CurrentChar == '!') return;
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
