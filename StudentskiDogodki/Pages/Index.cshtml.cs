using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentskiDogodki.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void IskanjeDogodka()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void IzbiraDogodka()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikazFotografij()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikazIzbraneFotografije()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OknoZaVnosPodatkov()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikazIdNakupa()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void IzbraniNacinDeljenja()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PridobiVseDogodke()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikaziDogodke()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void NajdiDogodek()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoPotrditev()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PrikaziUspesnost()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoDodajanje()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoPrijava()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OdpriOknoRezervacija()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void PreveriPopust()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void ZnizajCeno()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private OknoZaVnosPodatkov oknoZaVnosPodatkov;
        private PrijavnoOkno prijavnoOkno;
        private PotrditvenoOknoIzbris potrditvenoOknoIzbris;
        private OknoRezervacija oknoRezervacija;
        private DodDogodkaOkno dodDogodkaOkno;
        public void OnGet()
        {

        }
    }
}