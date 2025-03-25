using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using To_Do_APP.Data;
using To_Do_APP.Models;

namespace To_Do_APP.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ToDoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<toDoList> objList = _db.ToDoLists.ToList();
            return View(objList);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(toDoList obj)
        {
            _db.ToDoLists.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var task = _db.ToDoLists.Find(id);
            if (task != null)
            {
                _db.ToDoLists.Remove(task);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var task = _db.ToDoLists.Find(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }
        [HttpPost]
        public IActionResult Edit(toDoList task)
        {
            if (ModelState.IsValid)
            {
                _db.ToDoLists.Update(task);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }


    }
}
