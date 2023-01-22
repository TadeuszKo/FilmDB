using Microsoft.AspNetCore.Mvc;
using System.IO;
using Zaliczenie_JiPP5v2.Logic;
using Zaliczenie_JiPP5v2.Models;

namespace Zaliczenie_JiPP5v2.Controllers
{
    public class ProduktController : Controller
    {
        ProduktManager produktManager = new ProduktManager();
        public IActionResult Index()
        {
            var produkty = produktManager.GetProdukty();
            return View(produkty);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProduktModel produktModel)
        {
            produktManager.AddProdukt(produktModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var produkt = produktManager.GetProdukt(id);
            return View(produkt);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            produktManager.RemoveProdukt(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var produkt = produktManager.GetProdukt(id);
            return View(produkt);
        }

        [HttpPost]
        public IActionResult Edit(ProduktModel produkt)
        {
            produktManager.UpdateProdukt(produkt);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ListadoUsunięcia()
        {
            var produkty = produktManager.GetProdukty();
            return View(produkty);
        }

        [HttpPost]
        public IActionResult UsuwaniePotwierdzenie(int id)
        {
            produktManager.RemoveProdukt(id);
            return RedirectToAction("Index");
        }
    }
}
