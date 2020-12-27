using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloTaxi.Models.Db;
using AlloTaxi.Models;

namespace AlloTaxi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // will be used on the drop down list to show the cities
        public ActionResult Index(int id =0)
        {
            Chauffeur cfr = new Chauffeur();
            using (DbModels db = new DbModels())
            {
                cfr.CollectionChauffeur = db.Chauffeurs.ToList<Chauffeur>();
            }
            
            return View(cfr);
        }
        public ActionResult GetDetails(int Id)
        {
            
            using (DbModels db = new DbModels())
            {
                List<Chauffeur> chauffeursDetails = db.Chauffeurs.Where(x => x.Id == Id).ToList();
            }
            return chauffeursDetails;
        }

    }
}