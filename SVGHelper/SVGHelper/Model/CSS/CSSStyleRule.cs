﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.CSS
{
    public interface CSSStyleRule : CSSRule
    {
        string SelectorText { get; set; }
    }
}
