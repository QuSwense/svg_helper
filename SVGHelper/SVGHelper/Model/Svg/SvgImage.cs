using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svg
{
    public class SvgImage
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public XmlProlog Prolog { get; set; }
        public SvgShape Shapes { get; set; }
    }
}
