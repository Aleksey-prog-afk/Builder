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
        public ComplexDocumentBuilder SetNumber(int number)
        {
            document.number = number;
            return this;
        }
        public ComplexDocumentBuilder SetDecimal (double number)
        {
            document.decima = number;
            return this;
        }
        public ComplexDocumentBuilder SetText(string text)
        {
            document.text = text;
            return this;
        }
    }
}
