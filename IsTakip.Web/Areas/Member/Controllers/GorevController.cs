using IsTakip.Business.Concrete;
using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class GorevController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IGorevService _gorevService;
        public GorevController(UserManager<AppUser> userManager, IGorevService gorevService)
        {
            _userManager = userManager;
            _gorevService = gorevService;
        }
        public async Task<IActionResult> Index(int aktifSayfa = 1)
        {
            TempData["Active"] = "gorev";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            int toplamSayfa;
            var gorevler = _gorevService.GetirTumTablolarlaTamamlanmayan(out toplamSayfa, user.Id, aktifSayfa);

            ViewBag.ToplamSayfa = toplamSayfa;
            ViewBag.AktifSayfa = aktifSayfa;

            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            foreach (var gorev in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.Id = gorev.Id;
                model.Ad = gorev.Ad;
                model.AppUser = gorev.AppUser;
                model.OlusturulmaTarihi = gorev.OlusturulmaTarihi;
                model.Raporlar = gorev.Raporlar;
                model.Aciklama = gorev.Aciklama;
                model.Aciliyet = gorev.Aciliyet;
                models.Add(model);
            }
            return View(models);
        }
    }
}
