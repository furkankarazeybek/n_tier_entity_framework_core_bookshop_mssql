using GRSYKitapEvi_DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GRSYKitapEvi_Model.Models;
using System.Linq;
using System;

namespace GRSYKitapEvi.Controllers
{
    public class YazarController : Controller
    {

        private readonly ApplicationDbContext _db;

        public YazarController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<Yazar> objList = _db.Yazarlar.ToList();
            return View(objList);
        }

        public IActionResult Update_Insert(int? id)
        {
            Yazar obj = new Yazar();
            if(id == null)
            {
                return View(obj);
            }

            obj = _db.Yazarlar.FirstOrDefault(a => a.Yazar_Id == id);

            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(Yazar obj)
        {
            if (ModelState.IsValid)
            {
                if(obj.Yazar_Id == 0)
                {
                    //Create 
                    _db.Yazarlar.Add(obj);

                }
                else
                {
                    //Update
                    _db.Yazarlar.Update(obj);
                }

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(obj);

        }

        public IActionResult Sil(int id)
        {
            var objDb = _db.Yazarlar.FirstOrDefault(a => a.Yazar_Id == id);
            _db.Yazarlar.Remove(objDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        

    }
}
