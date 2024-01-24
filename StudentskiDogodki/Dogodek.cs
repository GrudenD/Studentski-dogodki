using System;

namespace StudentskiDogodki.Pages
{
    public class Dogodek
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public DateTime Datum { get; set; }
        public string Lokacija { get; set; }
        public string Nastopajoci { get; set; }
        public string PotDoNaslovnce { get; set; }
        public Dogodek(string ime, DateTime datum, string lokacija, string nastopajoci, string potDoNaslovnce)
        {
            this.Ime = ime;
            this.Datum = datum;
            this.Lokacija = lokacija;
            this.Nastopajoci = nastopajoci;
            PotDoNaslovnce = potDoNaslovnce;
        }
        public void VrniPodrobnostDogodka()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private Dogodek dogodek2;
        private Rezervacija rezervacija;

        private Dogodek dogodek;
        private Evidenca evidenca;
        private OknoRezervacija oknoRezervacija;
        private SeznamDogodkov seznamDogodkov;
        private DodDogodkaOkno dodDogodkaOkno;
        private PotrditvenoOknoIzbris potrditvenoOknoIzbris;
        private Nakup nakup;

    }

}
