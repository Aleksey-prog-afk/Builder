using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.builders
{
    interface IDocumentBuilder
    {
        IDocumentBuilder SetTitle();
        IDocumentBuilder SetSignature();
        IDocumentBuilder SetList();
        IDocumentBuilder SetNumber(int number);
        IDocumentBuilder SetDecimal(double number);
        IDocumentBuilder SetText(string text);

    }
}
