using GRSYKitapEvi_DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GRSYKitapEvi_Model.Models.ViewModels;
using GRSYKitapEvi_Model.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GRSYKitapEvi.Controllers
{
    public class KitapController : Controller
    {

        private readonly ApplicationDbContext _db;

        public KitapController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            //EAGER LOADING

            List<Kitap> objList = _db.Kitaplar.Include(a => a.YayınEvi).Include(a=> a.Kategori).ToList();

            //

           

            //--------------------------------------------------
            //List<Kitap> objList = _db.Kitaplar.ToList();


            ////yayınevi ve kategori
            //foreach ( var obj in objList)
            //{

            //    //1.yol - productive - EXPLICIT LOADING
            //    _db.Entry(obj).Reference(a => a.YayınEvi).Load();

            //    _db.Entry(obj).Reference(a => a.Kategori).Load();


            //    //2.yol
            //   // obj.YayınEvi = _db.Yayinevleri.FirstOrDefault(a => a.YayinEvi_Id == obj.YayınEviIdForeign);
            //}
            return View(objList);
        }

        public IActionResult Update_Insert(int? id)
        {
            KitapVM obj = new KitapVM();

            //dropdown-yayınevi
            obj.YayınEviListesi = _db.Yayinevleri.Select(a=> new SelectListItem
            {
                Text = a.YayinEviAdi,
                Value = a.YayinEvi_Id.ToString()
            });

            //dropdown-kategori
            obj.KategoriListesi = _db.Kategoriler.Select(a => new SelectListItem
            {
                Text = a.KategoriAd,
                Value = a.KategoriId.ToString()
            });


            if (id == null)
            {
                return View(obj);
            }

            //düzenleme

            obj.Kitap = _db.Kitaplar.FirstOrDefault(a => a.Kitap_Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(KitapVM obj)
        {
          
                if (obj.Kitap.Kitap_Id == 0)
                {
                    //Create 
                    _db.Kitaplar.Add(obj.Kitap);

                }
                else
                {
                    //Update
                    _db.Kitaplar.Update(obj.Kitap);
                }

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            

           

        }

        public IActionResult Sil(int id)
        {
            var objDb = _db.Kitaplar.FirstOrDefault(a => a.Kitap_Id == id);
            _db.Kitaplar.Remove(objDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


        public IActionResult Detaylar(int? id)
        {
            KitapVM obj = new KitapVM();

           

            if (id == null)
            {
                return View(obj);
            }

            //düzenleme

            //EAGER LOADING
            obj.Kitap = _db.Kitaplar.Include(a => a.KitapDetay).FirstOrDefault(a => a.Kitap_Id == id);
            //

            //--------------------------------------------------------------------------//
            //obj.Kitap = _db.Kitaplar.FirstOrDefault(a => a.Kitap_Id == id);
            //obj.Kitap.KitapDetay = _db.KitapDetaylari.FirstOrDefault(a => a.KitapDetay_Id == obj.Kitap.KitapDetayIdForeign);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detaylar(KitapVM obj)
        {

            if (obj.Kitap.KitapDetay.KitapDetay_Id == 0)
            {
                //Create 
                _db.KitapDetaylari.Add(obj.Kitap.KitapDetay);
                _db.SaveChanges();

                var KitapDb = _db.Kitaplar.FirstOrDefault(a => a.Kitap_Id == obj.Kitap.Kitap_Id);

                KitapDb.KitapDetayIdForeign = obj.Kitap.KitapDetay.KitapDetay_Id;
                _db.SaveChanges();

            }
            else
            {
                //Update
                _db.KitapDetaylari.Update(obj.Kitap.KitapDetay);
                _db.SaveChanges();
            }

          
            return RedirectToAction(nameof(Index));




        }

        public IActionResult ABC()
        {

            //IEnumerable
            IEnumerable<Kitap> KiptaListesi1 = _db.Kitaplar;
            var filtreleme1 = KiptaListesi1.Where(a => a.Fiyat > 25).ToList();
            //

            //IQueryable
            IQueryable<Kitap> KiptaListesi2 = _db.Kitaplar;
            var filtreleme2 = KiptaListesi2.Where(a => a.Fiyat > 25).ToList();

            return RedirectToAction(nameof(Index));

        }

    }
}
