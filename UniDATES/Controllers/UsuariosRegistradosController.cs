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
    public class UsuariosRegistradosController : BasicController
    {
        // GET: UsuariosRegistrados
        public ActionResult Index()
        {
            SessionInitialize();

            UsuarioCAD usuCAD = new UsuarioCAD(session);
            UsuarioCEN usuCEN = new UsuarioCEN(usuCAD);

            IList<UsuarioEN> listEN = usuCEN.DameUsuariosRegistrados();
            IEnumerable<UsuarioViewModel> listViewModel = new UsuariosRegistradosAssembler().ConvertListENTomModel(listEN).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: UsuariosRegistrados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosRegistrados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosRegistrados/Create
        [HttpPost]
        public ActionResult Create(UsuarioViewModel usu)
        {
            try
            {
                /*UsuarioCEN usuCEN = new UsuarioCEN();
                usuCEN.Registrarse(usu.Nombre, usu.Apellidos, usu.Con);*/

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosRegistrados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosRegistrados/Edit/5
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

        // GET: UsuariosRegistrados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosRegistrados/Delete/5
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
