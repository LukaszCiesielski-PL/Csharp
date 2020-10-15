using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibrary1
{
    public class Postac
    {
        public string Nazwa { get; set; }
        public int Obrazenia { get; set; }
        public int Wytrzymalosc { get; set; }
        public int AktualnaWytrzymalosc { get; set; }
        public int Pancerz { get; set; }
        public int Pieniądze { get; set; }
        public int Poziom { get; set; }
        public int PunktyDoswiadczenia { get; set; }

        public Postac(string nazwa="Baldrock",int obrazenia=10, int wytrzymalosc=100, int aktualnaWyt=100, int pancerz=20,int pieniadze=1000, int poziom=1, int pktDoswiadczenia=0)
        {
            Nazwa = nazwa;
            Obrazenia = obrazenia;
            Wytrzymalosc = wytrzymalosc;
            AktualnaWytrzymalosc = aktualnaWyt;
            Pancerz = pancerz;
            Pieniądze = pieniadze;
            Poziom = poziom;
            PunktyDoswiadczenia = pktDoswiadczenia;

        }

        
    }
}
