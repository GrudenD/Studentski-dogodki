using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace StudentskiDogodki.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
      
        private BazaContext _db;

        public IndexModel(BazaContext db)
        {
            _db = db;
        }

        public string iskalnoPolje { get; set; }

        public List<Dogodek> seznamDogodkov = new List<Dogodek>();

        public void VrniIskalneParametre()
        {
           
            iskalnoPolje = "Vnesi";

        }

        public void IskanjeNaVneseneParametre()
        {
            
            seznamDogodkov = _db.Dogodki
                .Where(d => d.Ime.Contains(iskalnoPolje, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void PrikazDogodkov()
        {
            seznamDogodkov = _db.Dogodki.ToList();
            foreach (var dogodek in seznamDogodkov)
            {
                // Your display logic here
                Console.WriteLine($"Event: {dogodek.Ime}, Date: {dogodek.Datum}, Location: {dogodek.Lokacija}");
            }
        }

        public async void OnGet()
        {
            // Implement your logic for handling GET requests
            // VrniIskalneParametre();
            // IskanjeNaVneseneParametre();
            PrikazDogodkov();
        }

        public IActionResult OnPost()
             {
            // Implement your logic for handling POST requests
            return RedirectToPage("IskanjeDogodkov");
             }

    }
}