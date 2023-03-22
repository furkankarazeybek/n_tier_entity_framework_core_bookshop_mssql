using GRSYKitapEvi_DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GRSYKitapEvi_Model.Models;
using System.Linq;
using System;

namespace GRSYKitapEvi.Controllers
{
    public class YayinEviController : Controller
    {

        private readonly ApplicationDbContext _db;

        public YayinEviController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<YayınEvi> objList = _db.Yayinevleri.ToList();
            return View(objList);
        }

        public IActionResult Update_Insert(int? id)
        {
            YayınEvi obj = new YayınEvi();
            if(id == null)
            {
                return View(obj);
            }

            obj = _db.Yayinevleri.FirstOrDefault(a => a.YayinEvi_Id == id);

            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(YayınEvi obj)
        {
            if (ModelState.IsValid)
            {
                if(obj.YayinEvi_Id == 0)
                {
                    //Create 
                    _db.Yayinevleri.Add(obj);

                }
                else
                {
                    //Update
                    _db.Yayinevleri.Update(obj);
                }

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(obj);

        }

        public IActionResult Sil(int id)
        {
            var objDb = _db.Yayinevleri.FirstOrDefault(a => a.YayinEvi_Id == id);
            _db.Yayinevleri.Remove(objDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult CokluEkleme3()
        {
            List<Kategori> KategoriListesi = new List<Kategori>();
            for (int i = 1; i<=3; i++)
            {
                KategoriListesi.Add(new Kategori { KategoriAd = Guid.NewGuid().ToString() });
            }


            _db.Kategoriler.AddRange(KategoriListesi);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult CokluEkleme10()
        {
            List<Kategori> KategoriListesi = new List<Kategori>();
            for (int i = 1; i <= 10; i++)
            {
                KategoriListesi.Add(new Kategori { KategoriAd = Guid.NewGuid().ToString() });
            }


            _db.Kategoriler.AddRange(KategoriListesi);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CokluSilme3()
        {
            IEnumerable<Kategori> KategoriListesi = _db.Kategoriler.OrderByDescending(a => a.KategoriId).Take(3).ToList();
           

            _db.Kategoriler.RemoveRange(KategoriListesi);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CokluSilme10()
        {
            IEnumerable<Kategori> KategoriListesi = _db.Kategoriler.OrderByDescending(a => a.KategoriId).Take(10).ToList();


            _db.Kategoriler.RemoveRange(KategoriListesi);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
