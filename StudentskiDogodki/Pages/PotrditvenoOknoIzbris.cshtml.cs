using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentskiDogodki.Pages
{
    public class PotrditvenoOknoIzbris : PageModel
    {
        public void IzbrisiDogodek()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void Close()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private Dogodek dogodek;

        private IndexModel glavnoOkno;

        public void OnGet()
        {
        }
    }
}
