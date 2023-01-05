using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        FilmManager manager = new FilmManager();
        public IActionResult Index()
        {
            //var random = new Random();
            //var film = new FilmModel();
            //{
            //    Title=$"Rambo{random.Next(1,100)}",
            //    Year = 1999
            //};
            //filmManager.AddFilm(film);

            //dodawanie nowego filmu dobazy danych
            //var manager = new FilmManager();
            manager.AddFilm(new FilmModel()
            {
                ID = 0,
                Title = "Matrix",
                Year = 1999
            });

            //usuwanie filmu z bazy danych
            //var managerRemove=new FilmManager();
            //managerRemove.RemoveFilm(2);

            //aktualizacja filmu/rekordu w bazie danych
            //var managerUpdate = new FilmManager();
            //managerUpdate.UpdateFilm(new FilmModel()
            //{
            //    ID=2,
            //    Title="Madagaskar",
            //    Year=2010
            //});

            //zmiana tytułu filmu
            var managerZmianTitle = new FilmManager();
            managerZmianTitle.ChangeTitle(3,"Test");
            managerZmianTitle.ChangeTitle(4, "Naruto");

                return View();
                

        }
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel filmModel) 
        {
            manager.AddFilm(filmModel);
            return RedirectToAction("Index");

        }
    }
}
