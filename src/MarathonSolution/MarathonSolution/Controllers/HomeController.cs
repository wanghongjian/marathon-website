using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarathonSolution.Models;

namespace MarathonSolution.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        marathon_dbEntities db; 
        public HomeController()
        {
            db = new marathon_dbEntities();
        }
        public ActionResult Index()
        {
            //ViewData["Message"] = "Welcome to ASP.NET MVC!";
            ViewData.Model = db.Race.ToList();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult AddRace(RaceModel model)
        {
            var raceAdd = new RaceModel();

            try
            {
                db.AddToRace(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(raceAdd);
            }
        }
        public ActionResult Update(RaceModel model,int id)
        {
            var editModel = db.Race.First(m => m.Id == id);
            try
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(editModel);
            }
        }
    }
}
