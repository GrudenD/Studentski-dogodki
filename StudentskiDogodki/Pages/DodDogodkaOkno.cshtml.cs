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

        public void DodajaDogodkov()
        {
             Dogodek dogodek = new Dogodek("Dodani dogodek",new DateTime(2024,1,25,22,00,00),"Maribor trg","Jaz, Ti, Zidana marela","/Slike/dodan.jpg");
            _db.Dogodki.Add(dogodek);
            _db.SaveChanges();
        }

        private Dogodek dogodek;

        private IndexModel glavnoOkno;
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            DodajaDogodkov();
        }
    }
}
