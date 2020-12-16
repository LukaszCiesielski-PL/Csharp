using System;
using System.Collections.Generic;
using System.Text;
using ver1;
using ZADANIE_1;

namespace ZADANIE_2
{
    public class MultifunctionalDevice : BaseDevice, IPrinter, IScanner, IFax
    {
        public int PrintCounter { get; set; }
        public int ScanCounter { get; set; }
        public new int Counter { get; set; }
        public int ToGetCounter { get; set; } 
        public int SendCounter { get; set; }

        public new void PowerOn()
        {
            if (state == IDevice.State.off)
            {
                Counter++;
                base.PowerOn();
            }
        }
        public new void PowerOff()
        {
            if (state == IDevice.State.on)
                base.PowerOff();
        }

        public void Print(in IDocument document)
        {
            if (state == IDevice.State.on)
            {
                Console.WriteLine($"{DateTime.Now} Print: {document.GetFileName()}");
                PrintCounter = PrintCounter + 1;
            }

        }

        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.JPG)
        {
            document = null;
            if (state == IDevice.State.on)
            {
                ScanCounter = ScanCounter + 1;
                switch (formatType)
                {
                    case IDocument.FormatType.PDF:
                        Console.WriteLine($"{DateTime.Now} Scan: PDFScan{ScanCounter}.pdf");
                        document = new PDFDocument($" PDFScan{ScanCounter}.pdf");
                        break;
                    case IDocument.FormatType.JPG:
                        Console.WriteLine($"{DateTime.Now} Print: ImageScan{ScanCounter}.jpg");
                        document = new ImageDocument($" ImageScan{ScanCounter}.jpg");
                        break;
                    case IDocument.FormatType.TXT:
                        Console.WriteLine($"{DateTime.Now} Print: TextScan{ScanCounter}.txt");
                        document = new TextDocument($" TextScan{ScanCounter}.txt");
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
       
          

        public void ScanAndPrint()
        {
            IDocument document;
            Scan(out document, IDocument.FormatType.JPG);
            Print(document);

        }

        public void Send(in IDocument document, string where)
        {
            if (state == IDevice.State.on)
            {
                Console.WriteLine($"{DateTime.Now} Fax: Send {document.GetFileName()} -> {where}");
                SendCounter = SendCounter + 1;
            }
            
        }

        public void ToGet(out IDocument document)
        {
            document = null;
            if (state == IDevice.State.on)
            {
                ToGetCounter = ToGetCounter + 1;
                document = new PDFDocument($"FaxedDocument {ToGetCounter}.pdf");
                Console.WriteLine($"{DateTime.Now} Fax: ToGet {document.GetFileName()}");

            }
        }

        public void ScanAndSend(string target)
        {
            IDocument document;
            Scan(out document, IDocument.FormatType.JPG);
            Send(document, target);

        }
    }
}
