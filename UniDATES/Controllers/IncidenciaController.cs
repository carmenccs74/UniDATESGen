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
using UniDATESGenNHibernate.Enumerated.UniDATES;

namespace UniDATES.Controllers
{
    public class IncidenciaController : BasicController
    {
        // GET: Denuncia
        public ActionResult Index()
        {
            SessionInitialize();

            IncidenciaCAD incidenciaCAD = new IncidenciaCAD();
            IncidenciaCEN incidenciaCEN = new IncidenciaCEN(incidenciaCAD);

            IList<IncidenciaEN> listEN = incidenciaCEN.ReadAll(0, -1);
            IEnumerable<IncidenciaViewModel> listViewModel = new IncidenciaAssembler().ConvertListENToModel(listEN).ToList();


            SessionClose();

            return View(listViewModel);
        }

        // GET: Denuncia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Denuncia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Denuncia/Create
        [HttpPost]
        public ActionResult Create(IncidenciaViewModel incidenciaView, int p_usuarioDenunciante, int p_usuarioDenunciado, int p_administrador)
        {
            try
            {
                IncidenciaCEN incidenciaCEN = new IncidenciaCEN();
                incidenciaCEN.New_(incidenciaView.Motivo, incidenciaView.Fecha, p_usuarioDenunciante, p_usuarioDenunciado, p_administrador);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Denuncia/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Denuncia/Edit/5
        [HttpPost]
        public ActionResult Edit(int p_Incidencia_OID, MotivoIncidenciaEnum p_motivo, DateTime p_fecha)
        {
            try
            {
                IncidenciaCEN incidenciaCEN = new IncidenciaCEN();
                incidenciaCEN.Modify(p_Incidencia_OID, p_motivo, p_fecha);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Denuncia/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Denuncia/Delete/5
        [HttpPost]
        public ActionResult Delete(IncidenciaViewModel incidenciaView)
        {
            try
            {
                IncidenciaCEN incidenciaCEN = new IncidenciaCEN();
                incidenciaCEN.Destroy(incidenciaView.IdIncidencia);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
