using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Common
{
    public class StringStream
    {
        private StringReader stringReader;

        public StringStream(string data)
        {
            stringReader = new StringReader(data);
        }

        public char CurrentChar
        {
            get { return Convert.ToChar(stringReader.Peek()); }
        }

        public bool IsEof
        {
            get { return stringReader.Peek() < 0; }
        }

        public bool IsCurrentWhiteSpace
        {
            get { return Char.IsWhiteSpace(CurrentChar); }
        }

        public char ReadNextChar()
        {
            return Convert.ToChar(stringReader.Read());
        }

        public bool CompareCurrentChar(char[] listChars)
        {
            char current = CurrentChar;

            for (int indx = 0; indx < listChars.Length; ++indx)
                if (listChars[indx] == current) return true;
            return false;
        }

        public static StringStream operator ++(StringStream stringStream)
        {
            stringStream.ReadNextChar();
            return stringStream;
        }
    }
}
