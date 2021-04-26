using emirbilet.business.Abstract;
using emirbilet.entity;
using EmirBilet.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmirBilet.webui.Controllers
{
    public class YolculukController : Controller
    {
        private IGuzergahService _guzergahService;
        private IBiletService _biletService;

        public YolculukController(IGuzergahService guzergahService, IBiletService biletService)
        {
            
            this._guzergahService = guzergahService;
            this._biletService = biletService;
        }

        public IActionResult Details(int id)
        {
            Guzergah guzergah = _guzergahService.GetGuzergahDetails(id);
            int guzergahKoltukSayisi=_biletService.GetCountByKoltuk(id);
            List<int> dolukoltuklar = _biletService.GetKoltuk(id);
            var koltuklar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (var item in dolukoltuklar)
            {
                koltuklar.Remove(item);
            }
            
            ViewBag.Sayi = guzergahKoltukSayisi;
            ViewBag.Koltuklar = new SelectList(koltuklar); 

            if (guzergah == null)
            {
                return NotFound();
            }
            else
            {
                //var sehirModel = new BiletGuzergah()
                //{
                    
                //    YeniGuzergah = guzergah
                //};
                return View(guzergah);
            }
        }

        [HttpPost]
        public IActionResult Details(int guzergahId, double fiyat, string nereden, string nereye, int koltukno, string email, string isim, string soyisim)
        {
            var entity = new Bilet()
            {
                Ad = isim,
                Soyad=soyisim,
                Mail=email,
                Nereden=nereden,
                Nereye=nereye,
                KoltukNo=koltukno,
                Fiyat=fiyat,
                GuzergahId=guzergahId
            };
            _biletService.Create(entity);
            return RedirectToAction("Basarili");
        }

        

        public IActionResult Basarili()
        {
            Bilet yeni = _biletService.GetSonKayit();
            int guzergahid = _biletService.GetId();
            string guzergahsaat = _biletService.GetSaat(guzergahid);
            string guzergahtarih = _biletService.GetTarih(guzergahid);

            var BiletGuzergahh = new BiletGuzergah()
            {
                tarih=guzergahtarih,
                saat=guzergahsaat,
                bilet = yeni
            };
            return View(BiletGuzergahh);
        }
    }
}
