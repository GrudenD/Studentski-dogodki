using System;

namespace StudentskiDogodki
{
    public class Dogodek
    {
        private string ime;
        private DateTime datum;
        private string lokacija;
        private string nastopajoci;
        private string opis;
        private List<Karta> karte;

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
