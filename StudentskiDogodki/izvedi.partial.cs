﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using StudentskiDogodki.Pages;
using System;

namespace StudentskiDogodki.Pages
{
    public partial class Program
    {
        public static void Izvedi()
        {
            Uporabnik uporabnik1 = new Uporabnik("Tone", "Kralj", "tone.kralj@gmail.com", new DateOnly(2003, 10, 13), "geslo123");
            Uporabnik uporabnik2 = new Uporabnik("Janez", "Novak", "janez.novak@gmail.com", new DateOnly(1995, 5, 22), "geslo456");

            Dogodek dogodek1 = new Dogodek("Rocktronica", new DateTime(2023, 12, 16, 17, 00, 00), "Velike Lasce", "Klemen Klemen, Ilassis, Lenstr","/Slike/Rocktronica.png");
            Dogodek dogodek2 = new Dogodek("Stand up večer", new DateTime(2024, 4, 2, 20, 00, 00), "Stuk Maribor", "Vid Valić, Tadej Toš","/Slike/Standup.jpg");
            Dogodek dogodek3 = new Dogodek("Fašenk v Markovcih", new DateTime(2024, 2, 3, 20, 00, 00), "Karnevalska Dvorana", "Severina, Domen Kumer, Skupina Vzrok","/Slike/Fasenk.jpg");
            Dogodek dogodek4 = new Dogodek("Beerpong Kenguru", new DateTime(2024,1,27,19,00,00), "SD Kenguru","Tekmovalci", "/Slike/Beerpong.jpg");

            Karta karta1 = new Karta(1000, dogodek1, 10.00);
            Karta karta2 = new Karta(200, dogodek2, 5.00);

            Popust popust1 = new Popust("znizajme", 20);
            Popust popust2 = new Popust("smesnismo", 10);

            Nakup nakup1 = new Nakup(dogodek1, 2, karta1, popust1);
            Nakup nakup2 = new Nakup(dogodek2, 5, karta2, popust2);

            Rezervacija rezervacija1 = new Rezervacija(uporabnik1, dogodek2, karta2, 4);
            Rezervacija rezervacija2 = new Rezervacija(uporabnik2, dogodek1, karta1, 3);

            Fotografija fotografija1 = new Fotografija("/slike//dogodek1", dogodek1);
            Fotografija fotografija2 = new Fotografija("/slike//dogodek2", dogodek2);

             BazaContext db = new();

            db.Uporabniki.RemoveRange(db.Uporabniki);
            db.Dogodki.RemoveRange(db.Dogodki);
            db.Karte.RemoveRange(db.Karte);
            db.Popusti.RemoveRange(db.Popusti);
            db.Nakupi.RemoveRange(db.Nakupi);
            db.Rezervacije.RemoveRange(db.Rezervacije);
            db.Fotografije.RemoveRange(db.Fotografije);

            db.SaveChanges();

            db.Uporabniki.Add(uporabnik1);
            db.Uporabniki.Add(uporabnik2);

            db.Dogodki.Add(dogodek1);
            db.Dogodki.Add(dogodek2);
            db.Dogodki.Add(dogodek3);
            db.Dogodki.Add(dogodek4);

            db.Karte.Add(karta1);
            db.Karte.Add(karta2);

            // Adding Popusti
            db.Popusti.Add(popust1);
            db.Popusti.Add(popust2);

            // Adding Nakupi
            db.Nakupi.Add(nakup1);
            db.Nakupi.Add(nakup2);

            // Adding Rezervacije
            db.Rezervacije.Add(rezervacija1);
            db.Rezervacije.Add(rezervacija2);

            // Adding Fotografije
            db.Fotografije.Add(fotografija1);
            db.Fotografije.Add(fotografija2);

            // Save changes to the database
            db.SaveChanges();

            void OnGet()
            {
                var Dogodki = db.Dogodki.ToList();
                IndexModel iskanjeDogodkov = new IndexModel(db);
                Rocktronica rocktronica = new Rocktronica(db);

            }

            
        }
      
    }
}
