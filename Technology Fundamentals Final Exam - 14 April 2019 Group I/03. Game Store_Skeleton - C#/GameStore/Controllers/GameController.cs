using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var game = db.Games.ToList();
                return this.View(game);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            if (string.IsNullOrEmpty(game.Name) || string.IsNullOrEmpty(game.Platform)||game.Price<0||string.IsNullOrEmpty(game.Dlc))
            {
                return RedirectToAction("Index");
            }
            using (var db = new GameStoreDbContext())
            {
                Game newGame = new Game
                {
                    Name = game.Name,
                    Platform = game.Platform,
                    Dlc = game.Dlc,
                    Price=game.Price
                };
                db.Games.Add(newGame);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(b => b.Id == id);
                if (gameToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(gameToEdit);
            }
        }
        
        [HttpPost]
        public IActionResult Edit(Game game)
        {
        if (string.IsNullOrEmpty(game.Name) || string.IsNullOrEmpty(game.Platform)||game.Price<0||string.IsNullOrEmpty(game.Dlc))
            {
                return RedirectToAction("Index");
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new GameStoreDbContext())
            {
                db.Games.Update(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
  
        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToDelete = db.Games.Find(id);
                return View(gameToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}