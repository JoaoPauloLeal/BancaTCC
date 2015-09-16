using BancaTcc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancaTcc.Controllers
{
    public class ProfessorController : Controller
    {
        ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();

        public ActionResult Professor()
        {
            var professor = professorRepositorio.getAll();

            return View(professor);
        }
        [HttpGet]
        public ActionResult CreateProfessor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProfessor(Professor aProfessor)
        {
            professorRepositorio.Create(aProfessor);
            return RedirectToAction("Professor");
        }
        
        public ActionResult UpdateProfessor(int Id)
        {
            var professor = professorRepositorio.GetOne(Id);
            return View(professor);
        }
        [HttpPost]
        public ActionResult UpdateProfessor(Professor aProfessor)
        {
            professorRepositorio.Update(aProfessor);
            return RedirectToAction("Professor");
        }
        public ActionResult DeleteProfessor(int Id)
        {
            professorRepositorio.Delete(Id);
            return RedirectToAction("Professor");
        }
        
    }
}