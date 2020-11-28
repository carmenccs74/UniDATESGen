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
    public class UsuariosDadosDeBajaController : BasicController
    {
        // GET: UsuariosDadosDeBaja
        public ActionResult Index()
        {
            SessionInitialize();
            UsuarioCAD usuarioCAD = new UsuarioCAD(session);
            UsuarioCEN usuarioCEN = new UsuarioCEN(usuarioCAD);

            IList<UsuarioEN> listEN = usuarioCEN.DameUsuariosDadosDeBaja();
            IEnumerable<UsuarioViewModel> listViewModel = new UsuariosDadosDeBajaAssembler().ConvertListENToModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: UsuariosDadosDeBaja/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosDadosDeBaja/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosDadosDeBaja/Create
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

        // GET: UsuariosDadosDeBaja/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosDadosDeBaja/Edit/5
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

        // GET: UsuariosDadosDeBaja/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosDadosDeBaja/Delete/5
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
