using System;

namespace StudentskiDogodki
{
    public class OknoZaVnosPodatkov
    {
        private string ime;
        private string priimek;
        private int stKartice;
        private int cvv;
        private DateTime veljaDo;

        public void PreveriPodatke()
        {
            // throw new System.NotImplementedException("Not implemented");
            if (ime != null && priimek != null && stKartice != null && cvv != null && veljaDo != null)
            {
                return;
            }
           
        }

        private GlavnoOkno glavnoOkno;

    }

}
