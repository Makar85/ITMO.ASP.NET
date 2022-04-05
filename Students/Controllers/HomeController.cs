using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Students.Models;


namespace Students.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;

            return View();
        }
        public ActionResult ScoreSum()
        {
            var ScoreSum = db.Students.Sum(x => x.Score);
            ViewBag.Students = ScoreSum;
            return PartialView();
        }
        public ActionResult ShowBest()
        {
            var best = db.Students.Take(5).OrderByDescending(i=>i.Score).ToList();
            return PartialView(best);
        }
        public ActionResult ShowWorst()
        {
            var best = db.Students.Take(5).OrderBy(i => i.Score).ToList();
            return PartialView(best);
        }

        //public ActionResult ListToText()
        //{
            
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}