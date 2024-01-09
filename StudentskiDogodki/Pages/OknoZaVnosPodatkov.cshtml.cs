using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentskiDogodki.Pages
{
    public class OknoZaVnosPodatkov : PageModel
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

        private IndexModel glavnoOkno;
        public void OnGet()
        {
        }
    }
}
