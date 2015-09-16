using BancaTcc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancaTcc.Controllers
{
    public class SemestreController : Controller
    {
        SemestreRepositorio semestreRepositorio = new SemestreRepositorio();

        public ActionResult Semestre()
        {
            var semestre = semestreRepositorio.getAll();
            
            return View(semestre);
        }
        [HttpGet]
        public ActionResult CreateSemestre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSemestre(Semestre aSemestre)
        {
            semestreRepositorio.Create(aSemestre);
            return RedirectToAction("Semestre");
        }
        
        public ActionResult UpdateSemestre(int Id)
        {
            var semestre = semestreRepositorio.GetOne(Id);
            return View(semestre);
        }
        [HttpPost]
        public ActionResult UpdateSemestre(Semestre aSemestre)
        {
            semestreRepositorio.Update(aSemestre);
            return RedirectToAction("Semestre");
        }
        public ActionResult DeleteSemestre(int Id)
        {
            semestreRepositorio.Delete(Id);
            return RedirectToAction("Semestre");
        }
    }
}