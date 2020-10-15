using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class DangerDungeon
    {
       
        static void Main(string[] args)
        {
            Postac postac = new Postac();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Witaj {postac.Nazwa}! ");
            
            Console.WriteLine($"\nOto Twoje statystyki: \n\n\tObrażenia: {postac.Obrazenia} \n\tWytrzymałość: {postac.Wytrzymalosc} \n\tPieniądze: {postac.Pieniądze} \n\tPoziom: {postac.Poziom} \n\tPunkty doświadczenia: {postac.PunktyDoswiadczenia}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nStajesz przed wyzwaniem, w którym ceną jest śmierć. Tylko nieliczni są w stanie przejść całą drogę okropieństw które napotkają.");
            Console.WriteLine("\nZnajdujesz się przed Bramą Sanktuarium. Widzisz przed sobą wielkie drewniane drzwi. Uchylasz je i...\n");
            Console.ForegroundColor = ConsoleColor.White;
            Poruszanie.RuchN();
            string idz = Console.ReadLine().ToUpper();
            PoziomLochu pzmLochu = new PoziomLochu();
            switch (idz)
            {
                case "N":
                    Console.WriteLine($"\nZnajdujesz się na {pzmLochu.NazwaPoziomu="Dziedzińcu"}");
                    break;   
            }

            Console.WriteLine("Rozglądasz się po pomieszczeniu, czujesz się mały w tak ogromnej sali. Jednak na twojej twarzy widnieje spokój, nagle czujesz dziwne uczucie jakby gryzienia po kostkach, spoglądasz w dół i okazuje się, że to szczur. Czas zgładzić pierwszego przeciwnika...  ");
            Potwor potwor = new Potwor("Szczur",8,10,10,100,0);
            Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa}: {potwor.AktualnaWytrzymalosc}");

            Walka.walkaDziedziniec(postac, potwor);
            Console.WriteLine("\nPo zgnieceniu szczura, już wiesz, że wszystko w tym miejscu będzie próbowało Cię zabić.");

            Poruszanie.RuchNPL();
            idz = Console.ReadLine().ToUpper();

            switch (idz)
            {
                case "N":

                    Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu="Wewnętrznym Monastyrze"}");
                    Console.WriteLine($"Ku Twojemu zdziwieniu w pomieszczeniu tlą się pochodnie. Zastanawaisz się kto mógł je zapalić skoro to miejsce jest opuszczone, czy był to jakiś śmiałek, który był tu przed Tobą. Idąc przed siebie, słyszysz szczęk zbroi. Odwaracasz się gwałtownie i widzisz jak szkielet wykonuje zamach skierowany ku Tobie. Potwór musiał się czaić na Ciebie od samego początku...");
                    Potwor potwor2 = new Potwor("Szkielet - wojownik", 10,150,150,200,0);
                    Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa="Szkielet"}: {potwor.AktualnaWytrzymalosc=150}");
                    Walka.walkaDziedziniec(postac, potwor2);
                    Console.WriteLine("\nPrzeciwnik nie był dla Ciebie zbyt wymagający ale na samą myśl, o tym, że taka bestia zaatakowała Cię na samym początku, zaczynasz się obawiać kto może pilnować skarbu.");
                    Console.WriteLine("Dochodząc do końca pomieszczenie trafiasz na rozwidlenie dróg...");

                    Poruszanie.RuchPL();
                    idz = Console.ReadLine().ToUpper();
                    switch (idz) 
                    {
                        case "L":
                            Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Kaplicy"}");
                            Console.WriteLine("Panuje tu względny spokój, pomieszczenie o dziwo jest bardzo dobrze oświetlone pochodniami. Możesz w końcu chwilę odpocząć przed przejściem do następnego pomieszczenia.");
                            Console.WriteLine("Jako, iż znajdujesz się w kaplicy dostrzegasz ołtarz i podchodzisz do niego. Na małej kamiennej tablicy widnieją glify, mówiące o złożeniu ofiary w zamian za nagrodę.");
                            Console.WriteLine("Sięgasz ręką do sakwy i wyjmujesz garść złotych monet, a następnie kładziesz je na marmurowym blacie. Od nacisku pieniędzy otwierają się dwie ukryte komory.");
                            Console.WriteLine("W obu komorach dostrzegasz magiczne runy, jednak możesz wybrać tylko jedną...");
                            Poruszanie.Nagroda();
                            int wybor0 = Convert.ToInt32(Console.ReadLine());
                            
                            switch (wybor0)
                            {
                                
                                case 1:
                                    postac.Pieniądze = postac.Pieniądze - 200;
                                    Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                                    postac.Obrazenia = postac.Obrazenia + 3;
                                    Console.WriteLine($"\tTwoje aktualne obrażenia: {postac.Obrazenia}");
                                    break;
                                case 2:
                                    postac.Pieniądze = postac.Pieniądze - 200;
                                    Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                                    postac.Wytrzymalosc = postac.Wytrzymalosc + 10;
                                    Console.WriteLine($"\tTwoja aktualna wytrzymałość: {postac.Wytrzymalosc}");
                                    break;
                                case 3:
                                    Console.WriteLine("\nPrzez swoją chciwość zostałeś ukarany.");
                                    postac.Obrazenia = postac.Obrazenia - 3;
                                    Console.WriteLine($"\n\tTwoje aktualne obrażenia spadają o 3: {postac.Obrazenia}");
                                    postac.Wytrzymalosc = postac.Wytrzymalosc - 10;
                                    Console.WriteLine($"\tTwoja aktualna wytrzymałość spada o 10: {postac.Wytrzymalosc}");
                                    break;
                            }
                            Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Katakumbach"}");
                            Console.WriteLine("Po wyjściu z Lazaretu idziesz długim krętym tunelem, który ciągle prowadzi w dół. Uświadamisz sobie, że koniec Twojej przygody jest bliski końca. ponieważ prawdopobonie katakumby prowadzą do głównej sali w której jest ukryty skarb...");
                            Console.WriteLine("Dochodząc do końca pierwszego tunelu na Twojej drodze staje potwór. Sięgasz po miecz jednak o dziwo potwór Cię nie atakuje tylko stoi w bezruchu. Powoli się do niego zbliżasz dalej trzymając rękę na rękojeści miecza. Kiedy jesteś bardzo blisko dostrzegasz zarys twarzy potwora ale jak się okazuje nie jest on potworem tylko człowiekiem. Z lekkim zdziwieniem próbujesz zapytać co on tu robi i czy to on zapalił te wszystkie pochodnie ale w tym momencie tajemnicza postać znika, a na ziemię spada część jakiegoś klucza...");

                            List<Klucz> klucz4 = new List<Klucz>();
                            klucz4.Add(new Klucz("Veni", "Mosiężny"));
                            Console.WriteLine();
                            
                            foreach (Klucz aPart in klucz4)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(aPart);
                            }

                            Console.WriteLine("\nPodnosisz część klucza jednak zastanawiasz się gdzie jest druga i masz nadzieję, że znajdziesz ją po drodze...");
                            
                            Poruszanie.RuchN();

                            Console.WriteLine("\nPo otwarciu wielkich mosiężnych drzwi, wchodzisz do większej sali i ku Twoim oczom w pierwszym momencie rzuca się trup, którego duch zostawił Ci część klucza. Jednak po chwili dostrzegasz bestię która biegnie w Twoim kierunku. Prawdopodobnie to ona zabiła tego śmiałka, miej się na baczności...");
                            Potwor potworB = new Potwor("Griswold", 20, 200, 200, 700, 0);
                            Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa = "Griswald"}: {potwor.AktualnaWytrzymalosc = 200}");
                            Walka.walkaDziedziniec(postac, potworB);
                            Console.WriteLine("\nLedwo udało Ci się pokonać rogatą bestię... Widzisz, że potwór miał zawieszoną kolejną część klucza na szyi, bierzesz ją.");
                            klucz4.Add(new Klucz("Vidi", "Mosiężny"));
                            Console.WriteLine();

                            foreach (Klucz aPart in klucz4)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(aPart);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine("\nW pośpiechu przechodzisz do następnego pomieszczenia, jest to wielka sala, a na jej końcu widzisz dwie pary potężnych drzwi. Podchodzisz do nich i dokładnie się im przyglądasz. Jedne drzwi wykonane są z mosiądzu, a drugie z grubej stali. Musisz wybrać do których drzwi pasują elementy klucza.");

                            
                            Console.WriteLine("\nM - mosiężne");
                            Console.WriteLine("S - stalowe");
                            Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                            string drzwi = Console.ReadLine().ToUpper();

                            if (drzwi == "M")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                                Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Ustawiam napis: ");
                                Drzwi.drzwi();

                            }
                            else
                            {
                     
                                Console.WriteLine("\nKlucz nie pasuje.");
                                
                                Console.WriteLine("\nM - mosiężne");
                                Console.WriteLine("S - stalowe");
                                Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                                drzwi = Console.ReadLine().ToUpper();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                                Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Ustawiam napis: ");
                                Drzwi.drzwi();
                            }

                            break;

                           
                            

                        case "P":
                            Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Lazarecie"}");
                            Console.WriteLine("Panuje tu względny spokój, pomieszczenie o dziwo jest bardzo dobrze oświetlone pochodniami. Możesz w końcu chwilę odpocząć przed przejściem do następnego pomieszczenia.");
                            Console.WriteLine("Jako, iż znajdujesz się w lazarecie dostrzegasz skrzynię i podchodzisz do niej. Na pokrywie widnieją glify, mówiące o zapłacie w zamian za informację gdzie znajduje się klucz do niej.");
                            Console.WriteLine("Sięgasz ręką do sakwy i wyjmujesz garść złotych monet, a następnie wrzucasz je do małego otworu w skrzyni. Słyszysz cichą pracę trybików, po chwili z boku skrzyni wypada małe zawiniątko, a w nim o dziwio znajduje się kluczyk.");
                            Console.WriteLine("Ostrożnie otwierasz skrzynie i dostrzegasz magiczne eliksiry, jednak możesz wybrać tylko jeden...");
                            Poruszanie.Nagroda();
                            int wybor = Convert.ToInt32(Console.ReadLine());

                            switch (wybor)
                            {
                                case 1:
                                    postac.Pieniądze = postac.Pieniądze - 200;
                                    Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                                    postac.Obrazenia = postac.Obrazenia + 5;
                                    Console.WriteLine($"\tTwoje aktualne obrażenia: {postac.Obrazenia}");
                                    break;
                                case 2:
                                    postac.Pieniądze = postac.Pieniądze - 200;
                                    Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                                    postac.Wytrzymalosc = postac.Wytrzymalosc + 10;
                                    Console.WriteLine($"\tTwoja aktualna wytrzymałość: {postac.Wytrzymalosc}");
                                    break;
                                case 3:
                                    Console.WriteLine("\nPrzez swoją chciwość zostałeś ukarany. Czeka Cię zguba !");
                                    postac.Obrazenia = postac.Obrazenia - 5;
                                    Console.WriteLine($"\n\tTwoje aktualne obrażenia spadają o 5: {postac.Obrazenia}");
                                    postac.Wytrzymalosc = postac.Wytrzymalosc - 10;
                                    Console.WriteLine($"\tTwoja aktualna wytrzymałość spada o 10: {postac.Wytrzymalosc}");
                                    break;
                            }
                            Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Katakumbach"}");
                            Console.WriteLine("Po wyjściu z Lazaretu idziesz długim krętym tunelem, który ciągle prowadzi w dół. Uświadamisz sobie, że koniec Twojej przygody jest bliski końca. ponieważ prawdopobonie katakumby prowadzą do głównej sali w której jest ukryty skarb...");
                            Console.WriteLine("Dochodząc do końca pierwszego tunelu na Twojej drodze staje potwór. Sięgasz po miecz jednak o dziwo potwór Cię nie atakuje tylko stoi w bezruchu. Powoli się do niego zbliżasz dalej trzymając rękę na rękojeści miecza. Kiedy jesteś bardzo blisko dostrzegasz zarys twarzy potwora ale jak się okazuje nie jest on potworem tylko człowiekiem. Z lekkim zdziwieniem próbujesz zapytać co on tu robi i czy to on zapalił te wszystkie pochodnie ale w tym momencie tajemnicza postać znika, a na ziemię spada część jakiegoś klucza...");

                            List<Klucz> klucz3 = new List<Klucz>();
                            klucz3.Add(new Klucz("Veni", "Stalowy"));
                            Console.WriteLine();
                            foreach (Klucz aPart in klucz3)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(aPart);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine("\nPodnosisz część klucza jednak zastanawiasz się gdzie jest druga i masz nadzieję, że znajdziesz ją po drodze...");

                            Poruszanie.RuchN();

                            Console.WriteLine("\nPo otwarciu wielkich stalowych drzwi, wchodzisz do większej sali i ku Twoim oczom w pierwszym momencie rzuca się trup, którego duch zostawił Ci część klucza. Jednak po chwili dostrzegasz bestię która biegnie w Twoim kierunku. Prawdopodobnie to ona zabiła tego śmiałka, miej się na baczności...");
                            Potwor potworC = new Potwor("Griswold", 20, 200, 200, 700, 0);
                            Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa = "Griswald"}: {potwor.AktualnaWytrzymalosc = 200}");
                            Walka.walkaDziedziniec(postac, potworC);
                            Console.WriteLine("\nLedwo udało Ci się pokonać rogatą bestię... Widzisz, że potwór miał zawieszoną kolejną część klucza na szyi, bierzesz ją.");
                            klucz3.Add(new Klucz("Vidi", "Stalowy"));
                            Console.WriteLine();

                            foreach (Klucz aPart in klucz3)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(aPart);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine("\nW pośpiechu przechodzisz do następnego pomieszczenia, jest to wielka sala, a na jej końcu widzisz dwie pary potężnych drzwi. Podchodzisz do nich i dokładnie się im przyglądasz. Jedne drzwi wykonane są z mosiądzu, a drugie z grubej stali. Musisz wybrać do których drzwi pasują elementy klucza.");


                            Console.WriteLine("\nM - mosiężne");
                            Console.WriteLine("S - stalowe");
                            Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                            string drzwi3 = Console.ReadLine().ToUpper();
                            if (drzwi3 == "S")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                                Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Ustawiam napis: ");
                                Drzwi.drzwi();

                            }
                            else
                            {

                                Console.WriteLine("\nKlucz nie pasuje.");

                                Console.WriteLine("\nM - mosiężne");
                                Console.WriteLine("S - stalowe");
                                Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                                drzwi = Console.ReadLine().ToUpper();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                                Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Ustawiam napis: ");
                                Drzwi.drzwi();
                            }
                            break;

                    }
                    break;

                case "L":   
                    Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Lewym skrzydle Monastyru"}");
                    Console.WriteLine($"Ku Twojemu zdziwieniu w pomieszczeniu tlą się pochodnie. Zastanawaisz się kto mógł je zapalić skoro to miejsce jest opuszczone, czy był to jakiś śmiałek, który był tu przed Tobą. Idąc przed siebie, słyszysz szczęk zbroi. Odwaracasz się gwałtownie i widzisz jak szkielet wykonuje zamach skierowany ku Tobie. Potwór musiał się czaić na Ciebie od samego początku...");
                    Potwor potwor3 = new Potwor("Szkielet - łucznik", 10, 150, 150, 200, 0);
                    Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa = "Szkielet"}: {potwor.AktualnaWytrzymalosc = 150}");
                    Walka.walkaDziedziniec(postac, potwor3);
                    Console.WriteLine("\nPrzeciwnik nie był dla Ciebie zbyt wymagający ale na samą myśl, o tym, że taka bestia zaatakowała Cię na samym początku, zaczynasz się obawiać kto może pilnować skarbu.");
                    Console.WriteLine("Idziesz prosto przed siebie i dochodzisz do drzwi za którymi dostrzegasz mocną łunę światła...");
                    Poruszanie.RuchN();
                    idz = Console.ReadLine().ToUpper();
                    switch (idz)
                    {
                        case "N":
                            Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Kaplicy"}");
                            Console.WriteLine("Panuje tu względny spokój, pomieszczenie o dziwo jest bardzo dobrze oświetlone pochodniami. Możesz w końcu chwilę odpocząć przed przejściem do następnego pomieszczenia.");
                            Console.WriteLine("Jako, iż znajdujesz się w kaplicy dostrzegasz ołtarz i podchodzisz do niego. Na małej kamiennej tablicy widnieją glify, mówiące o złożeniu ofiary w zamian za nagrodę.");
                            Console.WriteLine("Sięgasz ręką do sakwy i wyjmujesz garść złotych monet, a następnie kładziesz je na marmurowym blacie. Od nacisku pieniędzy otwierają się dwie ukryte komory.");
                            Console.WriteLine("W obu komorach dostrzegasz magiczne runy, jednak możesz wybrać tylko jedną...");
                            Poruszanie.Nagroda();
                            int wyb = Convert.ToInt32(Console.ReadLine());

                            switch (wyb)
                            {
                                case 1:
                                    postac.Pieniądze = postac.Pieniądze - 200;
                                    Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                                    postac.Obrazenia = postac.Obrazenia + 5;
                                    Console.WriteLine($"\tTwoje aktualne obrażenia: {postac.Obrazenia}");
                                    break;
                                case 2:
                                    postac.Pieniądze = postac.Pieniądze - 200;
                                    Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                                    postac.Wytrzymalosc = postac.Wytrzymalosc + 10;
                                    Console.WriteLine($"\tTwoja aktualna wytrzymałość: {postac.Wytrzymalosc}");
                                    break;
                                case 3:
                                    Console.WriteLine("\nPrzez swoją chciwość zostałeś ukarany. Czeka Cię zguba !");
                                    postac.Obrazenia = postac.Obrazenia - 5;
                                    Console.WriteLine($"\n\tTwoje aktualne obrażenia spadają o 5: {postac.Obrazenia}");
                                    postac.Wytrzymalosc = postac.Wytrzymalosc - 10;
                                    Console.WriteLine($"\tTwoja aktualna wytrzymałość spada o 10: {postac.Wytrzymalosc}");
                                    break;
                            }
                            Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Katakumbach"}");
                            Console.WriteLine("Po wyjściu z Kaplicy idziesz długim krętym tunelem, który ciągle prowadzi w dół. Uświadamisz sobie, że koniec Twojej przygody jest bliski końca. ponieważ prawdopobonie katakumby prowadzą do głównej sali w której jest ukryty skarb...");
                            Console.WriteLine("Dochodząc do końca pierwszego tunelu na Twojej drodze staje potwór. Sięgasz po miecz jednak o dziwo potwór Cię nie atakuje tylko stoi w bezruchu. Powoli się do niego zbliżasz dalej trzymając rękę na rękojeści miecza. Kiedy jesteś bardzo blisko dostrzegasz zarys twarzy potwora ale jak się okazuje nie jest on potworem tylko człowiekiem. Z lekkim zdziwieniem próbujesz zapytać co on tu robi i czy to on zapalił te wszystkie pochodnie ale w tym momencie tajemnicza postać znika, a na ziemię spada część jakiegoś klucza...");
                            
                            List<Klucz> klucz = new List<Klucz>();
                            klucz.Add(new Klucz("Veni", "Mosiężny"));
                            Console.WriteLine();
                            foreach (Klucz aPart in klucz)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(aPart);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine("\nPodnosisz część klucza jednak zastanawiasz się gdzie jest druga i masz nadzieję, że znajdziesz ją po drodze...");

                            Poruszanie.RuchN();

                            Console.WriteLine("\nPo otwarciu wielkich mosiężnych drzwi, wchodzisz do większej sali i ku Twoim oczom w pierwszym momencie rzuca się trup, którego duch zostawił Ci część klucza. Jednak po chwili dostrzegasz bestię która biegnie w Twoim kierunku. Prawdopodobnie to ona zabiła tego śmiałka, miej się na baczności...");
                            Potwor potworB = new Potwor("Griswold", 20, 200, 200, 700, 0);
                            Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa = "Griswald"}: {potwor.AktualnaWytrzymalosc = 200}");
                            Walka.walkaDziedziniec(postac, potworB);
                            Console.WriteLine("\nLedwo udało Ci się pokonać rogatą bestię... Widzisz, że potwór miał zawieszoną kolejną część klucza na szyi, bierzesz ją.");
                            
                            klucz.Add(new Klucz("Vidi", "Mosiężny"));
                            Console.WriteLine();

                            foreach (Klucz aPart in klucz)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(aPart);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine("\nW pośpiechu przechodzisz do następnego pomieszczenia, jest to wielka sala, a na jej końcu widzisz dwie pary potężnych drzwi. Podchodzisz do nich i dokładnie się im przyglądasz. Jedne drzwi wykonane są z mosiądzu, a drugie z grubej stali. Musisz wybrać do których drzwi pasują elementy klucza.");


                            Console.WriteLine("\nM - mosiężne");
                            Console.WriteLine("S - stalowe");
                            Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                            string drzwi = Console.ReadLine().ToUpper();

                            if (drzwi == "M")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                                Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Ustawiam napis: ");
                                Drzwi.drzwi();

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nKlucz nie pasuje.");
                                
                                Console.WriteLine("\nM - mosiężne");
                                Console.WriteLine("S - stalowe");
                                Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                                drzwi = Console.ReadLine().ToUpper();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                                Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Ustawiam napis: ");
                                Drzwi.drzwi();
                            }
                            break;   
                    
                    }
                    break;
                case "P":
                    Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Prawym skrzydle Monastyru"}");
                    Console.WriteLine($"Ku Twojemu zdziwieniu w pomieszczeniu tlą się pochodnie. Zastanawaisz się kto mógł je zapalić skoro to miejsce jest opuszczone, czy był to jakiś śmiałek, który był tu przed Tobą. Idąc przed siebie, słyszysz szczęk zbroi. Odwaracasz się gwałtownie i widzisz jak szkielet wykonuje zamach skierowany ku Tobie. Potwór musiał się czaić na Ciebie od samego początku...");
                    Potwor potwor4 = new Potwor("Szkielet - mag", 10, 150, 150, 200, 0);
                    Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa = "Szkielet"}: {potwor.AktualnaWytrzymalosc = 40}");
                    Walka.walkaDziedziniec(postac, potwor4);
                    Console.WriteLine("\nPrzeciwnik nie był dla Ciebie zbyt wymagający ale na samą myśl, o tym, że taka bestia zaatakowała Cię na samym początku, zaczynasz się obawiać kto może pilnować skarbu.");

                    Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Lazarecie"}");
                    Console.WriteLine("Panuje tu względny spokój, pomieszczenie o dziwo jest bardzo dobrze oświetlone pochodniami. Możesz w końcu chwilę odpocząć przed przejściem do następnego pomieszczenia.");
                    Console.WriteLine("Jako, iż znajdujesz się w lazarecie dostrzegasz skrzynię i podchodzisz do niej. Na pokrywie widnieją glify, mówiące o zapłacie w zamian za informację gdzie znajduje się klucz do niej.");
                    Console.WriteLine("Sięgasz ręką do sakwy i wyjmujesz garść złotych monet, a następnie wrzucasz je do małego otworu w skrzyni. Słyszysz cichą pracę trybików, po chwili z boku skrzyni wypada małe zawiniątko, a w nim o dziwio znajduje się kluczyk.");
                    Console.WriteLine("Ostrożnie otwierasz skrzynie i dostrzegasz magiczne eliksiry, jednak możesz wybrać tylko jeden...");
                    Poruszanie.Nagroda();
                    int wybor1 = Convert.ToInt32(Console.ReadLine());

                    switch (wybor1)
                    {
                        case 1:
                            postac.Pieniądze = postac.Pieniądze - 200;
                            Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                            postac.Obrazenia = postac.Obrazenia + 3;
                            Console.WriteLine($"\tTwoje aktualne obrażenia: {postac.Obrazenia}");
                            break;
                        case 2:
                            postac.Pieniądze = postac.Pieniądze - 200;
                            Console.WriteLine($"\n\tSakwa: {postac.Pieniądze}");
                            postac.Wytrzymalosc = postac.Wytrzymalosc + 10;
                            Console.WriteLine($"\tTwoja aktualna wytrzymałość: {postac.Wytrzymalosc}");
                            break;
                        case 3:
                            Console.WriteLine("\nPrzez swoją chciwość zostałeś ukarany.");
                            postac.Obrazenia = postac.Obrazenia - 3;
                            Console.WriteLine($"\n\tTwoje aktualne obrażenia spadają o 3: {postac.Obrazenia}");
                            postac.Wytrzymalosc = postac.Wytrzymalosc - 10;
                            Console.WriteLine($"\tTwoja aktualna wytrzymałość spada o 10: {postac.Wytrzymalosc}");
                            break;
                    }
                    Console.WriteLine($"\nZnajdujesz się w {pzmLochu.NazwaPoziomu = "Katakumbach"}");
                    Console.WriteLine("Po wyjściu z Lazaretu idziesz długim krętym tunelem, który ciągle prowadzi w dół. Uświadamisz sobie, że koniec Twojej przygody jest bliski końca. ponieważ prawdopobonie katakumby prowadzą do głównej sali w której jest ukryty skarb...");
                    Console.WriteLine("Dochodząc do końca pierwszego tunelu na Twojej drodze staje potwór. Sięgasz po miecz jednak o dziwo potwór Cię nie atakuje tylko stoi w bezruchu. Powoli się do niego zbliżasz dalej trzymając rękę na rękojeści miecza. Kiedy jesteś bardzo blisko dostrzegasz zarys twarzy potwora ale jak się okazuje nie jest on potworem tylko człowiekiem. Z lekkim zdziwieniem próbujesz zapytać co on tu robi i czy to on zapalił te wszystkie pochodnie ale w tym momencie tajemnicza postać znika, a na ziemię spada część jakiegoś klucza...");

                    List<Klucz> klucz2 = new List<Klucz>();
                    klucz2.Add(new Klucz("Veni", "Mosiężny"));
                    Console.WriteLine();
                    foreach (Klucz aPart in klucz2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(aPart);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\nPodnosisz część klucza jednak zastanawiasz się gdzie jest druga i masz nadzieję, że znajdziesz ją po drodze...");

                    Poruszanie.RuchN();

                    Console.WriteLine("\nPo otwarciu wielkich stalowych drzwi, wchodzisz do większej sali i ku Twoim oczom w pierwszym momencie rzuca się trup, którego duch zostawił Ci część klucza. Jednak po chwili dostrzegasz bestię która biegnie w Twoim kierunku. Prawdopodobnie to ona zabiła tego śmiałka, miej się na baczności...");
                    Potwor potworA = new Potwor("Griswold", 20, 200, 200, 700, 0);
                    Console.WriteLine($"\nTwoja wytrzymałość: {postac.AktualnaWytrzymalosc} \t {potwor.Nazwa = "Griswald"}: {potwor.AktualnaWytrzymalosc = 200}");
                    Walka.walkaDziedziniec(postac, potworA);
                    Console.WriteLine("\nLedwo udało Ci się pokonać rogatą bestię... Widzisz, że potwór miał zawieszoną kolejną część klucza na szyi, bierzesz ją.");
                    klucz2.Add(new Klucz("Vidi", "Stalowy"));
                    Console.WriteLine();

                    foreach (Klucz aPart in klucz2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(aPart);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\nW pośpiechu przechodzisz do następnego pomieszczenia, jest to wielka sala, a na jej końcu widzisz dwie pary potężnych drzwi. Podchodzisz do nich i dokładnie się im przyglądasz. Jedne drzwi wykonane są z mosiądzu, a drugie z grubej stali. Musisz wybrać do których drzwi pasują elementy klucza.");


                    Console.WriteLine("\nM - mosiężne");
                    Console.WriteLine("S - stalowe");
                    Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                    string drzwi2 = Console.ReadLine().ToUpper();

                    if (drzwi2 == "S")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                        Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ustawiam napis: ");
                        Drzwi.drzwi();

                    }
                    else
                    {

                        Console.WriteLine("\nKlucz nie pasuje.");

                        Console.WriteLine("\nM - mosiężne");
                        Console.WriteLine("S - stalowe");
                        Console.Write("\nKtóre drzwi chcesz otworzyć: ");
                        drzwi2 = Console.ReadLine().ToUpper();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Otwierasz wielkie drzwi i wchodzisz do środka, jednak ku Twojemu zdziwieniu za nimi są kolejne ale mniejsze drzwi, zastanawiasz się po co aż \"2\' drzwi. Obok na stojącym pietestale dostrzegasz inskrypcję \"Vici\"");
                        Console.WriteLine("Drzwi nie mają żadnego otworu ale obok nich dostrzegasz na ścianie dziwny mechanizm składający się z rozsypanch liter tworzących napis \"NPMHCIR XYJGAXCLGMUW\". Już wiesz, że to ostatni etap Twojej przygody, została jeszcze tylko ta zagadka jednak nie obejdzie się bez zwoju i pióra.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Ustawiam napis: ");
                        Drzwi.drzwi();
                    }
                    break;
            }
            

            
        }
        

    } 
}





