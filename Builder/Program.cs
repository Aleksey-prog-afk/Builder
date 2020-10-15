using Builder.builders;
using Builder.documents;
using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDocument simpleDocument;
            ListDocument listDocument;
            ComplexDocument complexDocument;
            SimpleDocumentBuilder simpleBuilder = new SimpleDocumentBuilder();
            ListDocumentBuilder listBuilder = new ListDocumentBuilder();
            ComplexDocumentBuilder complexBuilder = new ComplexDocumentBuilder();
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            simpleBuilder.SetTitle().SetSignature();

            listBuilder.SetList(list).SetTitle().SetSignature();

            complexBuilder.SetTitle().SetSignature().SetText("Very hard text").SetNumber(15).SetDecimal(1.34);           

            simpleDocument = simpleBuilder.build();
            listDocument = listBuilder.build();
            complexDocument = complexBuilder.build();

            Console.WriteLine("| Simple Document |");
            Console.WriteLine("  Title: {0}\n  Signature: {1}", simpleDocument.Title, simpleDocument.Signature);

            Console.WriteLine("\n| List document |");
            Console.WriteLine("  Title: {0}\n  Signature: {1}", listDocument.Title, listDocument.Signature);
            Console.WriteLine("  List:");
            foreach(var i in listDocument.list)
            {
                Console.WriteLine("\t{0}",i);
            }

            Console.WriteLine("\n| Complex document |");
            Console.WriteLine("  Title: {0}\n  Signature: {1}", complexDocument.Title, complexDocument.Signature);
            Console.WriteLine("  Number: {0}\n  Decimal: {1}\n  Text:{2}", complexDocument.number, complexDocument.decima, complexDocument.text);
        }
    }
}
