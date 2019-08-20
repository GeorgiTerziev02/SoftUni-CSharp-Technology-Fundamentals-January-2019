﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Data;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController:Controller
    {
        public IActionResult Index()
        {
            using (var db=new TeisterMaskDbContext())
            {
                var tasks = db.Tasks.ToList();
                return this.View(tasks);
            }            
        }
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(string title,string status)
        {
            if (string.IsNullOrEmpty(title)||string.IsNullOrEmpty(status))
            {
                return RedirectToAction("Index");
            }
            using (var db = new TeisterMaskDbContext())
            {
                Task task = new Task
                {
                    Title = title,
                    Status=status
                };
                db.Tasks.Add(task);
                db.SaveChanges();         
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToEdit = db.Tasks.Find(id);
                return View(taskToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            using (var db = new TeisterMaskDbContext())
            {
                db.Tasks.Update(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.Find(id);
                return View(taskToDelete);
            }
        }
        [HttpPost]
        public IActionResult Delete(Task task)
        {
            using (var db = new TeisterMaskDbContext())
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
