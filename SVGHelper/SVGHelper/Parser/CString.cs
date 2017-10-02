using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Parser
{
    struct CString
    {
        int _address;
        CStringData _str;

        public CString(string str)
        {
            _address = 0;
            this._str = new CStringData(str);
            this.HasValue = true;
        }

        public CString(int capacity)
        {
            _address = 0;
            this._str = new CStringData(string.Empty);
            this._str._sb.Capacity = capacity;
            this.HasValue = true;
        }

        CString(CStringData str) : this(0, str) { }

        CString(int i, CStringData str)
        {
            this._address = i;
            this._str = str;
            this.HasValue = true;
        }

        // Use this for null pointer checks, since pointers to 0 are legal
        public readonly bool HasValue;

        public StringChar Ref
        {
            get
            {
                if (_str == null)
                    return '\0';
                if (_address < 0 || _address >= _str.Length)
                    return '\0';
                else return _str[_address];
            }
            set
            {
                _str[_address] = value;
            }
        }

        public char this[int index]
        {
            get
            {
                int i = _address + index;
                if (i < 0 || i >= _str.Length)
                    return '\0';

                return _str[i];
            }
            set
            {
                int i = _address + index;

                if (i >= _str.Length)
                    EnsureMinCapacity(i + 1);

                _str[i] = value;
            }
        }

        internal void EnsureMinCapacity(int count)
        {
            _str.EnsureMinCapacity(count);
        }

        public static CString operator ++(CString p)
        {
            p._address += 1;
            return p;
        }

        public static CString operator --(CString p)
        {
            p._address -= 1;
            return p;
        }

        public static implicit operator int(CString p)
        {
            return p._address;
        }
        public static CString operator +(CString p, int i)
        {
            p._address += i;
            return p;
        }
        public static CString operator -(CString p, int i)
        {
            p._address -= i;
            return p;
        }
        public static CString operator +(int i, CString p)
        {
            p._address = i + p._address;
            return p;
        }
        public static CString operator -(int i, CString p)
        {
            p._address = i - p._address;
            return p;
        }
        public static implicit operator bool(CString p)
        {
            return p.HasValue;
        }

        public static implicit operator CString(string s)
        {
            return new CString(s);
        }

        public static implicit operator string(CString s)
        {
            return s.ToString();
        }

        public override string ToString()
        {
            if (_str == null) return null;

            return _str.ToString(_address);
        }

        public static int Compare(CString s1, CString s2)
        {
            byte uc1, uc2;

            /* Move s1 and s2 to the first differing characters 
            in each string, or the ends of the strings if they
            are identical.  */
            while (s1.Ref && s1.Ref == s2.Ref)
            {
                s1++;
                s2++;
            }

            /* Compare the characters as unsigned char and
            return the difference.  */
            uc1 = (byte)s1.Ref;
            uc2 = (byte)s2.Ref;
            return (uc1 < uc2) ? -1 : ((uc1 > uc2) ? 1 : 0);
        }

        public static int Compare(CString s1, CString s2, int n)
        {
            byte uc1, uc2;
            int i = 0;

            /* Move s1 and s2 to the first differing characters 
            in each string, or the ends of the strings if they
            are identical.  */
            while (i < n && s1.Ref && s1.Ref == s2.Ref)
            {
                s1++;
                s2++;
                i++;
            }

            /* Compare the characters as unsigned char and
            return the difference.  */
            uc1 = (byte)s1.Ref;
            uc2 = (byte)s2.Ref;
            return (uc1 < uc2) ? -1 : ((uc1 > uc2) ? 1 : 0);
        }

        // Character reference
        public struct StringChar
        {
            public char Value;

            public static implicit operator char(StringChar r)
            {
                return r.Value;
            }

            public static implicit operator StringChar(char c)
            {
                StringChar r = new StringChar();
                r.Value = c;
                return r;
            }

            public static explicit operator byte(StringChar r)
            {
                return (byte)r.Value;
            }

            public static bool operator ==(StringChar r1, StringChar r2)
            {
                return r1.Value == r2.Value;
            }
            public static bool operator !=(StringChar r1, StringChar r2)
            {
                return r1.Value != r2.Value;
            }
            public static bool operator ==(StringChar r, char c)
            {
                return r.Value == c;
            }
            public static bool operator !=(StringChar r, char c)
            {
                return r.Value != c;
            }
            public static bool operator ==(char c, StringChar r)
            {
                return c == r.Value;
            }
            public static bool operator !=(char c, StringChar r)
            {
                return c != r.Value;
            }

            public override bool Equals(object o)
            {
                if (!(o is StringChar))
                    return false;

                StringChar r = (StringChar)o;

                return this.Value.Equals(r.Value);
            }
            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public static implicit operator bool(StringChar r)
            {
                return r != '\0';
            }
        }

        // Backing string data for one or more pointers
        class CStringData
        {
            internal System.Text.StringBuilder _sb;

            public CStringData() : this(string.Empty) { }

            public CStringData(string input)
            {
                _sb = new System.Text.StringBuilder(input);
            }

            public static implicit operator CStringData(string s)
            {
                return new CStringData(s);
            }

            public string ToString(int p)
            {
                int start = p;
                while (this[p] != '\0')
                {
                    p++;
                }

                return _sb.ToString(start, p - start);
            }

            public int Length
            {
                get
                {
                    return _sb.Length;
                }
            }
            public StringChar this[int index]
            {
                get
                {
                    if (index < 0 || index >= _sb.Length)
                        return '\0';
                    else
                        return _sb[index];
                }
                set
                {
                    if (index >= _sb.Length)
                        EnsureMinCapacity(index + 1);

                    _sb[index] = value;
                }
            }

            public void EnsureMinCapacity(int count)
            {
                while (_sb.Capacity < count)
                    _sb.Capacity *= 2;

                if (_sb.Length < count)
                    _sb.Append('\0', count - _sb.Length);
            }
        }
    }
}
