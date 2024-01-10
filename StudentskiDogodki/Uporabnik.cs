using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace StudentskiDogodki.Pages
{
    public class Uporabnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek {  get; set; }
        public string Mail { get; set; }
        public DateOnly DatumRojstva {  get; set; }
        public string Geslo { get; set; }

        public Uporabnik() { }
        public Uporabnik(string ime, string priimek, string mail, DateOnly datumRojstva, string geslo)
        {
            Ime = ime;
            Priimek = priimek;
            Mail = mail;
            DatumRojstva = datumRojstva;
            Geslo = geslo;
         
        }


        private Evidenca evidenca;
        private PrijavnoOkno prijavnoOkno;
        private Rezervacija rezervacija;
        private Nakup nakup;

    }

}
