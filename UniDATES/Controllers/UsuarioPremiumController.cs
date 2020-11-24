using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniDATES.Assemblers;
using UniDATES.Models;
using UniDATESGenNHibernate.CAD.UniDATES;
using UniDATESGenNHibernate.CEN.UniDATES;
using UniDATESGenNHibernate.EN.UniDATES;

namespace UniDATES.Controllers
{
    public class UsuarioPremiumController : BasicController
    {
        // GET: UsuarioPremium
        public ActionResult Index()
        {

            SessionInitialize();

            UsuarioCAD usuCAD = new UsuarioCAD(session);
            UsuarioCEN usuCEN = new UsuarioCEN(usuCAD);

            IList<UsuarioEN> listEN = usuCEN.DameUsuariosPremium();
            IEnumerable<UsuarioViewModel> listViewModel = new UsuarioPremiumAssembler().ConvertListENTomModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: UsuarioPremium/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioPremium/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioPremium/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioPremium/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioPremium/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioPremium/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioPremium/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
