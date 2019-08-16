using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly RescueRegisterDbContext context;

        public MountaineerController(RescueRegisterDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new RescueRegisterDbContext())
            {
                var Rescue = db.Mountaineers.ToList();
                return this.View(Rescue);

            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            if (string.IsNullOrEmpty(mountaineer.Name) || string.IsNullOrEmpty(mountaineer.LastSeenDate) || mountaineer.Age < 0 || string.IsNullOrEmpty(mountaineer.Gender))
            {
                return RedirectToAction("Index");
            }
            using (var db = new RescueRegisterDbContext())
            {
                Mountaineer person = new Mountaineer
                {
                    Name = mountaineer.Name,
                    Age=mountaineer.Age,
                    Gender=mountaineer.Gender,
                    LastSeenDate=mountaineer.LastSeenDate        
                };
                db.Mountaineers.Add(person);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerToEdit = db.Mountaineers.FirstOrDefault(b => b.Id == id);
                if (mountaineerToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(mountaineerToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            if (string.IsNullOrEmpty(mountaineer.Name) || string.IsNullOrEmpty(mountaineer.LastSeenDate) || mountaineer.Age < 0 || string.IsNullOrEmpty(mountaineer.Gender))
            {
                return RedirectToAction("Index");
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Update(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerToDelete = db.Mountaineers.Find(id);
                return View(mountaineerToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Remove(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}