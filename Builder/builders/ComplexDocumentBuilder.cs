using Builder.documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.builders
{
    class ComplexDocumentBuilder : IDocumentBuilder
    {
        private ComplexDocument document = new ComplexDocument();
        public ComplexDocument build()
        {
            return document;
        }
        public IDocumentBuilder SetSignature()
        {
            return this;
        }

        public IDocumentBuilder SetTitle()
        {
            return this;
        }
        public  IDocumentBuilder SetNumber(int number)
        {
            document.number = number;
            return this;
        }
        public IDocumentBuilder SetDecimal (double number)
        {
            document.decima = number;
            return this;
        }
        public IDocumentBuilder SetText(string text)
        {
            document.text = text;
            return this;
        }

        public IDocumentBuilder SetList()
        {
            throw new NotImplementedException();
        }
       
    }
}
