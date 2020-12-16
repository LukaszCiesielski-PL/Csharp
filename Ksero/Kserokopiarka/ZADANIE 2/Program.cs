using System;
using ver1;


namespace ZADANIE_2
{
    class Program
    {
        static void Main()
        {
            var fax = new MultifunctionalDevice();
            fax.PowerOn();

            IDocument doc1 = new PDFDocument("test.pdf");
            fax.Print(in doc1);
            fax.Scan(out _, IDocument.FormatType.PDF);
            fax.PowerOn();
            fax.PowerOff();
            fax.PowerOn();
            IDocument doc3 = new PDFDocument("test2.pdf");
            fax.Send(doc3, "Łukasz Ciesielski");
            IDocument doc4;
            fax.ToGet(out doc4);
            fax.ScanAndPrint();
            fax.PowerOn();
            fax.ScanAndSend("Łukasz Ciesielski");

            Console.WriteLine($"Print counter: {fax.PrintCounter}");
            Console.WriteLine($"Scan counter: {fax.ScanCounter}");
            Console.WriteLine($"Send counter: {fax.SendCounter}");
            Console.WriteLine($"Fax counter: {fax.ToGetCounter}");
            Console.WriteLine($"Fax on/off counter: {fax.Counter}");


        }
    }
}
