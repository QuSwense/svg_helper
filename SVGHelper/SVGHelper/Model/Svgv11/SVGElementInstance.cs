using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// For each ‘use’ element, the SVG DOM maintains a shadow tree (the "instance tree")
    /// of objects of type SVGElementInstance. An SVGElementInstance represents a single
    /// node in the instance tree.
    /// <see href="https://www.w3.org/TR/SVG/struct.html#InterfaceSVGElementInstance"/>
    /// </summary>
    public interface SVGElementInstance: EventTarget
    {
        /// <summary>
        /// The corresponding element to which this object is an instance. For example,
        /// if a ‘use’ element references a ‘rect’ element, then an SVGElementInstance 
        /// is created, with its correspondingElement being the SVGRectElement object 
        /// for the ‘rect’ element.
        /// </summary>
        SVGElement CorrespondingElement { get; set; }

        /// <summary>
        /// The corresponding ‘use’ element to which this SVGElementInstance object belongs.
        /// </summary>
        SVGUseElement CorrespondingUseElement { get; set; }

        /// <summary>
        /// The parent of this SVGElementInstance within the instance tree. All SVGElementInstance
        /// objects have a parent except the SVGElementInstance which corresponds to the element
        /// which was directly referenced by the ‘use’ element, in which case parentNode is null.
        /// </summary>
        SVGElementInstance ParentNode { get; set; }

        /// <summary>
        /// An SVGElementInstanceList that contains all children of this SVGElementInstance within
        /// the instance tree. If there are no children, this is an SVGElementInstanceList containing
        /// no entries (i.e., an empty list).
        /// </summary>
        List<SVGElementInstance> ChildNodes { get; set; }

        /// <summary>
        /// The first child of this SVGElementInstance within the instance tree. If there is no such
        /// SVGElementInstance, this returns null.
        /// </summary>
        SVGElementInstance FirstChild { get; set; }

        /// <summary>
        /// The last child of this SVGElementInstance within the instance tree. If there is no such
        /// SVGElementInstance, this returns null.
        /// </summary>
        SVGElementInstance LastChild { get; set; }

        /// <summary>
        /// The SVGElementInstance immediately preceding this SVGElementInstance. If there is no
        /// such SVGElementInstance, this returns null.
        /// </summary>
        SVGElementInstance PreviousSibling { get; set; }

        /// <summary>
        /// The SVGElementInstance immediately following this SVGElementInstance. If there is
        /// no such SVGElementInstance, this returns null.
        /// </summary>
        SVGElementInstance NextSibling { get; set; }
    }
}
