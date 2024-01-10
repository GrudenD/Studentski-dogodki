using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace StudentskiDogodki.Pages
{
    public class IndexModel : PageModel
    {
       public static void Main(string[] args)
        {
            Uporabnik uporabnik1 = new Uporabnik("Tone","Kralj","tone.kralj@gmail.com", new DateOnly(2003,10,13),"geslo123");
            Uporabnik uporabnik2 = new Uporabnik("Janez", "Novak", "janez.novak@gmail.com", new DateOnly(1995, 5, 22), "geslo456");

            Dogodek dogodek1 = new Dogodek("Rocktronica",new DateTime(2024,8,13,18,00,00),"Velike Lasce","Klemen Klemen, Ilassis, Lenstr");
            Dogodek dogodek2 = new Dogodek("Stand up večer", new DateTime(2024, 4, 2, 20, 00,00), "Stuk Maribor", "Vid Valić, Tadej Toš");

            Karta karta1 = new Karta(1000,dogodek1,10.00);
            Karta karta2 = new Karta(200, dogodek2, 5.00);

            Popust popust1 = new Popust("znizajme", 20);
            Popust popust2 = new Popust("smesnismo", 10);

            Nakup nakup1 = new Nakup(dogodek1, 2,karta1,popust1);
            Nakup nakup2 = new Nakup(dogodek2,5,karta2,popust2);

            Rezervacija rezervacija1 = new Rezervacija(uporabnik1, dogodek2, karta2, 4);
            Rezervacija rezervacija2 = new Rezervacija(uporabnik2, dogodek1, karta1, 3);

            Fotografija fotografija1 = new Fotografija("//slike//dogodek1", dogodek1);
            Fotografija fotografija2 = new Fotografija("//slike//dogodek2", dogodek2);

            BazaContext db = new();

            db.Uporabniki.RemoveRange(db.Uporabniki);
            db.Dogodki.RemoveRange(db.Dogodki);
            db.Karte.RemoveRange(db.Karte);
            db.Popusti.RemoveRange(db.Popusti);
            db.Nakupi.RemoveRange(db.Nakupi);
            db.Rezervacije.RemoveRange(db.Rezervacije);
            db.Fotografije.RemoveRange(db.Fotografije);

            db.SaveChanges();

            db.Uporabniki.Add(uporabnik1);
            db.Uporabniki.Add(uporabnik2);

            db.Dogodki.Add(dogodek1);
            db.Dogodki.Add(dogodek2);


            db.Karte.Add(karta1);
            db.Karte.Add(karta2);

            // Adding Popusti
            db.Popusti.Add(popust1);
            db.Popusti.Add(popust2);

            // Adding Nakupi
            db.Nakupi.Add(nakup1);
            db.Nakupi.Add(nakup2);

            // Adding Rezervacije
            db.Rezervacije.Add(rezervacija1);
            db.Rezervacije.Add(rezervacija2);

            // Adding Fotografije
            db.Fotografije.Add(fotografija1);
            db.Fotografije.Add(fotografija2);

            // Save changes to the database
            db.SaveChanges();

            void OnGet()
            {
                var Dogodki = db.Dogodki.ToList();
            }
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void IskanjeDogodka()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void IzbiraDogodka()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikazFotografij()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikazIzbraneFotografije()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OknoZaVnosPodatkov()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikazIdNakupa()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void IzbraniNacinDeljenja()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PridobiVseDogodke()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikaziDogodke()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void NajdiDogodek()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoPotrditev()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikaziUspesnost()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoDodajanje()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoPrijava()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoRezervacija()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PreveriPopust()
        {
            Console.WriteLine("Debil");
            throw new System.NotImplementedException("Not implemented");
        }
        public void ZnizajCeno()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private OknoZaVnosPodatkov oknoZaVnosPodatkov;
        private PrijavnoOkno prijavnoOkno;
        private PotrditvenoOknoIzbris potrditvenoOknoIzbris;
        private OknoRezervacija oknoRezervacija;
        private DodDogodkaOkno dodDogodkaOkno;
       
    }
}