using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.CSS
{
    public interface StyleSheet
    {
        string Type { get; set; }
        bool Disabled { get; set; }
        StyleSheet ParentStyleSheet { get; set; }
        string Href { get; set; }
        string Title { get; set; }
        List<Media> MediaList { get; set; }
    }
}
