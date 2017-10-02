using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace SVGHelper.Engine
{
    public class NamespaceCleaner : IDisposable
    {
        private XDocument svgFileFullPathReader;
        private XmlWriter svgFileFullPathWriter;
        private string[] namespacesToKeep;

        public NamespaceCleaner(string svgFileUri, string[] namespaces = null)
        {
            svgFileFullPathReader = XDocument.Load(svgFileUri);
            if (namespaces == null)
            {
                // Use default
                namespacesToKeep = new string[] { "http://www.w3.org/2000/svg" };
            }
        }

        public void Execute()
        {
            // Check the namespaces in the svg tag attributes
            XElement svgNode = svgFileFullPathReader.XPathSelectElement("//svg");

            if (svgNode == null) throw new Exception("No svg tag found");

            List<string> namepsacesOnSvgToRemove = svgFileFullPathReader.Root.Attributes()
                .Where(a => a.IsNamespaceDeclaration).Select(x => x.Value).ToList();

            foreach (string namepsaceOnSvgToRemove in namepsacesOnSvgToRemove)
            {
                // Get all elements in specific namespace and remove
                svgFileFullPathReader.Root.Descendants()
                   .Where(o => o.Name.Namespace == namepsaceOnSvgToRemove)
                   .Remove();

                // Get all attributes in specific namespace and remove
                svgFileFullPathReader.Root.Descendants()
                   .Attributes()
                   .Where(o => o.Name.Namespace == namepsaceOnSvgToRemove)
                   .Remove();
                //svgFileFullPathReader.Root.Descendants().ToList().ForEach(d => d.Attributes().Where(a => a.Name.Namespace == namepsaceOnSvgToRemove).Remove());
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    svgFileFullPathReader = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~NamespaceCleaner() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
