using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webdev.Data;
using webdev.Models;


namespace webdev.Controllers
{
    public class TypeController: Controller
    {
        private readonly ApplicationDbContext _db;

        public TypeController(ApplicationDbContext database)
        {
            _db = database;
        }

        public IActionResult types()
        {
            IEnumerable<Type> objtypes =_db.typs;
            return View(objtypes);
        }[HttpGet]
        public IActionResult NewType()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditType(int idtype)
        {
             _db.typs.Find(idtype);
            _db.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult EditType(Type tp)
        {
            if(ModelState.IsValid)
            {
                _db.typs.Update(tp);
                _db.SaveChanges();
                return RedirectToAction("types");
            }
            return View();
        }
        public IActionResult NewType (Type tpys)
        {
            if(ModelState.IsValid)
            {
                _db.typs.Add(tpys);
                _db.SaveChanges();
                return RedirectToAction("types");
            }
            return View();
        }
    }
}