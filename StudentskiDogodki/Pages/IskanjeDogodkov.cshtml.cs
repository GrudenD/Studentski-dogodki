using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection; // Add this namespace for IServiceScopeFactory
using Microsoft.EntityFrameworkCore;
using StudentskiDogodki.Pages;

namespace StudentskiDogodki.Pages
{
    public class IskanjeDogodkov : PageModel
    {
        private BazaContext _db;

        public IskanjeDogodkov(BazaContext db)
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

                Console.WriteLine($"Event: {dogodek.Ime}, Date: {dogodek.Datum}, Location: {dogodek.Lokacija}");
            }
        }


        public IActionResult OnPost()
        {
            return RedirectToPage("Rocktronica");
        }

        public void OnGet()
        {
            // Implement your logic for handling GET requests
            // VrniIskalneParametre();
            // IskanjeNaVneseneParametre();
            PrikazDogodkov();
        }
    }
}