using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection; // Add this namespace for IServiceScopeFactory
using Microsoft.EntityFrameworkCore;

namespace StudentskiDogodki.Pages
{
    public class IskanjeDogodkov : PageModel
    {
        private readonly BazaContext _db;

        public IskanjeDogodkov(BazaContext db)
        {
            _db = db;
        }

        public string iskalnoPolje { get; set; }
        public DateTime vnosDatum { get; set; }
        public string vnosLokacija { get; set; }
        public List<Dogodek> seznamDogodkov = new List<Dogodek>();

        public void VrniIskalneParametre()
        {
            // Implement your logic to set iskalnoPolje, vnosDatum, and vnosLokacija
            iskalnoPolje = "Vnesi";
            vnosDatum = DateTime.Now;
            vnosLokacija = "Vnesi Lokacijo";
        }

        public void IskanjeNaVneseneParametre()
        {
            // Fetching dogodki from the actual database using the BazaContext
            seznamDogodkov = _db.Dogodki
                .Where(d => d.Ime.Contains(iskalnoPolje, StringComparison.OrdinalIgnoreCase) &&
                            d.Datum >= vnosDatum &&
                            d.Lokacija.Contains(vnosLokacija, StringComparison.OrdinalIgnoreCase))
                .ToList();
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

        public void OnGet()
        {
            // Implement your logic for handling GET requests
           // VrniIskalneParametre();
            //IskanjeNaVneseneParametre();
            PrikazDogodkov();
        }
    }
}