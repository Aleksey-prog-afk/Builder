using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.documents
{
    abstract class Document
    {
        private string title;
        private string signature;
        public string Title { get => title; set => title = value; }
        public string Signature { get => signature; set => signature = value; }
    }
}
