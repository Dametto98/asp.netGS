using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExtremeHelp.WebApp.Controllers
{
    public class AlertasController : Controller
    {
        // GET: AlertasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AlertasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlertasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlertasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlertasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlertasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlertasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlertasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
