using System;
using System.Collections.Generic;
using System.Text;
using Builder.documents;
namespace Builder.builders
{
    class SimpleDocumentBuilder : IDocumentBuilder
    {
        private SimpleDocument document = new SimpleDocument();
        public SimpleDocument build()
        {
            return document;
        }

        public IDocumentBuilder SetSignature()
        {
            document.Signature = "Signatured";
            return this;
        }

        public IDocumentBuilder SetTitle()
        {
            document.Title = "Simple";
            return this;
        }
    }
}
