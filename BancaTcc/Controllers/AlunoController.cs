using BancaTcc.Models;
using PexeiraConnectionClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancaTcc.Controllers
{
    public class AlunoController : Controller
    {
        RepositorioDB conn = new RepositorioDB();
        AlunoRepositorio alunoRepositorio = new AlunoRepositorio();

        public ActionResult Aluno()
        {
            var aluno = alunoRepositorio.getAll();
            return View(aluno);
        }
        [HttpGet]
        public ActionResult CreateAluno()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CreateAluno(Aluno aAluno)
        {
            alunoRepositorio.Create(aAluno);
            return RedirectToAction("Aluno");
        }
        
        public ActionResult UpdateAluno(int Id)
        {
            var aluno = alunoRepositorio.GetOne(Id);
            return View(aluno);
        }
        [HttpPost]
        public ActionResult UpdateAluno(Aluno aAluno)
        {
            alunoRepositorio.Update(aAluno);
            return RedirectToAction("Aluno");
        }
        public ActionResult DeleteAluno(int Id)
        {
            alunoRepositorio.Delete(Id);
            return RedirectToAction("Aluno");
        }
    }
}