using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    /// <summary>
    /// The core attributes are those attributes that can be specified on any SVG element.
    /// </summary>
    public class DTSvgCoreElement
    {
        /// <summary>
        /// Standard XML attribute for assigning a unique name to an element.
        /// id = "name"
        /// Animatable: no.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Specifies a base IRI other than the base IRI of the document or external entity.
        /// The attribute xml:base may be inserted in XML documents to specify a base URI 
        /// other than the base URI of the document or external entity.
        /// In namespace-aware XML processors, the "xml" prefix is bound to the namespace 
        /// name http://www.w3.org/XML/1998/namespace as described in Namespaces in XML
        /// xml:base = "<iri>"
        /// Note that xml:base can be still used by non-namespace-aware processors.
        /// </summary>
        public string XmlBase { get; set; }

        /// <summary>
        /// ISO 639-1 Language Codes
        /// xml:lang = "languageID"
        /// </summary>
        public string XmlLang { get; set; }

        /// <summary>
        /// Standard XML attribute to specify whether white space is preserved in character data.
        /// The only possible values are 'default' and 'preserve'.
        /// </summary>
        public EAttributeXmlSpace XmlSpace { get; set; }
    }
}
