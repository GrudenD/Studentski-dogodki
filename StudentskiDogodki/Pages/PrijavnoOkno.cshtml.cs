using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentskiDogodki.Pages
{
    
    public class PrijavnoOkno : PageModel
    {
       public static bool prijavljen = false;
        public void PrikaziDialogPrijava()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PreveriUporabnika()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void NastaviUporabnika()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void Close()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private Uporabnik uporabnik;

        private IndexModel glavnoOkno;
        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {
            prijavljen = true;
            return RedirectToPage("/Index");

        }
    }
}
