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
    public class UsuariosBloqueadosController : BasicController
    {
        // GET: UsuariosBloqueados
        public ActionResult Index()
        {
            SessionInitialize();
            UsuarioCAD usuCAD = new UsuarioCAD(session);
            UsuarioCEN usuCEN = new UsuarioCEN(usuCAD);

            IList<UsuarioEN> listEN = usuCEN.DameUsuariosBloqueados();
            IEnumerable<UsuarioViewModel> listViewModel = new UsuariosBloqueadosAssembler().ConvertListENToModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: UsuariosBloqueados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosBloqueados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosBloqueados/Create
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

        // GET: UsuariosBloqueados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosBloqueados/Edit/5
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

        // GET: UsuariosBloqueados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosBloqueados/Delete/5
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
