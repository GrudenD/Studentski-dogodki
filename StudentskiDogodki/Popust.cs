using System;

namespace StudentskiDogodki.Pages
{
    public class Popust
    {
        public int Id { get; set; }
        public string Koda { get; set; }
        public int Procent {  get; set; } 

        public Popust() { }
        public Popust(string koda, int procent)
        {
            this.Koda = koda;
            this.Procent = procent;
        }

        private Evidenca evidenca;

        
    }

}
