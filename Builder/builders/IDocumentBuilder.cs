using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.builders
{
    interface IDocumentBuilder
    {
        IDocumentBuilder SetTitle();
        IDocumentBuilder SetSignature();
        
    }
}
