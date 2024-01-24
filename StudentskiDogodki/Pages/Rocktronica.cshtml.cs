using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection; // Add this namespace for IServiceScopeFactory
using Microsoft.EntityFrameworkCore;
using StudentskiDogodki.Pages;

namespace StudentskiDogodki.Pages
{
    public class Rocktronica : PageModel
    {

        private BazaContext _db;
        public List<Dogodek> Dogodek { get; set; }
        public Rocktronica(BazaContext db)
        {
            _db = db;
        }

        public void DobiDogodek()
        {
            Dogodek = _db.Dogodki.Where(d => d.Ime.Contains("Rocktronica")).ToList();
        }


        public void OnGet()
        {
            DobiDogodek();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/PotrjenNakup");
        }
    }
}

