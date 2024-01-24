using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentskiDogodki.Pages
{
    public class DodDogodkaOkno : PageModel
    {
        private BazaContext _db;

        public DodDogodkaOkno(BazaContext db)
        {
            _db = db;
        }

       

        private Dogodek dogodek;

        private IndexModel glavnoOkno;
        public void OnGet()
        {
        }
    }
}
