﻿using Builder.documents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Builder.builders
{
    class ListDocumentBuilder : IDocumentBuilder
    {
        private ListDocument document = new ListDocument();
        

        public IDocumentBuilder SetSignature()
        {
            document.Signature = "listsignature";
            return this;
        }

        public IDocumentBuilder SetTitle()
        {
            document.Title = "ListDocument";
            return this;
        }
        public IDocumentBuilder SetList(IList list) 
        {
            document.list = list;
            return this;
        }
        public ListDocument build()
        {
            return this.document;
        }

        public IDocumentBuilder SetList()
        {
            throw new NotImplementedException();
        }

        public IDocumentBuilder SetNumber(int number)
        {
            throw new NotImplementedException();
        }

        public IDocumentBuilder SetDecimal(double number)
        {
            throw new NotImplementedException();
        }

        public IDocumentBuilder SetText(string text)
        {
            throw new NotImplementedException();
        }
    }
}
