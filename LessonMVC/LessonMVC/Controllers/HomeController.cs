using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LessonMVC.Models;

namespace LessonMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lesson1()
        {
            return View();
        }

        public ActionResult Lesson2()
        {
            return View();
        }

        public ActionResult Demo1()
        {
            return View();
        }

        public ActionResult Demo1_2(int apple, int banana,int watermelon)
        {
            ViewBag.apple = apple * 10;
            ViewBag.banana = banana * 5;
            ViewBag.watermelon = watermelon * 50;
            ViewBag.total = apple * 10 + banana * 5 + watermelon * 50;
            return View();
        }

        public ActionResult Lesson3()
        {
            return View();
        }

        public ActionResult Demo2()
        {
            return View();
        }

        public ActionResult Demo2_2(int apple, int banana, int watermelon)
        {
            FruitPrice fruitprice = new FruitPrice();

            ViewBag.apple = fruitprice.applePrice * apple;
            ViewBag.banana = fruitprice.bananaPrice * banana;
            ViewBag.watermelon = fruitprice.watermelonPrice * watermelon;
            ViewBag.total = fruitprice.applePrice * apple + fruitprice.bananaPrice * banana + fruitprice.watermelonPrice * watermelon;

            return View();
        }
    }
}