using BancaTcc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancaTcc.Controllers
{
    public class DisciplinaController : Controller
    {
        DisciplinasRepositorio disciplinaRepositorio = new DisciplinasRepositorio();

        public ActionResult Disciplina()
        {
            var disciplinas = disciplinaRepositorio.getAll();
            return View(disciplinas);
        }
        [HttpGet]
        public ActionResult CreateDisciplina()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDisciplina(Disciplinas aDisciplina)
        {
            disciplinaRepositorio.Create(aDisciplina);
            return RedirectToAction("Disciplina");
        }
        
        public ActionResult UpdateDisciplina(int Id)
        {
            var disciplina = disciplinaRepositorio.GetOne(Id);
            return View(disciplina);
        }
        [HttpPost]
        public ActionResult UpdateDisciplina(Disciplinas aDisciplina)
        {
            disciplinaRepositorio.Update(aDisciplina);
            return RedirectToAction("Disciplina");
        }
        public ActionResult DeleteDisciplina(int Id)
        {
            disciplinaRepositorio.Delete(Id);
            return RedirectToAction("Disciplina");
        }
    }
}