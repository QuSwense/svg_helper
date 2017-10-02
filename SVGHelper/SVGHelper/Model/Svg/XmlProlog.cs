using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// <code> <?xml version="1.0" encoding="UTF-8"?> </code>
    /// <see href="https://www.w3.org/TR/REC-xml/#sec-prolog-dtd"/>
    /// </summary>
    public class XmlProlog : XmlElementBase
    {
        /// <summary>
        /// Version info tag <see href="https://www.w3.org/TR/REC-xml/#NT-VersionInfo"/>
        /// The Version number has a fixed format and is defined in 
        /// <see href="https://www.w3.org/TR/REC-xml/#NT-VersionNum"/>
        /// </summary>
        public string VersionAttribute { get; set; }

        /// <summary>
        /// <see href="https://www.w3.org/TR/REC-xml/#NT-EncodingDecl"/>
        /// </summary>
        public string EncodingAttribute { get; set; }

        /// <summary>
        /// In a standalone document declaration, the value "yes" indicates that there are no external markup declarations
        /// <see href="https://www.w3.org/TR/REC-xml/#NT-SDDecl"/>
        /// </summary>
        public bool Standalone { get; set; }
    }
}
