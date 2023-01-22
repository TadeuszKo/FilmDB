using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Zaliczenie_JiPP5v2.Context;
using Zaliczenie_JiPP5v2.Models;

namespace Zaliczenie_JiPP5v2.Logic
{
    public class ProduktManager
    {

        public ProduktManager AddProdukt(ProduktModel produktModel)
        {
            using (var context = new ProduktContext())
            {
                //context.Add(produktModel);
                //context.SaveChanges();
                try
                {
                    context.Add(produktModel);
                    context.SaveChanges();
                }
                catch (System.Exception)
                {
                    produktModel.ID = 0;
                    context.Add(produktModel);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public ProduktManager RemoveProdukt(int id)
        {
            using (var context = new ProduktContext())
            {
                var produktDelete = context.Produkty.SingleOrDefault(x => x.ID == id);
                context.Produkty.Remove(produktDelete);
                context.SaveChanges();
            }
            return this;
        }

        public ProduktManager UpdateProdukt(ProduktModel produktModel)
        {
            using (var context = new ProduktContext())
            {
                context.Produkty.Update(produktModel);
                context.SaveChanges();
            }
            return this;
        }

        //public ProduktManager ChangeTitle(int id, string newTitle)
        //{
        //    using (var context = new ProduktContext())
        //    {
        //        var zmianaTitle = context.Produkty.Single(x => x.ID == id);
        //        if (string.IsNullOrEmpty(newTitle))
        //            zmianaTitle.Title = "Brak Tytułu";
        //        else
        //            zmianaTitle.Title = newTitle;

        //        UpdateProdukt(zmianaTitle);
        //        context.SaveChanges();
        //    }
        //    return this;
        //}

        public ProduktModel GetProdukt(int id)
        {
            using (var context = new ProduktContext())
            {
                var jedenGetProdukt = context.Produkty.Single(x => x.ID == id);
                return jedenGetProdukt;
            }
        }

        public List<ProduktModel> GetProdukty()
        {
            using (var context = new ProduktContext())
            {
                var listaGetProdukty = context.Produkty.ToList();
                return listaGetProdukty;
            }
        }

        public List<string> LOKALIZACJA => new List<string>()
        {
            "PIWNICA",
            "ZAMRAŻARKA",
            "GARAŻ",
            "CARGO"
        };
    }
}
