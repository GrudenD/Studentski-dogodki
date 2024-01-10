using System;

namespace StudentskiDogodki.Pages
{
    public class Karta
    {
        public int Id { get; set; }
        public int StKart {  get; set; }
        public Dogodek Dogodek { get; set; }
        public double Cena { get; set; }
        public Karta() { }
        public Karta(int stKart, Dogodek dogodek, double cena) 
        {
            this.StKart = stKart;
            this.Dogodek = dogodek;
            this.Cena = cena;
        }

        public void PreveriRazpolozljivostKart()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void VrniRazpolozljivostKart()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private Nakup nakup;

        private Evidenca evidenca;

    }

}
