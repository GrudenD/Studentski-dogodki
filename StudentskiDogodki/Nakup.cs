using System;

namespace StudentskiDogodki.Pages
{
    public class Nakup
    {
        public int Id { get; set; }
        public Dogodek Dogodek { get; set; }
        public int stKart {  get; set; }
        public Karta Karta { get; set; }
        public Popust Popust { get; set; }
        
        public Nakup() { }
        public Nakup(Dogodek dogodek, int stKart, Karta karta, Popust popust)
        {
            Dogodek = dogodek;
            this.stKart = stKart;
            Karta = karta;   
            this.Popust = popust;
        }


        private Evidenca evidenca;

    }

}
