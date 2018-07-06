using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class MainGridController : Controller
    {
        // GET: MainGrid
        public ActionResult Index()
        {
            return View();
        }

        // GET: MainGrid/Details/5
        public ActionResult Download(int id)
        {
            return View();
        }

        public ActionResult Download(List<int> ids)
        {
            return View();
        }

        // GET: MainGrid/Delete/5
        public ActionResult Delete(bool isCorrect, List<string> corrects, List<string> incorrects, int cantCorrect = 0, int cantIncorrect = 0)
        {
            ViewData["isCorrect"] = isCorrect;
            ViewData["cantCorrect"] = cantCorrect;
            if (corrects is null) corrects = new List<string>();
            ViewData["corrects"] = corrects;
            ViewData["cantIncorrect"] = cantIncorrect;
            if (incorrects is null) incorrects = new List<string>();
            ViewData["incorrects"] = incorrects;
            ViewData["cant"] = cantCorrect + cantIncorrect;
            return View();
        }

        // POST: MainGrid/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}