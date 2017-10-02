using SVGHelper.Analyze;
using SVGHelper.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            //SvgPathElement pathElement = SvgXmlParser.SvgParse(File.ReadAllText(@"D:\COMPANY\GITHUB\QuSwense\Website_Scrapper\country\flag\Flag_of_Afghanistan.svg"));

            SvgParserEngine parser = new SvgParserEngine(@"D:\COMPANY\GITHUB\QuSwense\svg_helper\country\flag\Flag_of_Afghanistan.svg");
            parser.Parse();
        }
    }
}
