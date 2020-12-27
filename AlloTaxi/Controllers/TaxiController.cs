using AlloTaxi.Models;
using AlloTaxi.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlloTaxi.Controllers
{
    public class TaxiController : Controller
    {
        // GET: Taxi
     
        public ActionResult SearchResult()

        {
            Chauffeur cfr = new Chauffeur();
            using (DbModels db = new DbModels())
            {
                cfr.CollectionChauffeur = db.Chauffeurs.ToList<Chauffeur>();
            }

            
            return View(cfr);
        }
    }
}