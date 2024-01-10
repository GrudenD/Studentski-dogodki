using System;

namespace StudentskiDogodki.Pages
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public Uporabnik Uporabnik { get; set; }
        public Dogodek Dogodek { get; set; }
        public Karta Karta { get; set; }
        public int StKart {  get; set; }

        public Rezervacija() { }
        public Rezervacija(Uporabnik uporabnik, Dogodek dogodek,Karta karta,int StKart) 
        {
            this.Uporabnik = uporabnik;
            this.Dogodek = dogodek;
            this.Karta = karta;
            this.StKart = StKart;
        }
    
    }

}
