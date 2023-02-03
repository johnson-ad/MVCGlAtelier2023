using MVCGlAtelier2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCGlAtelier2023.Controllers
{
    public class InscriptionController : Controller
    {
        private dbAtelier2023Context db = new dbAtelier2023Context();

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        private List<ClientViewModel> getListeClient()
        {
            List<ClientViewModel> Liseter = new List<ClientViewModel>();
            var list = db.clients.Join(db.personnes, x => x.IdPers , y => y.IdPers, (x,y)=>
            new {x.IdPers, x.Sexe, y.EmailPers, y.NomPers, y.PrenomPers, y.TelPers} ).ToList();


            return Liseter;

        }

        // POST: Client/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPers,NomPers,PrenomPers,AdressePers,EmailPers, TelPers,Sexe")] ClientViewModel cl)
        {
            if (ModelState.IsValid)
            {
                Personne p = new Personne();
                p.NomPers = cl.NomPers;
                p.PrenomPers= cl.PrenomPers;
                p.AdressePers = cl.AdressePers;
                p.EmailPers = cl.EmailPers;
                p.TelPers = cl.TelPers;
             
                db.personnes.Add(p);
                db.SaveChanges();


                Client c  = new Client();
                c.IdPers = p.IdPers;
                c.Sexe = cl.Sexe;
                db.clients.Add(c);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(cl);
        }



    }
}