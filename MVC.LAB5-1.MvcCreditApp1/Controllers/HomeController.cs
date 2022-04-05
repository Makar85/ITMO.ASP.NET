using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.LAB5_1.MvcCreditApp1.Models;




namespace MVC.LAB5_1.MvcCreditApp1.Controllers
{
         
    public class HomeController : Controller
    {
        //поле класса контроллера создайте экземпляр контекста данных:
        private CreditContext db = new CreditContext();

        //добавьте метод действия контроллера, выполняющий асинхронную
        //операцию «Извлечение из БД нужной информации в частичное представление»:
        public ActionResult BidSearch(string name)
        {
            var allBids = db.Bids.Where(a => a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("Указанный кредит " + name + " не найден");
                //return HttpNotFound();
            }
            return PartialView(allBids);
        }

        public ActionResult Index()

        {
            GiveCredits();
            return View();
        }
        private void GiveCredits()
        {
            //обратитесь к контексту и получите все записи о кредитах
            var allCredits = db.Credits.ToList<Credit>();
            //Далее создайте свойство Credits в объекте ViewBag и присвойте
            //ему извлеченный список. Объект ViewBag является таким объектом,
            //который передается в представление:
            ViewBag.Credits = allCredits;
        }

        //возвращает соответствующее представление c получением
        //всех записей о кредитах и заявках:
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits(); 
            var allBids = db.Bids.ToList<Bid>(); 
            ViewBag.Bids = allBids; 
            return View();
        }
        //принимает переданную ему в запросе POST модель newBid и добавляет ее в базу данных.
        //В конце возвращается строка уведомительного сообщения:
        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now; // Добавляем новую заявку в БД
            db.Bids.Add(newBid); 
            // Сохраняем в БД все изменения
            db.SaveChanges(); 
            return "Спасибо, <b>" + newBid.Name + "</b>, за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней."; 
        }


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