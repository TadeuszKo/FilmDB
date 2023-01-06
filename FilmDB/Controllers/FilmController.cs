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
        FilmManager filmManager = new FilmManager();
        public IActionResult Index()
        {
            {
                //var random = new Random();
                //var film = new FilmModel();

                //{
                //    Title = $"Rambo{random.Next(1, 100)}",
                //    Year = 1999
                //};
                //filmManager.AddFilm(film);

                ////dodawanie nowego filmu dobazy danych
                ////var manager = new FilmManager();
                //filmManager.AddFilm(new FilmModel()
                //{
                //    ID = 0,
                //    Title = "Matrix",
                //    Year = 1999
                //});

                ////usuwanie filmu z bazy danych
                ////var managerRemove = new FilmManager();
                //filmManager.RemoveFilm(2);

                ////aktualizacja filmu/ rekordu w bazie danych
                ////var managerUpdate = new FilmManager();
                //filmManager.UpdateFilm(new FilmModel()
                //{
                //    ID = 2,
                //    Title = "Madagaskar",
                //    Year = 2010
                //});

                ////zmiana tytułu filmu
                ////var managerZmianTitle = new FilmManager();
                //filmManager.ChangeTitle(3, "Test");
                ////managerZmianTitle.ChangeTitle(4, "Naruto");
            }//wykomentowane


            var filmy = filmManager.GetFilms();
            return View(filmy);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel filmModel) 
        {
            filmManager.AddFilm(filmModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var film = filmManager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            filmManager.RemoveFilm(id);
            return RedirectToAction("Index");
        }
    }
}
