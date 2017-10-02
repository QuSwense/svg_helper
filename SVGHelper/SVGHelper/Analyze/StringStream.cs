using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Analyze
{
    /// <summary>
    /// A string class which acts as a <see cref="StringBuilder"/> and a <see cref="System.IO.Stream"/>
    /// </summary>
    public class StringStream
    {
        /// <summary>
        /// Main store
        /// </summary>
        private StringBuilder svgContent;

        /// <summary>
        /// Current seek character while streaming
        /// </summary>
        private int seek;

        /// <summary>
        /// Default constructor
        /// </summary>
        public StringStream()
        {
            svgContent = new StringBuilder();
            seek = 0;
        }

        /// <summary>
        /// Append char
        /// </summary>
        /// <param name="ch"></param>
        public void Append(char ch)
        {
            svgContent.Append(ch);
        }

        /// <summary>
        /// Check to find if EOF is reached
        /// </summary>
        public bool IsEof
        {
            get { return svgContent.Length <= seek; }
        }

        /// <summary>
        /// Get the current char which the stream currently points to
        /// </summary>
        public char CurrentChar
        {
            get {
                if (IsEof) return '\0';
                else return svgContent[seek];
            }
        }

        /// <summary>
        /// Seek next node
        /// </summary>
        /// <returns></returns>
        public char SeekNext()
        {
            ++seek;
            if (IsEof) return '\0';
            else return svgContent[seek];
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
            get { return svgContent.Length; }
        }

        public void Clear()
        {
            svgContent.Clear();
        }
    }
}
