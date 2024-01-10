using System;

namespace StudentskiDogodki.Pages
{
    public class Fotografija
    {
        public int Id { get; set; }
        public string PotDoFotografije {  get; set; }
        public Dogodek Dogodek { get; set; }

        public Fotografija() { }
        public Fotografija(string potDoFotografije, Dogodek dogodek) 
        {
           
            this.PotDoFotografije = potDoFotografije;
            this.Dogodek = dogodek;
        }
      

        public void VrniFotografije()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private Deljenje deljenje;

        private Evidenca evidenca;

    }

}
