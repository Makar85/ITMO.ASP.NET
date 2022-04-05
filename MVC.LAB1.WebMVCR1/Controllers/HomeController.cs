using Microsoft.AspNetCore.Mvc;
using MVC.LAB1.WebMVCR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.LAB1.WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" :
                "Добрый день"; 
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }
        [HttpGet] //означает, что данный метод должен использоваться только для GET запросов:
        public ViewResult InputData()
        { 
            return View(); 
        }
        //Добавьте перегруженную версию метода действия InputData, который принимает параметр
        //Person и применяет атрибут HttpPost, это означает, что новый метод будет иметь дело
        //с POST запросами:
        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }

        //Добавьте новый метод действия, реализующий получение коллекции и информации о ее размере
        //в динамический объект ViewBag:
        public ViewResult OutputData()
        { 
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson; 
            return View("ListPerson"); 
        }


        //В поле класса контроллера HomeController добавьте код создания статического объекта репозитория:
        private static PersonRepository db = new PersonRepository();

        //public string Index(string hel)
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    return Greeting;
        //}
    }
}
