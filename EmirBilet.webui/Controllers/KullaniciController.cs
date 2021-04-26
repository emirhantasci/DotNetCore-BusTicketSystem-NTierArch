using emirbilet.business.Abstract;
using EmirBilet.webui.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmirBilet.webui.Controllers
{
    public class KullaniciController : Controller
    {
        private IBiletService _biletService;
        public KullaniciController(IBiletService biletService)
        {
            this._biletService = biletService;
        }
        public IActionResult AdminList()
        {
            return View(new BiletGuzergah()
            {
                Bilets = _biletService.GetAll()
            });
        }

        public IActionResult IptalBilet(int biletId)
        {
            var bilet = _biletService.GetById(biletId);
            if (bilet!=null)
            {
                _biletService.Delete(bilet);
            }
            return RedirectToAction("AdminList");
        }
    }
}
