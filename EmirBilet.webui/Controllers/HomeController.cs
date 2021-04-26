
using emirbilet.business.Abstract;
using EmirBilet.webui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmirBilet.webui.Controllers
{
    public class HomeController : Controller
    {

        private ISehirService _sehirService;
        private IGuzergahService _guzergahService;

        public HomeController(ISehirService sehirService, IGuzergahService guzergahService)
        {
            this._sehirService = sehirService;
            this._guzergahService = guzergahService;
        }


        public IActionResult Index(string nereden, string nereye)
        {
            if(nereden == null || nereye==null || nereden==nereye)
            {
                var sehirModel = new BiletGuzergah()
                {
                    Sehirs = _sehirService.GetAll(),
                    Guzergahs = null
                };

                ViewBag.Sehirler = new SelectList(sehirModel.Sehirs, "SehirId", "SehirAd");
                return View(sehirModel);
            }
            else
            {
                var sehirModel = new BiletGuzergah()
                {
                    Sehirs = _sehirService.GetAll(),
                    Guzergahs = _guzergahService.GetYolculuk(nereden, nereye)
                };
                TempData["nereden"] = _guzergahService.GetNereden(nereden);
                TempData["nereye"] = _guzergahService.GetNereye(nereye);
                ViewBag.Sehirler = new SelectList(sehirModel.Sehirs, "SehirId", "SehirAd");
                return View(sehirModel);
            }
            

            
        }

        public IActionResult Iletisim()
        {
            ViewData["title"] = "İletişim - ";
            return View();
        }

    }
}
