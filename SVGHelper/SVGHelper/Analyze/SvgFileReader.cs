using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Analyze
{
    /// <summary>
    /// A helper class to read Svg fileas per the need of <see cref="SvgParserEngine"/>
    /// </summary>
    public class SvgFileReader
    {
        /// <summary>
        /// We use an inherent stream reader
        /// </summary>
        private StreamReader svgFile;

        /// <summary>
        /// Constructor to initialize the reader with svg file path
        /// </summary>
        /// <param name="fullFilePath"></param>
        public SvgFileReader(string fullFilePath)
        {
            svgFile = new StreamReader(fullFilePath);

            if (svgFile == null)
                throw new Exception("Svg File not found");
        }

        /// <summary>
        /// Check to find if EOF is reached
        /// </summary>
        public bool IsEof
        {
            get { return svgFile.EndOfStream; }
        }

        /// <summary>
        /// Get the current char which the stream currently points to
        /// </summary>
        public char CurrentChar
        {
            get { return (char)svgFile.Peek(); }
        }

        /// <summary>
        /// Seek next node
        /// </summary>
        /// <returns></returns>
        public char SeekNext()
        {
            return (char)svgFile.Read();
        }

        /// <summary>
        /// Check if it is a whitespace
        /// </summary>
        public bool IsWhitespace
        {
            get { return Char.IsWhiteSpace(CurrentChar); }
        }

        /// <summary>
        /// A utility method to skip whitespaces
        /// </summary>
        public void SkipWhitespaces()
        {
            while (IsWhitespace) SeekNext();
        }

        /// <summary>
        /// Get the length of the file
        /// </summary>
        public long Length
        {
            get { return svgFile.BaseStream.Length; }
        }
    }
}
