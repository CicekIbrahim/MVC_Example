using Microsoft.AspNetCore.Mvc;
using YazilimGerceklemeMVC.Data;
using YazilimGerceklemeTest.Models;

namespace YazilimGerceklemeTest.Controllers
{
    public class AracController : Controller
    {

        private readonly ApplicationDbContext _database;

        public AracController(ApplicationDbContext database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            IEnumerable<Arac> AracList = _database.Araclar;
            return View(AracList);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Arac obj)
        {
            if (ModelState.IsValid)
            {
                _database.Araclar.Add(obj);
                _database.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var AracFromDb = _database.Araclar.Find(id);


            if (AracFromDb == null)
            {
                return NotFound();
            }

            return View(AracFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Arac obj)
        {

            if (ModelState.IsValid)
            {

                _database.Araclar.Update(obj);
                _database.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var AracFromDb = _database.Araclar.Find(id);
            if (AracFromDb == null)
            {
                return NotFound();
            }
            return View(AracFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _database.Araclar.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _database.Araclar.Remove(obj);
            _database.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}